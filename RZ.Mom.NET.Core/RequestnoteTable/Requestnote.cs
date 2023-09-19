// MIT License
//
// Copyright (c) 2021-present zuohuaijun, Daming Co.,Ltd and Contributors
//
// 电话/微信：18020030720 QQ群1：87333204 QQ群2：252381476

using NewLife.Data;
using RZ.Mom.NET.Core;
using SqlSugar;
using System.ComponentModel.DataAnnotations;

namespace RZ.Mom.NET.Core.RequestnoteTable;

/// <summary>
/// 申请单生成表
/// </summary>
[SugarTable(null, "申请单生成表")]
[SystemTable]
public class Requestnote
{
    /// <summary>
    /// 雪花Id
    /// </summary>
    [SugarColumn(ColumnDescription = "Id", IsPrimaryKey = true, IsIdentity = false)]
    public virtual long Id { get; set; }= new Snowflake.Core.IdWorker(1,1).NextId();
    /// <summary>
    /// 姓名
    /// </summary>
    [SugarColumn(ColumnDescription = "姓名", Length = 32)]
    [MaxLength(32)]
    public string RequestnoteName { get; set; }
    
}

