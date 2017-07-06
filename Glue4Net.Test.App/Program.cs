using Glue4Net.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Glue4Net.Console
{
    class Program
    {


        private static DomainContainer mContainer;
        private static void Main(string[] args)
        {
            Log4NetEventLogImpl log4NetEventLogImpl = new Log4NetEventLogImpl();
            log4NetEventLogImpl.Info("Glue4Net Console Copyright @ henryfan 2014 Version " + typeof(Program).Assembly.GetName().Version);
            log4NetEventLogImpl.Info("Website:http://www.ikende.com");
            log4NetEventLogImpl.Info("Email:henryfan@msn.com");
            mContainer = new DomainContainer();
            mContainer.Log = log4NetEventLogImpl;
            mContainer.LoadConfig("containerSection");
            mContainer.Open();
            Thread.Sleep(-1);
        }
    }

}
