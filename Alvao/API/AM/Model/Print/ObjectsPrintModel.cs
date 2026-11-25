namespace Alvao.API.AM.Model.Print;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html"/>
public class ObjectsPrintModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.AssetCodeType.html#fields"/>
    public enum AssetCodeType {
        QrCode = 1,
        Barcode = 2,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.AssetRelationship.html#fields"/>
    public enum AssetRelationship {
        AssetEntrustedForUse = 1,
        OtherEntrustedAsset = 2,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.CheckRequiredResult.html#fields"/>
    public enum CheckRequiredResult {
        AllPresent = 0,
        AllMissing = 1,
        SomeMissing = 2,
        AllDiscardedOrBinned = 3,
        SomeDiscardedOrBinned = 4,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.Flag.html#fields"/>
    public enum Flag {
        Notice = 1,
        History = 2,
        OwnProp = 4,
        InheritedProp = 8,
        Children = 16,
        OwnInfo = 32,
        InheritedInfo = 64,
        SpecialInfo = 128,
        ObjectNameInfo = 256,
        Responsibility = 512,
    }
    /// <summary>Enum representing print template root node type.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.PrintTemplateRootNodeType.html#fields"/>
    public enum PrintTemplateRootNodeType {
        None = 0,
        Report = 1,
        Device = 2,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.PrintTemplateType.html#fields"/>
    public enum PrintTemplateType {
        Null = 0,
        General = 1,
        TransferInner = 2,
        TransferInnerSummary = 3,
        TransferOuter = 4,
        ReturnInner = 5,
        AssetLabel = 6,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.TransferConfirmType.html#fields"/>
    public enum TransferConfirmType {
        Paper = 1,
        Web = 2,
        ElectronicPen = 4,
    }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_AssetLabelCodeTypeId"/>
    public byte? AssetLabelCodeTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_BarcodeSourcePropertyKindId"/>
    public int? BarcodeSourcePropertyKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_DocumentNumber"/>
    public string DocumentNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_FlagList"/>
    public List<ObjectsPrintModel.Flag> FlagList { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_HandingOverOrganization"/>
    public PrintTemplateTransferObject HandingOverOrganization { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_HandingOverUser"/>
    public PrintTemplateTransferObject HandingOverUser { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_IssueDate"/>
    public DateTime IssueDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_NodeIds"/>
    public string NodeIds { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_OriginalUser"/>
    public PrintTemplateTransferObject OriginalUser { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_OverwriteLabels"/>
    public bool OverwriteLabels { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_PersonId"/>
    public int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_PersonName"/>
    public string PersonName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_PrintReportTemplateId"/>
    public int PrintReportTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_PrintReportTemplateName"/>
    public string PrintReportTemplateName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_PrintReportTemplateType"/>
    public ObjectsPrintModel.PrintTemplateType PrintReportTemplateType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_RecipientOrganization"/>
    public PrintTemplateTransferObject RecipientOrganization { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_RecipientUser"/>
    public PrintTemplateTransferObject RecipientUser { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_Text"/>
    public string Text { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_TransferDate"/>
    public DateTime TransferDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_WithoutChildrenNodes"/>
    public bool WithoutChildrenNodes { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.ObjectsPrintModel.html#Alvao_API_AM_Model_Print_ObjectsPrintModel_GetData"/>
    public Dictionary<string, string> GetData() { throw new NotImplementedException(); }
}
