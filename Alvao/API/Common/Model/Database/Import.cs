using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Imported CSV files</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html"/>
[Table("dbo.Import")]
public class Import {
    /// <summary>Number of new objects created</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_CreatedAmount"/>
    public virtual int CreatedAmount { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_CreatedObjectId"/>
    public virtual int CreatedObjectId { get; set; }
    /// <summary>1 if the file import end up with an error</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_Error"/>
    public virtual bool Error { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_Id"/>
    public virtual int Id { get; set; }
    /// <summary>1 if the file import is finished</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_ImportFinished"/>
    public virtual bool ImportFinished { get; set; }
    /// <summary>Last job created for Hangfire by this import</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_JobId"/>
    public virtual long? JobId { get; set; }
    /// <summary>User ID of a person (tPerson.iPersonId), who imported the file.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Information printout from validation</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_Printout"/>
    public virtual string Printout { get; set; }
    /// <summary>Current progress</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_Progress"/>
    public virtual int Progress { get; set; }
    /// <summary>Binary content of the file</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_Source"/>
    public virtual byte[] Source { get; set; }
    /// <summary>Date and time when the import started</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_StartedDate"/>
    public virtual DateTime? StartedDate { get; set; }
    /// <summary>Number of updated objects</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_UpdatedAmount"/>
    public virtual int UpdatedAmount { get; set; }
    /// <summary>1 if the file validation is finished</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_ValidationFinished"/>
    public virtual bool ValidationFinished { get; set; }
}
