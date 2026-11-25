using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Feedback form definitions</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html"/>
[Table("dbo.FeedbackForm")]
public class FeedbackForm {
    /// <summary>Text of form cancel button</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_CancelButtonText"/>
    public virtual string CancelButtonText { get; set; }
    /// <summary>Form description</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_Description"/>
    public virtual string Description { get; set; }
    /// <summary>Feedback form fields</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_FieldsJson"/>
    public virtual string FieldsJson { get; set; }
    /// <summary>Alvao version from which the form is shown</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_FromAlvaoVersion"/>
    public virtual string FromAlvaoVersion { get; set; }
    /// <summary>Date from when the form is shown</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_FromDate"/>
    public virtual DateTime FromDate { get; set; }
    /// <summary>Form GUID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_Guid"/>
    [ExplicitKey]
    public virtual Guid Guid { get; set; }
    /// <summary>Modules combination needed to display the feedback form</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_RequiredModules"/>
    public virtual string RequiredModules { get; set; }
    /// <summary>List of role behavior identifiers</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_RoleBehaviorIds"/>
    public virtual string RoleBehaviorIds { get; set; }
    /// <summary>Feedback form is shown only for requester</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_ShowOnlyToRequester"/>
    public virtual bool ShowOnlyToRequester { get; set; }
    /// <summary>Feedback is shown only for solvers on at least one service</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_ShowToAllSolvers"/>
    public virtual bool ShowToAllSolvers { get; set; }
    /// <summary>Text of form submit button</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_SubmitButtonText"/>
    public virtual string SubmitButtonText { get; set; }
    /// <summary>Form title</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_Title"/>
    public virtual string Title { get; set; }
    /// <summary>Date to which the form is shown</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_ToDate"/>
    public virtual DateTime ToDate { get; set; }
    /// <summary>Regex pattern for matching URL</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackForm.html#Alvao_API_Common_Model_Database_FeedbackForm_UrlPattern"/>
    public virtual string UrlPattern { get; set; }
}
