using System;
using System.Data;
using Alvao.API.Common;
using Alvao.API.Common.Model.CustomApps;
using Alvao.Apps.API;
using Alvao.Context;
using Dapper;

public class ObjectKnowledgeBaseTab : IEntityTab
{
    public string Id { get; set; }
    public Entity Entity { get; set; }

    public ObjectKnowledgeBaseTab()
    {
        Id = "ObjectKnowledgeBase".GetHashCode().ToString();
        Entity = Entity.Object;
    }

    public EntityTabShowResult Show(int entityId, int personId)
    {
        bool show = false;
        string name = Localization.GetLocalization(personId, "TabName");
        string url = string.Empty;

        try
        {
            using (var scope = AlvaoContext.GetConnectionScope())
            {
                //Retrieving the required object data from the database.
                var objectModel = scope.Connection.QueryFirstOrDefault<ObjectKnowledgeBaseModel>(@"
                    select
                        [16] Manufacturer,
                        [96] Model
                    from (
                        select p.txtValue, k.intKindCode from tblProperty p
                        join tblKind k on k.intKindId = p.lintKindId and k.intKindCode in (16, 96)
                        where p.lintNodeId = @objectId
                    ) d
                    pivot
                    (
                        max(txtValue)
                        for intKindCode in ([16], [96])
                    ) piv;", new { objectId = entityId }
                );

                if (objectModel == null)
                {
                    return new EntityTabShowResult(show, name, url);
                };

                //Check if the object has filled properties.
                if (!string.IsNullOrEmpty(objectModel.Manufacturer) || !string.IsNullOrEmpty(objectModel.Model))
                {
                    string webAppUrl = DbProperty.WebAppUrl;
                    if (!string.IsNullOrEmpty(webAppUrl))
                    {
                        //Address of tab with articles from knowledge base
                        url = webAppUrl + "/KnowledgeBase?searchedText=" + objectModel.Manufacturer + " " + objectModel.Model;
                        show = true;
                    }
                }
            }
        }
        catch
        {
            return new EntityTabShowResult(show, name, url);
        }

        return new EntityTabShowResult(show, name, url);
    }
}

public class ObjectKnowledgeBaseModel
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
}

