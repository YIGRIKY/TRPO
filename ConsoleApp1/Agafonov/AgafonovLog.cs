using System;
using System.Collections.Generic;
using System.Text;

namespace AgafonovTheBest
{
    class AgafonovLog : LogAbstract, LogInterface
    {
        private List<string> myLogs = new List<string>();

        private static AgafonovLog instance;

        public static AgafonovLog I()
        {
            if (instance == null)
                instance = new AgafonovLog();

            return instance;
        }

        public LogInterface log(string str)
        {
            myLogs.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(myLogs.ToArray());
            return this;
        }
    }
}
