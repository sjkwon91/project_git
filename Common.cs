using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELKOJlogTranEmpOrg
{
    internal class Common
    {
        private Properties.Settings property = new Properties.Settings();

        public string ConnectionString
        {
            get { return @"server=KR-SSN-TRHRPRD;database=el_shop_intra;user id=elkointranet;password=Company1!;persist security info=False;packet size=4096"; } // RUN_TRD
            //get { return @"server=KR-SSN-TRHRTEST;database=el_shop_intra;user id=elkointranet;password=Company1!;persist security info=False;packet size=4096"; } // TEST_TRD
        }

        public string FolderPath
        {
            get { return property.FolderPath; }
        }

        public string EmpFileName
        {
            get { return property.EmpFileName; }
        }

        public string DeptFileName
        {
            get { return property.DeptFileName; }
        }

        public string FileExtensionName
        {
            get { return property.FileExtensionName; }
        }

        public string TodayDate
        {
            get { return DateTime.Now.ToString("yyyyMMdd"); }
        }

        public char FileSplitMark
        {
            get { return property.FileSplitMark; }
        }

        public string LogFolderPath
        {
            get { return property.LogFolderPath; }
        }

        public string LogFileMark
        {
            get { return property.LogFileMark; }
        }

        public string Success
        {
            get { return property.Success; }
        }

        public string Fail
        {
            get { return property.Fail; }
        }

        public string FilePath(string fileName)
        {
            return FolderPath + fileName + TodayDate + FileExtensionName;
        }

        public bool CheckFileExist(string fileName)
        {
            if (System.IO.File.Exists(FilePath(fileName)))
                return true;
            else
                return false;
        }

        public void WriteLogResult(string fileContent, string fileName)
        {
            string logResultFileName = fileName + TodayDate + LogFileMark + FileExtensionName;
            string logResultPath = LogFolderPath + logResultFileName;

            FileInfo fileInfo = new FileInfo(logResultPath);

            if (!fileInfo.Exists)
            {
                FileStream fileStream = fileInfo.Create();
                fileStream.Close();
            }

            fileContent = "[" + DateTime.Now.ToString() + "] " + fileContent + "\r\n";
            File.AppendAllText(logResultPath, fileContent);
        }
    }
}