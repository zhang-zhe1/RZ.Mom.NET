// MIT License
//
// Copyright (c) 2021-present zuohuaijun, Daming Co.,Ltd and Contributors
//
// 电话/微信：18020030720 QQ群1：87333204 QQ群2：252381476

using NewLife.Data;
using RZ.Mom.NET.Core;
using SqlSugar;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RZ.Mom.NET.Core.Material;

/// <summary>
///物科表
/// </summary>
[SugarTable(null, "申请单生成表")]
[SystemTable]
public class MaterialManager
{
    /// <summary>
    /// 雪花Id
    /// </summary>
    [SugarColumn(ColumnDescription = "物科编号Id", IsPrimaryKey = true, IsIdentity = false)]
    public virtual long MaterialId { get; set; } = new Snowflake.Core.IdWorker(1, 1).NextId();
    /// <summary>
    /// 物科名称
    /// </summary>
    [SugarColumn(ColumnDescription = "物科名称", Length = 32)]
    [MaxLength(32)]
    
    public string MaterialName { get; set; }
    /// <summary>
    /// 物科开始时间
    /// </summary>
    [SugarColumn(ColumnDescription = "物科开始时间")]
    
    public DateTime StartTime { get; set; }
    /// <summary>
    /// 物科结束时间
    /// </summary>

    [SugarColumn(ColumnDescription = "物科结束时间")]

    public DateTime EndTime { get; set; }
    /// <summary>
    /// 删除状态
    /// </summary>

    [SugarColumn(ColumnDescription = "删除状态")]

    public bool DeleteState { get; set; }



}

