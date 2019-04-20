﻿using Azylee.YeahWeb.SocketUtils.TcpUtils;
using BigBird.Models.ProjectModels;
using BigBird.Models.SystemModels;
using System.Collections.Generic;

namespace BigBirdWebCenter.Commons
{
    public static partial class R
    {
        public static class Tx
        {
            internal static int TcppPort = 52840;
            internal static TcppServer TcppServer = null;
            internal static List<string> Hosts = new List<string>();
            internal static string ConnectKey = "BigBird.WebCenter.201904192142.tcpp";//Tcp通信连接认证密钥
            internal static List<ProjectStatusModel> ProjectStatusList = new List<ProjectStatusModel>();
            internal static List<SystemStatusModel> SystemStatusList = new List<SystemStatusModel>();

            internal static short ReadQueueInterval = 1;
        }
    }
}
