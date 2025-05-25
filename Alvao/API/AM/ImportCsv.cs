using Alvao.API.AM.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <summary>Facade class grouping import CSV methods</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ImportCsv.html"/>
public static class ImportCsv {
    /// <summary>Returns import columns info.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ImportCsv.html#Alvao_API_AM_ImportCsv_GetImportColumnsInfo_Alvao_API_AM_Model_ImportCsvSettings_"/>
    /// <param name="settings">Multiple settings of import</param>
    /// <exception cref="ArgumentNullException">Throws when settings is null.</exception>
    /// <returns>Columns of import file.</returns>
    public static CsvImportFileColumnsModel GetImportColumnsInfo(ImportCsvSettings settings) { throw new System.NotImplementedException(); }
    /// <summary>Run import of CSV file.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ImportCsv.html#Alvao_API_AM_ImportCsv_Run_Alvao_API_AM_Model_ImportCsvSettings_"/>
    /// <param name="settings">Multiple settings of import</param>
    /// <exception cref="ArgumentNullException">Throws when settings is null.</exception>
    /// <exception cref="ArgumentException">Throws when data in CSV file are not valid.</exception>
    /// <returns>True if import CSV was succesfull, otherwise False.</returns>
    public static bool Run(ImportCsvSettings settings) { throw new System.NotImplementedException(); }
    /// <summary>Run import of CSV file. RunImportCsv is deprecated, please use Run instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ImportCsv.html#Alvao_API_AM_ImportCsv_RunImportCsv_Alvao_API_AM_Model_ImportCsvSettings_"/>
    /// <param name="settings">Multiple settings of import</param>
    /// <exception cref="ArgumentNullException">Throws when settings is null.</exception>
    /// <exception cref="ArgumentException">Throws when data in CSV file are not valid.</exception>
    /// <returns>True if import CSV was succesfull, otherwise False.</returns>
    [Obsolete("RunImportCsv is deprecated, please use Run instead.")]
    public static bool RunImportCsv(ImportCsvSettings settings) { throw new System.NotImplementedException(); }
}
