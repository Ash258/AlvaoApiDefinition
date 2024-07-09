using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using Alvao.API.Common;

namespace Alvao.Helpdesk
{
    class ReportProblem : IGeneralCommand
    {
        CommandDesc commandDesc;

        public CommandDesc CommandDesc
        {
            get { return commandDesc; }
            set { commandDesc = value; }
        }

        public ReportProblem()
        {
            int id = Settings.CommandId;
            string name = Settings.CommandName;
            int position = Settings.CommandPosition;
            string icon = Settings.CommandIcon;

            commandDesc = new CommandDesc(id, name, position, icon);
        }

        public bool Show(SqlConnection con, int personId)
        {
            bool show = false;
            bool isRequester = PersonRights.IsAnySectionRoleMember(personId, PersonRights.SectionRoles.Requester);
            bool isOperator = PersonRights.IsAnySectionRoleMember(personId, PersonRights.SectionRoles.MainSolver);

            // If user is requester and not operator, command is shown.
            if (isRequester && !isOperator)
                show = true;

            return show;
        }

        public Tuple<bool, string, string> Run(SqlConnection con, int personId)
        {
            bool complete = false;
            string message = "";
            string url = "";

            // Check whether the conditions for its execution / display have not changed between display and execution of the command (can be done anywhere in this Run method).
            if (!Show(con, personId))
            {
                message = "The command cannot be executed because the conditions for its display are not met.";
                complete = false;
                return Tuple.Create(complete, message, url);
            }

            // Finding the WA address.
            string waUrl = Alvao.API.Common.DbProperty.WebAppUrl;

            if (!string.IsNullOrEmpty(waUrl))
            {
                // Part of the problem reporting services catalog.
                url = waUrl + Settings.ProblemServiceCatalogUrl;

                complete = true;
            }
            else
            {
                message = "The command cannot be executed because the WebApp URL setting is missing in the ALVAO system. Please contact the ALVAO system administrator.";
                complete = false;
            }
            return Tuple.Create(complete, message, url);
        }
    }
}
