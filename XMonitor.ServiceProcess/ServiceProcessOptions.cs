﻿using System;
using System.Collections.Generic;
using XMonitor.Core;

namespace XMonitor.ServiceProcess
{
    /// <summary>
    /// 表示服务进程监控的配置项
    /// </summary>
    public class ServiceProcessOptions : IMonitorOptions
    {
        /// <summary>
        /// 获取或设置日志工具
        /// </summary>
        public ILogger Logger { get; set; }

        /// <summary>
        /// 获取或设置检测的时间间隔
        /// 默认1分钟
        /// </summary>
        public TimeSpan Interval { get; set; } = TimeSpan.FromMinutes(1d);

        /// <summary>
        /// 获取通知通道列表
        /// </summary>
        public List<INotifyChannel> NotifyChannels { get; } = new List<INotifyChannel>();
    }
}
