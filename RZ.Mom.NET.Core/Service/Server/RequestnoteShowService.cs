// MIT License
//
// Copyright (c) 2021-present zuohuaijun, Daming Co.,Ltd and Contributors
//
// 电话/微信：18020030720 QQ群1：87333204 QQ群2：252381476

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RZ.Mom.NET.Core;
using SqlSugar;
using Furion.DynamicApiController;
using Furion.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Flurl;
using Flurl.Http;
using RZ.Mom.NET.Core.RequestnoteTable;
using MapsterMapper;

namespace RZ.Mom.NET.Core.Service;

public class RequestnoteShowService : IDynamicApiController, ITransient
{
    IMapper mapper;
    private readonly SqlSugarRepository<Requestnote> _sysUserRoleRep;

    public RequestnoteShowService(SqlSugarRepository<Requestnote> sysUserRoleRep, IMapper mapper)
    {
        _sysUserRoleRep = sysUserRoleRep;
        this.mapper = mapper;
    }

    [ApiDescriptionSettings(Name = "Show"), HttpGet]
    public dynamic GetRequestnotelist()
    {
        var list = _sysUserRoleRep.AsQueryable().ToList();
        var dto = mapper.Map<List<Requestnote>, List<Requestnote>>(list);
        return dto;
    }
}
