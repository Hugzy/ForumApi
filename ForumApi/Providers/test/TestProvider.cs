using System;
using ForumApi.Api.Context;
using ForumApi.Models;

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

        public void AddTestData(ApiContext context)
        {
            var post1 = new Post
            {
                Title = "a post",
                author = new SimpleUser()
                {
                    Name = "A User"
                },
                Content = new Content()
                {
                    Text = "some text",
                    Characters = 9
                },
                Id = Guid.NewGuid(),
                thread = new Thread()
            };

            context.Posts.Add(post1);

            context.SaveChanges();
        }
        
    }
}