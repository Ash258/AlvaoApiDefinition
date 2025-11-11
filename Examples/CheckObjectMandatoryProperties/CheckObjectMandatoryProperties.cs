using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;

class ObjectMoveAutoAction : IObjectMoveAutoAction
{
    public Tuple<bool, string> OnObjectMoving(SqlConnection con, int objectId, int newParentObjectId, int personId)
    {
        var objectToMove = Alvao.API.AM.Object.GetById(personId, objectId);

	    // Is any value for mandatory properties missing?
        if (objectToMove.RequiredPropertyAlert == true)
        {
		    // If the object being moved was in the Storage room and some mandatory properties are not filled in, show an error.
            if (Alvao.API.AM.Object.IsDescendantOf(objectId, Settings.ObjectClassToCheckId)
                && (newParentObjectId == 0 || !Alvao.API.AM.Object.IsDescendantOf(newParentObjectId, Settings.ObjectClassToCheckId)))
            {
                return Tuple.Create(false, Settings.ErrorMessage);
            }
        }

        return Tuple.Create(true, (string)null);
    }

    public void OnObjectMoved(SqlConnection con, int objectId, int  oldParentObjectId, int personId)
    {
        throw new NotImplementedException();
    }
}
