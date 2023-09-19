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

namespace RZ.Mom.NET.Core.Order;

/// <summary>
///订单表
/// </summary>
[SugarTable(null, "订单生成表")]
[SystemTable]
public class OrderManger
{
    /// <summary>
    /// 雪花Id
    /// </summary>
    [SugarColumn(ColumnDescription = "订单编号Id", IsPrimaryKey = true, IsIdentity = false)]
    public virtual long OrderId { get; set; } = new Snowflake.Core.IdWorker(1, 1).NextId();
    /// <summary>
    /// 行号
    /// </summary>
    [SugarColumn(ColumnDescription = "行号")]
    [MaxLength(32)]

    public int LineNumber { get; set; }
    /// <summary>
    /// 供应商代码
    /// </summary>
    [SugarColumn(ColumnDescription = "供应商代码")]

    public string SupplierCode { get; set; }
    /// <summary>
    /// 供应商名称
    /// </summary>

    [SugarColumn(ColumnDescription = "供应商名称")]

    public string SupplierName { get; set; }
    /// <summary>
    /// 单据日期
    /// </summary>

    [SugarColumn(ColumnDescription = "单据日期")]

    public DateTime DocumentsDate { get; set; }

    [SugarColumn(ColumnDescription = "申请人")]

    public string Applicant { get; set; }

    [SugarColumn(ColumnDescription = "申请部门")]

    public string ApplicationDepartment { get; set; }

    [SugarColumn(ColumnDescription = "销售订单")]

    public string SalesOrder  { get; set; }

    [SugarColumn(ColumnDescription = "生产工单")]

    public string WorkOrder { get; set; }

    [SugarColumn(ColumnDescription = "产品代码")]

    public string ProductCode { get; set; }

    [SugarColumn(ColumnDescription = "产品名称")]

    public string ProductName { get; set; }


    [SugarColumn(ColumnDescription = "单位")]

    public string Unit{ get; set; }


    [SugarColumn(ColumnDescription = "数量")]

    public int  Quantity { get; set; }


    [SugarColumn(ColumnDescription = "工序")]

    public string Process{ get; set; }


    [SugarColumn(ColumnDescription = "单价")]

    public decimal UnitPrice  { get; set; }

    [SugarColumn(ColumnDescription = "金额")]

    public decimal Amount { get; set; }

    [SugarColumn(ColumnDescription = "单据状态")]

    public string DocumentStatus { get; set; }

    [SugarColumn(ColumnDescription = "制单人")]

    public string DocumentMaker { get; set; }

    [SugarColumn(ColumnDescription = "制单日期")]

    public DateTime DocumentationDate { get; set; }


    [SugarColumn(ColumnDescription = "删除状态")]

    public bool DeleteState { get; set; }




}

