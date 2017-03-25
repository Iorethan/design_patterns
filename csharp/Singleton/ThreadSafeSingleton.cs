namespace DesignPatterns.Singleton
{
    public sealed class ThreadSafeSingleton
    {
        public static ThreadSafeSingleton Instance { get { return Nested.instance; } }
        private ThreadSafeSingleton() { }
        private class Nested
        {
            // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
            static Nested() { }
            internal static readonly ThreadSafeSingleton instance = new ThreadSafeSingleton();
        }

        public string Settings { get; set; }
    }

    class UsageOfThreadSafeSingleton
    {
        UsageOfThreadSafeSingleton()
        {
            ThreadSafeSingleton.Instance.Settings = "demo";
        }
    }
}
