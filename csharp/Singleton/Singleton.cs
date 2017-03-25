namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private Singleton() { }
        public static Singleton Instance => instance ?? (instance = new Singleton());

        public string Settings { get; set; }
    }

    class UsageOfSingleton
    {
        UsageOfSingleton()
        {
            Singleton.Instance.Settings = "demo";
        }
    }
}
