
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using Alvao.API.AM;
using Alvao.API.Common.Model.Database;
using Dapper;
using Alvao.Context;

class ObjectPropertyAutoAction : IObjectPropertyAutoAction
{
  public ObjectPropertyModifyResult OnObjectPropertyModifying(ObjectPropertyEventArgs e)
  {
    throw new NotImplementedException();
  }

  public void OnObjectPropertyModified(ObjectPropertyEventArgs e)
  {
    string currentPhoneValue = "";
    int phoneKindId = 0;
    string telephoneNumber = "";
    string loadedPropertyName = "";
    var properties = new Dictionary<string, object>(); // The dictionary of properties to update in database.
    tblKind telephoneNumberProperty = ObjectProperty.GetDefinition(e.PropertyKindId); // Getting column name for NodeCust table through API method.

    using (var scope = AlvaoContext.GetConnectionScope())
    {
      var sql = @$"
      select k.txtName as loadedPropertyName, nc.{telephoneNumberProperty?.ColumnName} as telephoneNumber
      from vNodeProperty np
      join tblKind k on k.intKindId = np.KindId
      join NodeCust nc on nc.NodeId = np.NodeId
      where np.NodeId = @objectId and k.intKindId = @propertyKindId";

      // Was the phone number edited?
      (loadedPropertyName, telephoneNumber) = scope.Connection.QueryFirstOrDefault<(string, string)>(sql, new { e.ObjectId, e.PropertyKindId });

      // Get the current Phone property value.
      if (loadedPropertyName.Equals(Settings.UpdatedPropertyName))
      {
        sql = @$"
        declare @sql nvarchar (max)
        declare @columnName nvarchar (255) = (select ColumnName from tblKind where txtName = @propertyKindName) -- Getting column name for NodeCust table through SQL.

        SET @sql =
        'select nc.['+@columnName+'] as currentPhoneValue, np.KindId as phoneKindId
        from vNodeProperty np
        join tblKind k on k.intKindId = np.KindId
        join NodeCust nc on nc.NodeId = np.NodeId
        where np.NodeId=@objectId and k.txtName=@propertyKindName'

        exec sp_executesql @sql, N'@objectId int, @propertyKindName nvarchar(255)', @objectId, @propertyKindName";

        (currentPhoneValue, phoneKindId) = scope.Connection.QueryFirstOrDefault<(string, int)>(sql, new { e.ObjectId, propertyKindName = Settings.PropertyKindName });

        // If there was no value in the Phone property, it will be added.
        if (phoneKindId != 0 && string.IsNullOrEmpty(currentPhoneValue))
        {
          properties.Add(Settings.PropertyKindName, telephoneNumber);

          Alvao.API.AM.ObjectProperty.Update(e.PersonId, e.ObjectId, properties);
        }
      }
    }
  }

    public void OnPropertyModified(ObjectPropertyEventArgs e) {
        throw new NotImplementedException();
    }
}
          
