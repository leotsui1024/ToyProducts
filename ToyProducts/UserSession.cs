using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyProducts
{
    /// <summary>
    /// 靜態類別，用於儲存跨表單的登入資訊與資料庫路徑
    /// </summary>
    public static class UserSession
    {
        public static string StaffName { get; set; }
        public static string StaffID { get; set; }
        public static string DbPath { get; set; }
    }
}

