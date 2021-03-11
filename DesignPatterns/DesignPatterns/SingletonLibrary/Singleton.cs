using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonLibrary
{
    /// <summary>
    /// Singleton is a creational design pattern that lets you ensure that a class has only one instance,
    /// while providing a global access point. The Singleton pattern solves two problems at the same time,
    /// violating the Single Responsibility Principle:
    /// 1. Ensure that a class has just a single instance.
    /// 2. Provide a global access point to that instance.
    /// This design pattern is usefull, when a class in your program should have only one instance (e.g.
    /// database or file object).
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// This field contains created instance of singleton.
        /// </summary>
        private static Singleton _instance { get; set; }
        private Singleton() { }

        /// <summary>
        /// This is global acces point for getting that single instance.
        /// Instance is created at first call to this enpoint.
        /// </summary>
        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
