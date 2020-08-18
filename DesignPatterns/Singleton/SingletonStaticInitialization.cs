namespace DesignPatterns
{
    public class SingletonStaticInitialization
    {
        #region Constructors

        // Private constructor to restrict 
        // class creation from outside this class
        private SingletonStaticInitialization() { }

        #endregion
        
        #region Singleton Instance

        // Instance property with static initialization
        public static SingletonStaticInitialization Instance { get; } = new SingletonStaticInitialization();

        #endregion
    }
}
