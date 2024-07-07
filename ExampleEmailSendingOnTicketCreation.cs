using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.Global;
using Alvao.API.Common;
using Alvao.Apps.API;
using Alvao.API.Common.Model.Database;
using Alvao.API.SD;

public class Settings
{
    public const int SD_SECTION_NAME = 123;
    public const string SD_BASE_URL = "https://tenant.onalvao.com/Alvao/Ticket/";
    public const string AM_RECIPIENTS_TO = "example@example.com";
}

public class ExampleEmailSendingOnTicketCreation : ITicketAutoAction
{
    public string Name
    {
        get => "ExampleEmailSendingOnTicketCreation";
        set { }
    }

    public void OnTicketChanged(SqlConnection con, SqlTransaction trans, int ticketId, int personId, string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnTicketCreated(SqlConnection con, SqlTransaction trans, int ticketId, int personId)
    {
        tHdTicket ticket = Ticket.GetById(ticketId);

        // Report only tickets created in specified section/service
        if (!ticket.liHdTicketHdSectionId.Equals(Settings.SD_SECTION_NAME)) return;

        //string description = Alvao.API.SD.Ticket.ForeignKeyInfo(ticketId, "FirstActText");
        List<Alvao.API.Common.Model.IAttachment> Attachments = new List<Alvao.API.Common.Model.IAttachment>(); //Create list of attachments

        string link = $"{Settings.SD_BASE_URL}/{ticketId}";
        string mes = $@"
        <html>
            <body>
                Hello<br/><br/>

                New security incident was reported by <a href=""mailto:{ticket.sHdTicketUserEmail}"">{ticket.sHdTicketUser}</a>.<br/><br/>

                More information could be found in the ticket details: <a href=""{link}"">{ticket.sHdTicket} ({ticket.sHdTicketMessageTag})<a/>
            </body>
        </html>
        ";

        Alvao.API.Common.Model.HtmlTextModel emailMessage = new Alvao.API.Common.Model.HtmlTextModel(mes, Attachments); //Create message with attachment
        Alvao.API.SD.Model.SendMessageSettingsModel emailModel = new Alvao.API.SD.Model.SendMessageSettingsModel();
        emailModel.RecipientsTo = Settings.AM_RECIPIENTS_TO;

        Alvao.API.SD.Message.Send(ticketId, "New Security incident created: " + ticket.sHdTicket + " by " + ticket.sHdTicketUser, personId, emailMessage, emailModel);
    }
}
