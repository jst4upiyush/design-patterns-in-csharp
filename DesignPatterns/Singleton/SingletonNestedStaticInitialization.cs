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

        public static SingletonNestedStaticInitialization Instance => Nested.Instance;

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested() { }

            internal static readonly SingletonNestedStaticInitialization Instance = new SingletonNestedStaticInitialization();
        }
    }
}
