namespace ForumApi.Providers.test
{
    public class TestProvider
    {
        private static TestProvider _instance = null;

        public static TestProvider getInstance()
        {
            if (_instance == null)
            {
                _instance = new TestProvider();
            }

            return _instance;
        }
    }
}