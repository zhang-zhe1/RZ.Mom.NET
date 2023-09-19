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
using RZ.Mom.NET.Core.Material;
using MapsterMapper;
using RZ.Mom.NET.Core.RequestnoteTable;

namespace RZ.Mom.NET.Core.Service.Server;
public class MaterialShowService : IDynamicApiController, ITransient
{
    IMapper mapper;
    private readonly SqlSugarRepository<MaterialManager> _sqlSugarRepository;

    public MaterialShowService(IMapper mapper, SqlSugarRepository<MaterialManager> sqlSugarRepository)
    {
        this.mapper = mapper;
        _sqlSugarRepository = sqlSugarRepository;
    }
    [ApiDescriptionSettings(Name = "Show"), HttpGet]
    public dynamic GetMaterialManagerlist()
    {
        var list = _sqlSugarRepository.AsQueryable().ToList();
        var dto = mapper.Map<List<MaterialManager>, List<MaterialManager>>(list);
        return dto;
    }
}
