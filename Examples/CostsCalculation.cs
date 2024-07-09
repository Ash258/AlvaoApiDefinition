using System;
using Alvao.API.Common.Model.CustomApps;
using Alvao.API.Common.Model.Database;
using Alvao.API.SD;
using Alvao.Apps.API;
using Alvao.Context;
using Dapper;

public class CostsCalculation : IEntityCommand
{
    public string Id { get; set; }
    public Entity Entity { get; set; }

    public CostsCalculation()
    {
        Id = Settings.CommandName.GetHashCode().ToString();
        Entity = Entity.Request;
    }

    public EntityCommandShowResult Show(int entityId, int personId)
    {
        int position = Settings.CommandPosition;
        string icon = Settings.CommandIcon;
        string name = Settings.CommandName;

        // Retrieve the required requirements data from the database.
        tHdTicket ticket = Ticket.GetById(entityId);
        if (ticket == null)
            return new EntityCommandShowResult(false, name, icon, position);

        // In the Show method, for performance reasons, it is more convenient to work with service ID, reseller, and status.
        int sectionId = ticket.liHdTicketHdSectionId; // Id of the service in which the request is made.
        int solverId = ticket.liHdTicketSolverPersonId ?? 0; // Request solver id.
        int stateId = ticket.TicketStateId; // Request status id.

        // Check whether the request is in the required service and status and the solver is the user to whom the request should be displayed.
        bool show = sectionId == Settings.ServiceId && stateId == Settings.StateId && solverId == personId;

        return new EntityCommandShowResult(show, name, icon, position);
    }

    public CommandResult Run(int entityId, int personId)
    {
        MessageType messageType = MessageType.None; // MessageType.None, MessageType.Info, MessageType.Warning, MessageType.Error
        string messageText = string.Empty; //message that is displayed to the user after the command is executed
        string navigateToUrl = string.Empty; //url that opens after executing the command

        // Check whether the conditions for its execution / display have not changed between display and execution of the command (can be done anywhere in this Run method).
        var verifyRights = Show(entityId, personId);
        if (!verifyRights.Show)
        {
            messageType = MessageType.Error;
            messageText = "The command cannot be executed because the conditions for its display are not met.";
            return new CommandResult(messageType, messageText, navigateToUrl);
        }

        using (var scope = AlvaoContext.GetConnectionScope())
        {
            scope.BeginTransaction();
            try
            {
                // Read values from custom fields "SW Costs" and "HW Costs".
                string strCostSW = Alvao.API.Common.Database.ReadColumn(entityId, "tHdTicketCust", "costSW");
                int costSW = string.IsNullOrEmpty(strCostSW) ? 0 : int.Parse(strCostSW);
                string strCostHW = Alvao.API.Common.Database.ReadColumn(entityId, "tHdTicketCust", "costHW");
                int costHW = string.IsNullOrEmpty(strCostHW) ? 0 : int.Parse(strCostHW);
                int costTotal = costSW + costHW;

                // Write the sum of costSW and costHW in your custom field Total costs.
                Alvao.API.Common.Database.WriteColumn(entityId, "tHdTicketCust", "costTotal", costTotal.ToString());

                //example of using custom SQL query within running transaction
                //scope.Connection.ExecuteAsync(@"UPDATE table SET column = @value WHERE id = @id", new { id = id, value = value }, scope.LegacyTransaction);

                scope.CommitTransaction();

                return new CommandResult(messageType, messageText, navigateToUrl);
            }
            catch (Exception)
            {
                messageType = MessageType.Error;
                messageText = "Error when saving the value.";
                scope.RollbackTransaction();
                return new CommandResult(messageType, messageText, navigateToUrl);
            }
        }
    }
}
