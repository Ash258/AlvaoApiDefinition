using System;
using System.Threading;
using System.Threading.Tasks;
using Alvao.Apps.API;
using Alvao.Context;
using Dapper;

class ObjectMoveAutoAction : IObjectMoveAutoAction
{
    public async Task<Tuple<bool, string>> OnObjectMovingAsync(ObjectEventArgs e, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task OnObjectMovedAsync(ObjectEventArgs e, CancellationToken cancellationToken)
    {
        var movedObject = Alvao.API.AM.Object.GetById(e.PersonId, e.ObjectId);
        int detectProfileId;

        using var scope = AlvaoContext.GetConnectionScope();

        // Is the moved object computer?
        if (movedObject.lintClassId == Settings.movedObjectClassIdToCheck)
        {
            // Extracting the detection profile by its name.
            detectProfileId = scope.Connection.QueryFirstOrDefault<int>(@"SELECT id from DetectProfile WHERE ProfileName = @detectProfileName", 
                new { detectProfileName = Settings.detectionProfileName });
            if (detectProfileId < 1)
                return;

            // Has computer already the detection profile set up? If so, end the action itself.
            if (movedObject.DetectProfileId.HasValue && movedObject.DetectProfileId.Value == detectProfileId)
                return;

            // Was the object in the storage room? If so and it did not have a detection profile named Standard, assign it to him.
            if (Alvao.API.AM.Object.IsDescendantOf(e.ParentObjectId, Settings.oldParentobjectClassId))
            { 
                scope.Connection.Execute(@"UPDATE tblNode
                    SET DetectProfileId = @profileId
                    WHERE intNodeId = @nodeId",
                    new { profileId = detectProfileId, nodeId = movedObject.intNodeId });
            }
        } 
    }
}
