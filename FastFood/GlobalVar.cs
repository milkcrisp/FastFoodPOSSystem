using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    internal class GlobalVar
    {
        public static string image_dir = @"C:\Users\a1382\Documents\Training\Code\Topic\FastFood\Img";
        public static string strDBConnectionString = "";
        public static bool isLogin = false;
        public static string username = "";
        public static int userid = 0;
        public static int empid = 0;
        public static int userlimit = 0;//使用者權限
        public static int userrole = 0; //會員:2 員工:1
        public static string userphone = "";
        public static string OrderphoneInfo = "";
        public static bool isTakeaway = false;
        public static bool isBag = false;
        public static int ordercleck = 0; //點餐機: 0 員工: eid
        public static string CurrentMode;
    }
}
