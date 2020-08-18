using System;

namespace DesignPatterns
{
    public class SingletonLazyOfT
    {
        private static readonly Lazy<SingletonLazyOfT> _lazyInstance = new Lazy<SingletonLazyOfT>(() => new SingletonLazyOfT());

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonLazyOfT() { }

        // Private constructor to restrict 
        // class creation from outside this class
        private SingletonLazyOfT() { }

        public static SingletonLazyOfT Instance => _lazyInstance.Value;
    }
}
