using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Imported CSV files</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html"/>
[Table("dbo.Import")]
public class Import {
    /// <summary>Number of new objects created</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_CreatedAmount"/>
    /// <remarks>Column <c>CreatedAmount</c>: int, not null.</remarks>
    public virtual int CreatedAmount { get; set; }
    /// <summary>ID of object (tblNode.intNodeId), which was created by import.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_CreatedObjectId"/>
    /// <remarks>Column <c>CreatedObjectId</c>: int, not null.</remarks>
    public virtual int CreatedObjectId { get; set; }
    /// <summary>1 if the file import end up with an error</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_Error"/>
    /// <remarks>Column <c>Error</c>: bit, not null.</remarks>
    public virtual bool Error { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>1 if the file import is finished</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_ImportFinished"/>
    /// <remarks>Column <c>ImportFinished</c>: bit, not null.</remarks>
    public virtual bool ImportFinished { get; set; }
    /// <summary>Last job created for Hangfire by this import</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_JobId"/>
    /// <remarks>Column <c>JobId</c>: bigint, null.</remarks>
    public virtual long? JobId { get; set; }
    /// <summary>User ID of a person (tPerson.iPersonId), who imported the file.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int PersonId { get; set; }
    /// <summary>Information printout from validation</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_Printout"/>
    /// <remarks>Column <c>Printout</c>: nvarchar(max), null.</remarks>
    public virtual string Printout { get; set; }
    /// <summary>Current progress</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_Progress"/>
    /// <remarks>Column <c>Progress</c>: int, not null.</remarks>
    public virtual int Progress { get; set; }
    /// <summary>Binary content of the file</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_Source"/>
    /// <remarks>Column <c>Source</c>: varbinary, null.</remarks>
    public virtual byte[] Source { get; set; }
    /// <summary>Date and time when the import started</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_StartedDate"/>
    /// <remarks>Column <c>StartedDate</c>: datetime, null.</remarks>
    public virtual DateTime? StartedDate { get; set; }
    /// <summary>Number of updated objects</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_UpdatedAmount"/>
    /// <remarks>Column <c>UpdatedAmount</c>: int, not null.</remarks>
    public virtual int UpdatedAmount { get; set; }
    /// <summary>1 if the file validation is finished</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Import.html#Alvao_API_Common_Model_Database_Import_ValidationFinished"/>
    /// <remarks>Column <c>ValidationFinished</c>: bit, not null.</remarks>
    public virtual bool ValidationFinished { get; set; }
}
