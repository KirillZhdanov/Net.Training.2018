using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam
{
   public class Logger:ILogger
    {
        #region Field
        private string PathOfLogs;
        #endregion
        #region Constructor
        public Logger(string pathOfLogs)
        {
            if (!File.Exists(pathOfLogs))
            {
                File.Create(pathOfLogs);
            }

            PathOfLogs = pathOfLogs;

        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Log method
        /// </summary>
        /// <param name="logs"></param>
        public void Log(string logs)
        {
            using(var file= File.AppendText("log.txt"))
            {
                if (File.Exists("log.txt"))
                {
                    file.Write(logs);
                }
                else
                {
                    File.Create("log.txt");
                }
            }
        }
        #endregion
    }
}
