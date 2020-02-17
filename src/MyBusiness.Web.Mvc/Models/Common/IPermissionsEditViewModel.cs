using System.Collections.Generic;
using MyBusiness.Roles.Dto;

namespace MyBusiness.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}