namespace DesignPatterns
{
    public class SingletonNestedStaticInitialization
    {
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonNestedStaticInitialization() { }

        // Private constructor to restrict 
        // class creation from outside this class
        private SingletonNestedStaticInitialization() { }

        // Instance property returning the statically initialized instance
        // from a nested child ensure Lazy Initialization
        public static SingletonNestedStaticInitialization Instance => Nested.Instance;

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested() { }

            // Nested Instance property with static initialization of parent
            internal static readonly SingletonNestedStaticInitialization Instance = new SingletonNestedStaticInitialization();
        }
    }
}
