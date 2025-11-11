using System.Linq;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Alvao.API.Common;

// Copy this script 1:1 into your application.
public class Localization 
{
    public static List<LocalizationItem> Localizations {get {
       /* Init Localizations list with your values .
        It takes: 
         - LCID https://www.science.co.il/language/Locale-codes.php 
         - string name
         - actual translation 
        */
        return new List<LocalizationItem>() {
            new LocalizationItem(1029, "CommandName", "Přeložený název příkazu"),
            new LocalizationItem(1033, "CommandName", "Translated command name"),
            new LocalizationItem(1031, "CommandName", "Übersetzter Befehlsname"),
            new LocalizationItem(1045, "CommandName", "Przetłumaczona nazwa polecenia"),
        };
    } }

    public static string GetLocalization(int personId, string name)
    {
        var localeId = GetPersonLocaleId(personId);
        var translation = FindInList(localeId, name);
        if (string.IsNullOrEmpty(translation))
        {
            localeId = GetDefaultLocaleId();
            translation = FindInList(localeId, name);
            if (string.IsNullOrEmpty(translation))
            {
                localeId = Locale.GetDatabaseLocaleId();
                translation = FindInList(localeId, name); 
            }
        }
        return translation;
    }

    private static string FindInList(int localeId, string name)
    {
        return Localizations.FirstOrDefault(x=>x.LocaleId == localeId && x.Name == name)?.Translation;
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
    public int LocaleId {get; set;}
    public string Name {get; set;}
    public string Translation {get; set;}

    public  LocalizationItem(int localeId, string name, string translation)
    {
        this.LocaleId = localeId;
        this.Name = name;
        this.Translation = translation;
    }
}
