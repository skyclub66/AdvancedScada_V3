﻿using System;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace AdvancedScada.IBaseService
{
    public class BaseBinding
    {
        protected ushort PORT = 8086;

        protected string URI_S7DRIVER = "net.tcp://{0}:{1}/DriverService/{2}";

        protected string URI_SYS_SERVICE = "net.tcp://{0}:{1}/SystemService/{2}";

        protected string URI_TAG_MANAGER_SERVICE = "net.tcp://{0}:{1}/TagManagerService/{2}";

        protected string URI_IO_DEFINE_SERVICE = "net.tcp://{0}:{1}/IODefineService/{2}";

        protected string URI_IO_CONFIG_SERVICE = "net.tcp://{0}:{1}/IOConfigService/{2}";

        protected string URI_SQL_CONFIG_SERVICE = "net.tcp://{0}:{1}/SQLConfigService/{2}";

        protected string URI_SQL_INFO_SERVICE = "net.tcp://{0}:{1}/SQLInfoService/{2}";

        protected string COPY_RIGHT = "© Hao Thien Co.,Ltd Company. All Rights Reserved.";

        protected const string LOGGING = "Logging";

        protected const string COLLECTION_SERVICE = "CollectionService";

        protected const string S7DRIVER = "S7Driver";

        protected const string COLLECTION = "Collection";

        protected const string CHANNEL = "Channel";

        protected const string DEVICE = "Device";

        protected const string DATABLOCK = "DataBlock";

        protected const string TAG = "Tag";

        protected const string IO_DEFINE = "IODefine";

        protected const string IO_CONFIG = "IOConfig";

        protected const string SQL_SERVER = "SQLServer";

        protected const string SQL_DATABASE = "SQLDataBase";

        protected const string SQL_TABLE = "SQLTable";

        protected const string S7_LINK_TO_SQL = "S7LinkToSql";

        protected const string SQL_COLUMN_INFO = "SQLColumnInfo";

        protected const string SQL_DATABASE_INFO = "SQLDataBaseInfo";

        protected const string SQL_TABLE_INFO = "SQLTableInfo";

        protected const string GROUP_USER = "GroupUser";

        protected const string USER = "User";

        protected NetTcpBinding GetNetTcpBinding()
        {
            return new NetTcpBinding
            {
                ReceiveTimeout = TimeSpan.FromMinutes(2.0),
                SendTimeout = TimeSpan.FromMinutes(2.0),
                OpenTimeout = TimeSpan.FromDays(15.0),
                CloseTimeout = TimeSpan.FromDays(15.0),
                MaxReceivedMessageSize = 2147483647L
            };
        }

        protected BasicHttpBinding GetBasicHttpBinding()
        {
            return new BasicHttpBinding
            {
                ReceiveTimeout = TimeSpan.FromMinutes(2.0),
                SendTimeout = TimeSpan.FromMinutes(2.0),
                OpenTimeout = TimeSpan.FromDays(15.0),
                CloseTimeout = TimeSpan.FromDays(15.0),
                MaxReceivedMessageSize = 2147483647L
            };
        }

        protected WebHttpBinding GetWebHttpBinding()
        {
            return new WebHttpBinding
            {
                ReceiveTimeout = TimeSpan.FromMinutes(2.0),
                SendTimeout = TimeSpan.FromMinutes(2.0),
                OpenTimeout = TimeSpan.FromDays(15.0),
                CloseTimeout = TimeSpan.FromDays(15.0),
                MaxReceivedMessageSize = 2147483647L
            };
        }

        public ServiceThrottlingBehavior GetServiceThrottlingBehaviorByHost(ServiceHost host)
        {
            ServiceThrottlingBehavior serviceThrottlingBehavior = host.Description.Behaviors.Find<ServiceThrottlingBehavior>();
            if (serviceThrottlingBehavior == null)
            {
                serviceThrottlingBehavior = new ServiceThrottlingBehavior();
                serviceThrottlingBehavior.MaxConcurrentCalls = int.MaxValue;
                serviceThrottlingBehavior.MaxConcurrentSessions = int.MaxValue;
                serviceThrottlingBehavior.MaxConcurrentInstances = int.MaxValue;
                host.Description.Behaviors.Add(serviceThrottlingBehavior);
            }
            return serviceThrottlingBehavior;
        }
    }
}