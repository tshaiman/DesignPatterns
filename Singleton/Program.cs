using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  var db = DbAccess_Singleton1.Instance();
            db.IsConnected();
            var db2 =DbAccess_Singleton1.Instance();

            Console.WriteLine(db == db2);*/



            DbAccess_Singleton_Final.Instance.Connect();
            DbAccess_Singleton_Final.Instance.Connect();
            DbAccess_Singleton_Final.Instance.Connect();
            DbAccess_Singleton_Final.Instance.Connect();
        }
    }
}
