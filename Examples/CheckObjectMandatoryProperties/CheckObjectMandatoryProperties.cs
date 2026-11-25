using System;
using System.Threading;
using System.Threading.Tasks;
using Alvao.Apps.API;

class ObjectMoveAutoAction : IObjectMoveAutoAction
{
		public async Task<Tuple<bool, string>> OnObjectMovingAsync(ObjectEventArgs e, CancellationToken cancellationToken)
		{
				var objectToMove = Alvao.API.AM.Object.GetById(e.PersonId, e.ObjectId);

			// Is any value for mandatory properties missing?
				if (objectToMove.RequiredPropertyAlert == true)
				{
				// If the object being moved was in the Storage room and some mandatory properties are not filled in, show an error.
						if (Alvao.API.AM.Object.IsDescendantOf(e.ObjectId, Settings.ObjectClassToCheckId)
								&& (e.ParentObjectId == 0 || !Alvao.API.AM.Object.IsDescendantOf(e.ParentObjectId, Settings.ObjectClassToCheckId)))
						{
								return Tuple.Create(false, Settings.ErrorMessage);
						}
				}

				return Tuple.Create(true, (string)null);
		}

		public async Task OnObjectMovedAsync(ObjectEventArgs e, CancellationToken cancellationToken)
		{
				throw new NotImplementedException();
		}
}
