using System;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Xml;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Alvao.API.Common.Model.CustomApps;
using Alvao.Apps.API;
using Alvao.Context;
using Dapper;

public class ShowRequesterAddress : IEntityTab
{
    public string Id {get; set;}
    public Entity Entity {get; set;}

    public ShowRequesterAddress() 
    {
        Id = Settings.TabName.GetHashCode().ToString();
        Entity = Entity.Request;
    }

    public async Task<EntityTabShowResult> ShowAsync(EntityArgs e, CancellationToken cancellationToken)
    {        
        bool show = false;
        string name = Settings.TabName;
        string url = string.Empty;

        using (var scope = AlvaoContext.GetConnectionScope())
        {
            //Retrieving the required request data from the database.
            var ticketModel = scope.Connection.QueryFirstOrDefault<RequesterAddressTicketModel>(@"
                SELECT
                    ZAA.Street + ' ' + ZAA.City RequesterAddress,	
                    liHdTicketHdSectionId ServiceId,
                    TicketStateId StateId
                FROM 
                    tHdTicket HDT 
                    JOIN tPerson Z on Z.iPersonId = HDT.liHdTicketUserPersonId 
                    JOIN tAccount ZA ON Z.liAccountId = ZA.iAccountId 
                    JOIN tAddress ZAA ON ZAA.id = ZA.AddressId
                WHERE
                    HDT.iHdTicketId = @iHdTicketId", new { iHdTicketId = e.EntityId }
            );

            if (ticketModel == null){
                return new EntityTabShowResult (show, name, url);
            }

            // Check if the request is in the required service and status.
            if (ticketModel.ServiceId == Settings.ServiceId && ticketModel.StateId == Settings.StateId)
            {
                // The returned url displays the address of the requester on the map in its own tab.
                url = "http://frame.mapy.cz/zakladni?q=" + HttpUtility.UrlEncode(ticketModel.RequesterAddress);
                show = true;
            }
        } 

        return new EntityTabShowResult (show, name, url);
    }
}

public class RequesterAddressTicketModel {
    public int ServiceId {get; set;}
    public int StateId {get; set;}
    public string RequesterAddress {get; set;}
}
