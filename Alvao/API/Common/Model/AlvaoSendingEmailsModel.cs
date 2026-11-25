using System.Net.Mail;

namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AlvaoSendingEmailsModel.html"/>
public class AlvaoSendingEmailsModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AlvaoSendingEmailsModel.html#Alvao_API_Common_Model_AlvaoSendingEmailsModel_SendEmailMethodTypeId"/>
    public int SendEmailMethodTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AlvaoSendingEmailsModel.html#Alvao_API_Common_Model_AlvaoSendingEmailsModel_SmtpClient"/>
    public SmtpClient SmtpClient { get; set; }
}
