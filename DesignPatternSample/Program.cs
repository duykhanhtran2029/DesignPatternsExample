using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using DesignPatternSample.Facade;
using DesignPatternSample.Strategy;

namespace DesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
           // SingletonExample1();
           // SingletonExample2();

            //FacadeExample();
            StrategyExample();
            Console.ReadLine();
        }
        #region Singleton Example
        private static void SingletonExample1()
        {
            Singleton singleton1 = Singleton.getInstance();
            Singleton singleton2 = Singleton.getInstance();
            Console.WriteLine(singleton1.GetHashCode().ToString());
            Console.WriteLine(singleton2.GetHashCode().ToString());
        }
        private static void SingletonExample2()
        {
            Thread t1 = new Thread(() =>
            {
                Singleton singleton = Singleton.getInstance();
                Console.WriteLine(singleton.GetHashCode().ToString());
            });
            Thread t2 = new Thread(() =>
            {
                Singleton singleton = Singleton.getInstance();
                Console.WriteLine(singleton.GetHashCode().ToString());
            });
            t1.Start();
            t2.Start();
        }
        private static void SingletonExample3(string[] args)
        {
            Singleton singleton1 = Singleton.getInstance();
            Singleton singleton2 = null;
            try
            {
                singleton2 = (Singleton)Activator.CreateInstance(typeof(Singleton), args);
            }
            catch (Exception e)
            {
                throw e;
            }
            singleton2 = Singleton.getInstance();
            Console.WriteLine(singleton1.GetHashCode().ToString());
            Console.WriteLine(singleton2.GetHashCode().ToString());
        }
        #endregion
        #region Facade Example
        private static void FacadeExample()
        {
            ShopFacade.getInstance().buyProductByCashWithFreeShipping("18520075@uit.com");
            ShopFacade.getInstance().buyProductByPaypalWithStandardShipping("18520075@gmail.com", "0988.999.999");
        }
        #endregion
        #region Strategy Example
        private static void StrategyExample()
        {
            SortedList sortedList = new SortedList();
            sortedList.add("Design Pattern");
            sortedList.add("Singleton");
            sortedList.add("Facade");
            sortedList.add("Strategy");

            sortedList.setSortStrategy(new QuickSort());
            sortedList.sort();

            sortedList.setSortStrategy(new SelectionSort());
            sortedList.sort();
        }
        #endregion
    }
}
