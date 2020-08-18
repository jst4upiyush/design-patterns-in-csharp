namespace DesignPatterns
{
    public class SingletonStaticInitialization
    {
        #region Constructors

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonStaticInitialization() { }

        // Private constructor to restrict 
        // class creation from outside this class
        private SingletonStaticInitialization() { }

        #endregion
        
        #region Singleton Instance

        public static SingletonStaticInitialization Instance { get; } = new SingletonStaticInitialization();

        #endregion
    }
}
