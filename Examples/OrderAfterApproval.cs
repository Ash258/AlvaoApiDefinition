using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.API.Common;
using Alvao.Apps.API;
using System.Collections.Generic;
using Alvao.API.Common.Model.Database;
using System.Linq;

public class OrderAfterApproval : ITicketApprovalAutoAction
{
    public string Name { get => Settings.OAA_ActionName; set => Name = value; }

    public void OnApproved(SqlConnection con, SqlTransaction trans, int ticketId, int approvalItemId)
    {
        string sectionName = Alvao.API.Common.Database.ReadColumn(ticketId, "TicketForeignKeyInfo", "SectionName");
        string stateName = Alvao.API.SD.TicketState.GetCurrentStateByTicketId(ticketId)._TicketState;

        // Approval information (approver, comment, etc.)
        tHdTicketApprovalItem currentApprovalItem = Alvao.API.SD.Approval.GetApprovalItemById(approvalItemId);

        if (sectionName != Settings.OAA_ServiceName || stateName != Settings.OAA_State) return;

        // Returns a list of current approval approvers, including their decisions.
        IEnumerable<tHdTicketApprovalItem> approvalItems = Alvao.API.SD.Approval.GetCurrentApprovalItems(ticketId);

        // If everyone approved.
        if (approvalItems.Where(s => s.liHdTicketApprovalItemHdTicketApprovalItemResultId == (int)tHdTicketApprovalItem.ApprovalResult.Accepted).Count() != approvalItems.Count()) return;

        Alvao.API.Common.Model.Database.TicketState targetState = Alvao.API.SD.TicketState.GetByName(Settings.OAA_TargetState, ticketId);

        if (targetState == null)
            return;

        int systemPersonId = Alvao.API.Common.Person.GetSystem().iPersonId;

        // Status change.
        Alvao.API.SD.Ticket.ChangeState(ticketId, targetState.id, systemPersonId, null);
    }

    public void OnRejected(SqlConnection con, SqlTransaction trans, int ticketId, int approvalItemId)
    {
        throw new NotImplementedException();
    }

    public void OnApproverAdded(SqlConnection con, SqlTransaction trans, int ticketId, IEnumerable<int> approvalItemIds)
    {
        throw new NotImplementedException();
    }

    public void OnApproverCanceled(SqlConnection con, SqlTransaction trans, int ticketId, IEnumerable<int> approvalItemIds)
    {
        throw new NotImplementedException();
    }
}
