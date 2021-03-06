﻿namespace DesignPatterns
{
    public class SingletonLazy
    {
        private static SingletonLazy _instance;
        private static readonly object _lock = new object();

        // Private constructor to restrict 
        // class creation from outside this class
        private SingletonLazy() { }

        // Instance property returning a lazyly initialized instance
        // using double null check and lock
        public static SingletonLazy Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonLazy();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
