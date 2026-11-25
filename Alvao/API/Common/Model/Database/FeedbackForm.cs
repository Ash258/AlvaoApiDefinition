using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Feedback form definitions</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html"/>
[Table("dbo.FeedbackForm")]
public class FeedbackForm {
    /// <summary>Text of form cancel button</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_CancelButtonText"/>
    /// <remarks>Column <c>CancelButtonText</c>: nvarchar(255), null.</remarks>
    public virtual string CancelButtonText { get; set; }
    /// <summary>Form description</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_Description"/>
    /// <remarks>Column <c>Description</c>: nvarchar(max), null.</remarks>
    public virtual string Description { get; set; }
    /// <summary>Feedback form fields</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_FieldsJson"/>
    /// <remarks>Column <c>FieldsJson</c>: nvarchar(max), null.</remarks>
    public virtual string FieldsJson { get; set; }
    /// <summary>Alvao version from which the form is shown</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_FromAlvaoVersion"/>
    /// <remarks>Column <c>FromAlvaoVersion</c>: nvarchar(50), null.</remarks>
    public virtual string FromAlvaoVersion { get; set; }
    /// <summary>Date from when the form is shown</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_FromDate"/>
    /// <remarks>Column <c>FromDate</c>: datetime, not null.</remarks>
    public virtual DateTime FromDate { get; set; }
    /// <summary>Form GUID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_Guid"/>
    /// <remarks>Column <c>Guid</c>: uniqueidentifier, not null.</remarks>
    [ExplicitKey]
    public virtual Guid Guid { get; set; }
    /// <summary>Modules combination needed to display the feedback form</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_RequiredModules"/>
    /// <remarks>Column <c>RequiredModules</c>: nvarchar(max), null.</remarks>
    public virtual string RequiredModules { get; set; }
    /// <summary>List of role behavior identifiers</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_RoleBehaviorIds"/>
    /// <remarks>Column <c>RoleBehaviorIds</c>: nvarchar(max), null.</remarks>
    public virtual string RoleBehaviorIds { get; set; }
    /// <summary>Feedback form is shown only for requester</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_ShowOnlyToRequester"/>
    /// <remarks>Column <c>ShowOnlyToRequester</c>: bit, not null.</remarks>
    public virtual bool ShowOnlyToRequester { get; set; }
    /// <summary>Feedback is shown only for solvers on at least one service</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_ShowToAllSolvers"/>
    /// <remarks>Column <c>ShowToAllSolvers</c>: bit, not null.</remarks>
    public virtual bool ShowToAllSolvers { get; set; }
    /// <summary>Text of form submit button</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_SubmitButtonText"/>
    /// <remarks>Column <c>SubmitButtonText</c>: nvarchar(255), null.</remarks>
    public virtual string SubmitButtonText { get; set; }
    /// <summary>Form title</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_Title"/>
    /// <remarks>Column <c>Title</c>: nvarchar(255), null.</remarks>
    public virtual string Title { get; set; }
    /// <summary>Date to which the form is shown</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_ToDate"/>
    /// <remarks>Column <c>ToDate</c>: datetime, not null.</remarks>
    public virtual DateTime ToDate { get; set; }
    /// <summary>Regex pattern for matching URL</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_UrlPattern"/>
    /// <remarks>Column <c>UrlPattern</c>: nvarchar(255), null.</remarks>
    public virtual string UrlPattern { get; set; }
}
