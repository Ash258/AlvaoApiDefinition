using System.Linq;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Alvao.API.Common;

public class Localization
{
    public static List<LocalizationItem> Localizations
    {
        get
        {
            return new List<LocalizationItem>() {
            new LocalizationItem(1029, "CommandName", "Podpora výrobce"),
            new LocalizationItem(1031, "CommandName", "Herstellerunterstützung"),
            new LocalizationItem(1033, "CommandName", "Manufacturer support"),
            new LocalizationItem(1045, "CommandName", "Wsparcie producenta"),
            new LocalizationItem(1051, "CommandName", "Podpora výrobcu")
        };
        }
    }

    public static string GetLocalization(int personId, string name)
    {
        var localeId = GetPersonLocaleId(personId);
        var translation = FindInList(localeId, name);
        if (string.IsNullOrEmpty(translation))
        {
            localeId = GetDefaultLocaleId();
            translation = FindInList(localeId, name);
        }
        return translation;
    }

    private static string FindInList(int localeId, string name)
    {
        return Localizations.FirstOrDefault(x => x.LocaleId == localeId && x.Name == name)?.Translation;
    }

    private static int GetDefaultLocaleId()
    {
        var locale = Person.GetCultureInfoOrDefault(new Alvao.API.Common.Model.Database.tPerson()).LCID;
        return locale;
    }

    private static int GetPersonLocaleId(int personId)
    {
        var locale = Person.GetById(personId).iPersonLocaleId;
        if (!locale.HasValue)
        {
            return GetDefaultLocaleId();
        }
        return locale.Value;
    }
}

public class LocalizationItem
{
    public int LocaleId { get; set; }
    public string Name { get; set; }
    public string Translation { get; set; }

    public LocalizationItem(int localeId, string name, string translation)
    {
        this.LocaleId = localeId;
        this.Name = name;
        this.Translation = translation;
    }
}
