using System;
using System.IO;

namespace Log4NetExample {
  class MainClass {
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    public static void Main(string[] args) {
      log4net.Config.XmlConfigurator.Configure(new FileInfo("log4net.config"));
      log.Info("hi");
    }
  }
}
