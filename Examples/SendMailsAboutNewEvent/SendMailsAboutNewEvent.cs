using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using Dapper;

namespace Alvao.Helpdesk
{
    class SendMailsAboutNewEvent : IActAutoAction
    {
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public SendMailsAboutNewEvent()
        {
            name = Settings.ActionName;
        }

        public void OnActChanged(SqlConnection con, SqlTransaction trans, int ticketId, int personId, string properties) {
            throw new NotImplementedException();
        }
        public void OnActRemoved(SqlConnection con, SqlTransaction trans, int ticketId, int personId) {
            throw new NotImplementedException();
        }

        public void OnActCreated(SqlConnection con, SqlTransaction trans, int actId, int personId)
        {
            // Get values.
            var dataModel = con.QueryFirstOrDefault<DataModel>(@"SELECT liActHdTicketId as TicketId, sActFrom as ActFrom, sActFromEmail as ActFromEmail, 
                sActTo as ActTo, sActToEmail as ActToEmail, sAct as ActSubject, mActNotice as ActPlainText, sHdSection as SectionName, sHdSectionEmail as SectionEmail, iHdSectionId as SectionId
                FROM tAct a
                join tHdTicket t on a.liActHdTicketId=t.iHdTicketId
                join tHdSection s on t.liHdTicketHdSectionId=s.iHdSectionId 
                WHERE iActId = @actId", new { actId }, trans);
                
            if (dataModel == null)
                return;

            dataModel.ActPlainText = "Hello,\n\n a new note was created on the request number " + dataModel.TicketId.ToString() + ":\n\n" + dataModel.ActPlainText;

            // Check values.
            if (dataModel.SectionName == Settings.ServiceName)
            {
                List<string> recipients = new List<string>();
                var personEmails = con.Query<string>(@"select sPersonEmail from HdSectionManager 
                    left join tPerson on iPersonId = PersonId 
                    where sPersonEmail is not null
                        and bPersonAccountDisabled = 0
                        and HdSectionId = @sectionId", new { sectionId = dataModel.SectionId }, trans);
                foreach(var personEmail in personEmails)
                {    
                    if (!dataModel.ActTo.Contains(personEmail) && !dataModel.ActToEmail.Contains(personEmail) && !dataModel.ActFrom.Contains(personEmail) && !dataModel.ActFromEmail.Contains(personEmail))
                        recipients.Add(personEmail);
                }

                // Send e-mail.
                if (recipients.Count > 0)
                {
                    string to = String.Join(";", recipients);
                    string from = dataModel.SectionEmail;
                    string subject = dataModel.ActSubject;
                    string body = dataModel.ActPlainText;
                    System.Net.Mail.MailMessage message = new MailMessage(from, to, subject, body);
                    Alvao.API.Common.Email.Queue(message);
                }
            }
        }

        class DataModel
        {
            public int TicketId {get;set;} = 0;
            public int SectionId {get;set;} = 0;
            public string ActFrom {get;set;} = "";
            public string ActFromEmail {get;set;} = "";
            public string ActTo {get;set;} = "";
            public string ActToEmail {get;set;} = "";
            public string ActSubject {get;set;} = "";
            public string ActPlainText {get;set;} = "";
            public string SectionName {get;set;} = "";
            public string SectionEmail {get;set;} = "";
        }
    } 
}
