using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace MyBusiness.Web.Views
{
    public abstract class MyBusinessRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyBusinessRazorPage()
        {
            LocalizationSourceName = MyBusinessConsts.LocalizationSourceName;
        }
    }
}
