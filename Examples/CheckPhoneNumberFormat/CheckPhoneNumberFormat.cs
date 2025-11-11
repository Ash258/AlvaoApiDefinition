
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using Alvao.API.AM;
using Alvao.API.Common.Model.Database;
using Dapper;

class ObjectPropertyAutoAction : IObjectPropertyAutoAction
{
  public ObjectPropertyModifyResult OnObjectPropertyModifying(ObjectPropertyEventArgs e)
  {
    if (Settings.propName != ObjectProperty.GetDefinition(e.PropertyKindId)?.txtName)
      return new ObjectPropertyModifyResult(true, (string)null);

    // Value was empty.
    if (e.NewValue is null)
      return new ObjectPropertyModifyResult(true, (string)null);

    // Check formatting.
    var matches = Settings.rx.Matches(e.NewValue.ToString());

    if (matches.Count == 0)
      return new ObjectPropertyModifyResult(true, Settings.errorMessage);

    // The number was entered in a valid format.
      return new ObjectPropertyModifyResult(true, (string)null);
  }

  public void OnObjectPropertyModified(ObjectPropertyEventArgs e)
  {
    throw new NotImplementedException();
  }
}
          
