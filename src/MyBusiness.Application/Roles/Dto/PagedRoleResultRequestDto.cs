﻿using Abp.Application.Services.Dto;

namespace MyBusiness.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

