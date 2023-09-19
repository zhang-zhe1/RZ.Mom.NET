using RZ.Mom.NET.Core;

namespace RZ.Mom.NET.Core.Service;

public class JobOutput
{
    /// <summary>
    /// 作业信息
    /// </summary>
    public SysJobDetail JobDetail { get; set; }

    /// <summary>
    /// 触发器集合
    /// </summary>
    public List<SysJobTrigger> JobTriggers { get; set; }
}