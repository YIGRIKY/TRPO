using Lab.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AgafonovTheBest
{
    class AgafonovLog : LogAbstract, LogInterface
    {
        private List<string> myLogs = new List<string>();
        private string logsPath { get; set; }

        private Stream stream { get; set; }

        private static AgafonovLog instance;

        public static AgafonovLog I()
        {
            if (instance == null)
                instance = new AgafonovLog();

            return instance;
        }

        public LogInterface Log(string str)
        {
            myLogs.Add(str);
            return this;
        }
        
        public LogInterface Write()
        {
            StreamWriter writer = new StreamWriter(stream);
            foreach (string log in myLogs)
            {
                writer.WriteLine($"{ DateTime.Now.ToString()} : {log}");
            }
            writer.Flush();
            writer.Close();
            WriteConsole(myLogs.ToArray());
            return this;
        }

        public void CheckAndCreateFolder()
        {
            logsPath = @"../../../Log";
            if (!Directory.Exists(logsPath))
            {
                logsPath = Directory.CreateDirectory(logsPath).FullName;
            }
            stream = File.Create(logsPath + $"/{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}_{DateTime.Now.Hour}.{DateTime.Now.Minute}.{DateTime.Now.Second}.{DateTime.Now.Millisecond}.txt");
        }
    }
}
