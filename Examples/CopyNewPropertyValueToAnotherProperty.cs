using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using Dapper;

class CopyNewPropertyValueToAnotherProperty : IObjectPropertyAutoAction
{
    public Tuple<bool, string> OnObjectPropertyModifying(SqlConnection con, int propertyId, int personId, string newValue)
    {
        throw new NotImplementedException();
    }

    public void OnObjectPropertyModified(SqlConnection con, int propertyId, int personId)
    {
        string phoneValue = "";
        int phonePropertyId = 0;
        string telephoneNumber = "";
        string loadedPropertyName = "";
        int objectId = 0;
        Dictionary<string, string> properties = new Dictionary<string, string>(); // The dictionary of properties to update in database.

        // Was the phone number edited?
        (loadedPropertyName, objectId, telephoneNumber) = con.QueryFirstOrDefault<(string, int, string)>(@"
            select k.txtName as result, p.lintNodeId as objectId, p.txtValue as telephoneNumber
            from tblProperty p join tblKind k on k.intKindId = p.lintKindId
            where p.intPropertyId=@propertyId",
            new { propertyId });

        // Get the current Phone property value.
        if (loadedPropertyName.Equals(Settings.CNPVTAP_UpdatedPropertyName))
        {
            (phoneValue, phonePropertyId) = con.QueryFirstOrDefault<(string, int)>(@"
                select p.txtValue as newValue, p.intPropertyId as propertyId
                from tblProperty p
                join tblKind k on k.intKindId = p.lintKindId
                join tblNode n on n.intNodeId = p.lintNodeId
                where n.intNodeId=@objectId and k.txtName=@txtName",
                new { objectId, txtName = Settings.CNPVTAP_ServiceName });

            // If there was no value in the Phone property, it will be added.
            if (phonePropertyId != 0 && string.IsNullOrEmpty(phoneValue))
            {
                properties.Add(Settings.CNPVTAP_ServiceName, telephoneNumber);

                Alvao.API.AM.ObjectProperty.Update(personId, objectId, properties);
            }
        }
    }

    public void OnPropertyModified(SqlConnection con, int propertyId, int personId)
    {
        throw new NotImplementedException();
    }
}
