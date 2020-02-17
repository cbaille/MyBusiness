using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyBusiness.Web.Views
{
    public abstract class MyBusinessViewComponent : AbpViewComponent
    {
        protected MyBusinessViewComponent()
        {
            LocalizationSourceName = MyBusinessConsts.LocalizationSourceName;
        }
    }
}
