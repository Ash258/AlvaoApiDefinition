using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Registered webhooks integrating Alvao with other applications.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_Webhook.htm"/>
[TableAttribute("dbo.Webhook")]
public class Webhook
{
    /// <summary>Ticket field ID for wich the webhook should be invoked (tColumn.iColumnId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_ColumnId.htm"/>
    public virtual int? ColumnId { get; set; }
    /// <summary>Creation date</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_Created.htm"/>
    public virtual DateTime Created { get; set; }
    /// <summary>1 = the webhook is enabled, 0 = disabled.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_Enabled.htm"/>
    public virtual bool Enabled { get; set; }
    /// <summary>Error message at the last invocation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_ErrorMessage.htm"/>
    public virtual string ErrorMessage { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Last invocation date</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_LastInvoked.htm"/>
    public virtual DateTime? LastInvoked { get; set; }
    /// <summary>ID of the source object for whose subtree the webhook should be invoked (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_MovedFromNodeId.htm"/>
    public virtual int? MovedFromNodeId { get; set; }
    /// <summary>ID of the destination object for whose subtree the webhook should be invoked (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_MovedToNodeId.htm"/>
    public virtual int? MovedToNodeId { get; set; }
    /// <summary>Webhook name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_Name.htm"/>
    public virtual string Name { get; set; }
    /// <summary>Object kind in which the webhook should be invoked (tblClass.intClassId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_NodeClassId.htm"/>
    public virtual int? NodeClassId { get; set; }
    /// <summary>Object property kind in which the webhook should be invoked (tblKind.intKindId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_NodePropertyKindId.htm"/>
    public virtual int? NodePropertyKindId { get; set; }
    /// <summary>New object property value in which the webhook should be invoked.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_NodePropertyNewValue.htm"/>
    public virtual string NodePropertyNewValue { get; set; }
    /// <summary>ID of the parent object for whose subtree the webhook should be invoked (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_ParentNodeId.htm"/>
    public virtual int? ParentNodeId { get; set; }
    /// <summary>Ticket service for which the webhook should be invoked (tHdSection.iHdSectionId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_SectionId.htm"/>
    public virtual int? SectionId { get; set; }
    /// <summary>Ticket status in which the webhook should be invoked (TicketState.id).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_TicketStateId.htm"/>
    public virtual int? TicketStateId { get; set; }
    /// <summary>Ticket process for which the webhook should be invoked (TicketType.id).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_TicketTypeId.htm"/>
    public virtual int? TicketTypeId { get; set; }
    /// <summary>Webhook topic ID (WebhookTopic.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_TopicId.htm"/>
    public virtual int TopicId { get; set; }
    /// <summary>Webhook callback URL</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Webhook_Url.htm"/>
    public virtual string Url { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_Webhook__ctor.htm"/>
    public Webhook() { }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_Webhook_ToString.htm"/>
    public override string ToString() { throw new System.NotImplementedException(); }
}
