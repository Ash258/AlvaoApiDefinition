using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Language localization for selected database values. The following items are supported: tHdSection.sHdSectionShort, tHdSection.mHdSectionDesc.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tLocalization.htm"/>
[TableAttribute("dbo.tLocalization")]
public class tLocalization {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tLocalization_Column.htm"/>
    public enum Column {
        ColumnValueShort = 0,
        CustomMessageForApproverTemplate = 1,
        CustomNotificationForRequesterTemplate = 2,
        Description = 3,
        Keywords = 4,
        mDescription = 5,
        mHdSectionDesc = 6,
        mSubject = 7,
        mTextBody = 8,
        sHdSectionShort = 9,
        SolverInstructions = 10,
        sTitle = 11,
        TicketState = 12,
        TicketType = 13,
        Name = 14,
        TextHtml = 15,
    }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tLocalization_Table.htm"/>
    public enum Table {
        tColumn = 0,
        tColumnValue = 1,
        tEmailTemplate = 2,
        tHdSection = 3,
        TicketState = 4,
        TicketType = 5,
        NewTicketFormSection = 6,
        NewTicketFormTextBlock = 7,
    }
    /// <summary>LCID of the language for which the localization is being executed.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tLocalization_iLocaleId.htm"/>
    public virtual int iLocaleId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tLocalization_iLocalizationId.htm"/>
    [KeyAttribute]
    public virtual int iLocalizationId { get; set; }
    /// <summary>ID of record in target table designated for localization.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tLocalization_iRecordId.htm"/>
    public virtual int iRecordId { get; set; }
    /// <summary>Localized text.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tLocalization_mLocalization.htm"/>
    public virtual string mLocalization { get; set; }
    /// <summary>If there is 1, this translation needs to be updated because the original text has been modified since last translation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tLocalization_NeedsUpdate.htm"/>
    public virtual bool NeedsUpdate { get; set; }
    /// <summary>Column name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tLocalization_sAttribute.htm"/>
    public virtual string sAttribute { get; set; }
    /// <summary>Name of table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tLocalization_sTable.htm"/>
    public virtual string sTable { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tLocalization__ctor.htm"/>
    public tLocalization() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tLocalization__ctor_1.htm"/>
    public tLocalization(
        int localeId,
        int recordId,
        tLocalization.Table table,
        tLocalization.Column column,
        string translation
    ) { }
}
