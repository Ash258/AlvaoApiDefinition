using Dapper;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.API.Common;
using Alvao.Apps.API;
using Alvao.API.SD;

public class TicketAutoClose : IPeriodicAction
{
    public string Name
    {
        get => "TicketAutoClose";
        set { }
    }

    public void OnPeriod(SqlConnection con)
    {
        if (Settings.TAC_Hours != null && !Settings.TAC_Hours.Contains(DateTime.Now.Hour)) return;

        var ticketIdList = con.Query<int>(@"
SELECT
    t.iHdTicketId
FROM tHdTicket AS t
    INNER JOIN tHdSection AS s ON s.iHdSectionId = t.liHdTicketHdSectionId AND ISNULL(s.nHdSectionUserReopenDays, 0) > 0
WHERE t.ClosedDate IS NULL
	AND t.dHdTicketRemoved IS NULL
    AND DATEADD(day, s.nHdSectionUserReopenDays, t.dHdTicketResolved) < GETUTCDATE()");

        var systemPerson = Person.GetSystem();
        foreach (int ticketId in ticketIdList)
        {
            Ticket.Close(ticketId, systemPerson.iPersonId, Ticket.CloseFlags.IgnoreRights);
        }
    }
}
