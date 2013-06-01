
namespace Tw.Com.Iisi.LogAnalysis
{
    class Constants
    {


        //Regular
        //public string SESSION_START_KEY = "--Start--";//交易開始
        public static string REG_SESSION_END_KEY = "--End--";//交易結束
        public static string REG_GET_SID = "WebContainer : \\d+";   //取得唯一值
        //public static string REG_GET_WKSID = "(?<=wId=)[\\w.]+";
        //public static string REG_GET_USERID = "(?<=uId=)[\\w.]+";
        public static string REG_GET_SERVER_COST = "(?<=srvCost=)[\\d]+";
        //public static string REG_GET_OPNAME = "(?<=opName=)[\\w.]+";
        public static string REG_GET_INPUT = "(?<=input=)[\\w.]+";
        public static string REG_GET_HOST_COST = "(?<=hostCost=)[\\w.]+";
        public static string REG_GET_OP_NAME = "(?<=opName=)[\\w.]+";
        public static string REGEX = "(?<time>(?<= )[0-9:,]+).*(?<sid>WebContainer : \\d+).*(?<srvCost>(?<=srvCost=)[\\-\\d]+).*(?<opName>(?<=opName=)\\w+).*(?<input>(?<=input=)(\\w+|\\t| ))(.*(?<hostCost>(?<=hostCost=)\\d+)|.*--End--)";

        //Static String

        public static string LINE_NOTATION = "\n";
        public static string COLON_NOTATION = " : ";
        private static string _logFile_Path = "";
        public static string LOG_FILE_PATH
        {
            set { _logFile_Path = value; }
            get { return _logFile_Path; }

        }
    }
}
