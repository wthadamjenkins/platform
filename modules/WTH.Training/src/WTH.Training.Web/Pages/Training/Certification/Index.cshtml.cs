using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Layout;
using WTH.Theme.Wetrainhub.Layout;
using WTH.Training.Web.Menus;

namespace WTH.Training.Web.Pages.Training.Certification;

public class IndexModel(IThemePageLayout themePageLayout) : TrainingPageModel
{
    public void OnGet()
    {
        themePageLayout.Content.SetMenu(TrainingMenus.Prefix,TrainingMenus.Awards);

        var breadcrumb = new List<BreadCrumbItem>()
        {
            new BreadCrumbItem("Training","/training"),
            new BreadCrumbItem("Certification")
        };
        themePageLayout.Content.SetTitleWithBreadCrumb("Awards",breadcrumb);
    }
}
