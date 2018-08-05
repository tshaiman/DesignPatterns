using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public static class DbAccess_Bad
    {
        private static object _dbConnection = new object();
        public static void Connect()
        {
            Console.WriteLine("Connecting....");
        }
        public static bool IsConnected() => false;

        public static void Print()
        {
            Console.WriteLine("Data....");
        }
    }

    public class DbAccess_Singleton1
    {
        private readonly object _dbConnection;
        private static object _lock;
        private static DbAccess_Singleton1 _instace;

        public static DbAccess_Singleton1 Instance()
        {
            if (_instace == null)
            {
                lock (_lock)
                {
                    if(_instace == null)
                        _instace = new DbAccess_Singleton1();
                }
            }
            return _instace;
        }


        private DbAccess_Singleton1()
        {
            _dbConnection = new object();
            _lock = new object();
        }

        public void Connect()
        {
            Console.WriteLine("Connecting....");
        }
        public bool IsConnected() => false;

        public void Print()
        {
            Console.WriteLine("Data....");
        }
    }


    public class DbAccess_Singleton_Final
    {
        private readonly object _dbConnection;
        private static Lazy<DbAccess_Singleton_Final> _lazy = new Lazy<DbAccess_Singleton_Final>(() => new DbAccess_Singleton_Final());
        public static DbAccess_Singleton_Final Instance => _lazy.Value;

        private Lazy<string> _lazyCS = new Lazy<string>(() => {
            Console.WriteLine("Getting Connection Strring");
            return "abc";
            });
        private string CS;


        private DbAccess_Singleton_Final()
        {
            Console.WriteLine("In DbAccessSingletonFinal C'tor");
            CS = _lazyCS.Value;
        }

        public void Connect()
        {
            Console.WriteLine("Connecting to " + CS);
            var sss = _lazyCS.Value;
            
        }
        public bool IsConnected() => false;

        public void Print()
        {
            Console.WriteLine("Data....");
        }
    }
}
