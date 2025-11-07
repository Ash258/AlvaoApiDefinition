namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.NewObjectType.html"/>
public enum NewObjectType {
    DuplicateExisting = 2,
    FromInvoice = 4,
    FromTemplate = 1,
    ImportCSV = 3,
    LoadScan = 5,
}
