﻿using System.Threading.Tasks;

namespace XMonitor.Core
{
    /// <summary>
    /// 定义异常通知通道
    /// </summary>
    public interface INotifyChannel
    {
        /// <summary>
        /// 异常通知
        /// </summary>
        /// <param name="context">通知上下文</param>
        /// <returns></returns>
        Task NotifyAsync(NotifyContext context);
    }
}
