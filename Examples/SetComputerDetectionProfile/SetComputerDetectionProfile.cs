using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using Dapper;

class ObjectMoveAutoAction : IObjectMoveAutoAction
{
    public Tuple<bool, string> OnObjectMoving(SqlConnection con, int objectId, int newParentObjectId, int personId)
    {
        throw new NotImplementedException();
    }

    public void OnObjectMoved(SqlConnection con, int objectId, int  oldParentObjectId, int personId)
    {
        var movedObject = Alvao.API.AM.Object.GetById(personId, objectId);
        int detectProfileId;

        // Is the moved object computer?
        if (movedObject.lintClassId.HasValue && 
            movedObject.lintClassId.Value == Settings.movedObjectClassIdToCheck)
        {
            // Extracting the detection profile by its name.
            detectProfileId = con.QueryFirstOrDefault<int>(@"SELECT id from DetectProfile WHERE ProfileName = @detectProfileName", 
                new { detectProfileName = Settings.detectionProfileName });
            if (detectProfileId < 1)
                return;

            // Has computer already the detection profile set up? If so, end the action itself.
            if (movedObject.DetectProfileId.HasValue && movedObject.DetectProfileId.Value == detectProfileId)
                return;

            // Was the object in the warehouse? If so and it did not have a detection profile named Standard, assign it to him.
            if (Alvao.API.AM.Object.IsDescendantOf(oldParentObjectId, Settings.oldParentobjectClassId))
            { 
                con.Execute(@"UPDATE tblNode
                    SET DetectProfileId = @profileId
                    WHERE intNodeId = @nodeId",
                    new { profileId = detectProfileId, nodeId = movedObject.intNodeId });
            }
        } 
    }
}
