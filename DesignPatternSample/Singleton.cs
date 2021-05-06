using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample
{
    public sealed class Singleton
    {
        
        public Singleton(){
            Console.WriteLine("Creating instance ....");
        }
        #region Eager initialization
        //private static Singleton _instance = new Singleton();
        //public static Singleton getInstance() => _instance;
        #endregion
        #region Lazy initialization
        //private static Singleton _instance;
        //public static Singleton getInstance()
        //{
        //    if (_instance == null)
        //        _instance = new Singleton();
        //    return _instance;
        //}
        #endregion
        #region Thread Safe initialization
        //private static readonly object locks = new object();
        //private static Singleton _instance = null;
        //public static Singleton getInstance()
        //{
        //    lock (locks)
        //    {
        //        if (_instance == null)
        //            _instance = new Singleton();
        //        return _instance;
        //    }
        //}

        #endregion
        #region Doublecheck Locking initialization
        //private static readonly object locks = new object();
        //private static Singleton _instance = null;
        //public static Singleton getInstance()
        //{

        //    if (_instance == null)
        //    {
        //        lock (locks)
        //        {
        //            if (_instance == null)
        //                _instance = new Singleton();
        //        }
        //    }
        //    return _instance;
        //}
        #endregion
        #region Bill Pugh initialization
        public static Singleton getInstance() => SingletonHelper._instance;
        private static class SingletonHelper
        {
            public static Singleton _instance = new Singleton();
        }
        #endregion  
    }
}
