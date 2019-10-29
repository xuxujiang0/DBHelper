using DBHelper.SQLHelper;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace DBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //不带分页，基本的查询
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic["Status"] = "ODR_CMPL";
            var list = SQLHelperFactory.Instance.QueryForList("OnlineOrder_GetAll", null);

            //分页，基本的查询
            dic.Clear();
            dic["Status"] = "ODR_CMPL";
            //dic["OrderNo"] = "348867688";
            dic["PickType"] = "'P','D'";
            dic["StartIndex"] = 0;
            dic["SelectCount"] = 10;
            var OnlineOrderListByPage = SQLHelperFactory.Instance.QueryMultipleByPage<OnlineOrder>("OnlineOrder_GetOrderList_By_Page", dic, out int total);
            Console.WriteLine(total);
            Console.Read();
        }

        public class OnlineOrder
        {
            public string member_id { set; get; }
            public string shop_txn_id { set; get; }
        }

    }
}

