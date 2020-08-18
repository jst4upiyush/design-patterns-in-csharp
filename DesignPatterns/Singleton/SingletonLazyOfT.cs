using System;

namespace DesignPatterns
{
    public class SingletonLazyOfT
    {
        // private field responsible for lazy initialization of Instance
        private static readonly Lazy<SingletonLazyOfT> _lazyInstance = new Lazy<SingletonLazyOfT>(() => new SingletonLazyOfT());

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonLazyOfT() { }

        // Private constructor to restrict 
        // class creation from outside this class
        private SingletonLazyOfT() { }

        // Instance property returning a lazyly initialized instance 
        // using .net framework provided `Lazy<T>`
        public static SingletonLazyOfT Instance => _lazyInstance.Value;
    }
}
