using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LogDetail
    {
        public int MethodName { get; set; }
        public List<LogParameter> LogParameters { get; set; }
        public string ip { get; set; }
        public string userName { get; set; }
    }
}
