﻿using MonitorServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStatusMonitor
{
    /// <summary>
    ///  ServiceCollection扩展
    /// </summary>
    public static class ServiceCollectionExtend
    {
        /// <summary>
        /// 使用服务状态监控服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options">配置选项</param>
        /// <returns></returns>
        public static ServiceCollection UseServiceStatusMonitor(this ServiceCollection services, Action<ServiceOptions> options)
        {
            var opt = new ServiceOptions();
            options?.Invoke(opt);

            var service = new ServiceStatusService(opt);
            services.Add(service);
            return services;
        }
    }
}
