using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using Dapper;

class CheckPhoneNumberFormat : IObjectPropertyAutoAction
{
    public Tuple<bool, string> OnObjectPropertyModifying(SqlConnection con, int propertyId, int personId, string newValue)
    {
        // Is the Phone Number being edited?
        Settings.CPNF_isPhoneNumber = con.QueryFirstOrDefault<bool>(@"
            select 1
            from tblProperty p
            join tblKind k on k.intKindId = p.lintKindId
            where p.intPropertyId=@propertyId and k.txtName=@propName",
            new { propertyId, propName = Settings.CPNF_propName });

        if (!Settings.CPNF_isPhoneNumber)
        {
            return Tuple.Create(true, (string)null);
        }

        // Value was empty.
        if (string.IsNullOrEmpty(newValue))
        {
            return Tuple.Create(true, (string)null);
        }

        // Check formatting.
        var matches = Settings.CPNF_rx.Matches(newValue);

        if (matches.Count == 0)
        {
            return Tuple.Create(false, Settings.CPNF_errorMessage);
        }

        // The number was entered in a valid format.
        return Tuple.Create(true, (string)null);
    }

    public void OnObjectPropertyModified(SqlConnection con, int propertyId, int personId)
    {
        throw new NotImplementedException();
    }

    public void OnPropertyModified(SqlConnection con, int propertyId, int personId)
    {
        throw new NotImplementedException();
    }
}
