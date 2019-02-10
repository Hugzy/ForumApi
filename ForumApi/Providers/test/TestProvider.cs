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

        public void AddTestForums(ApiContext context)
        {
            var forum1 = new Forum.Models.Forum()
            {
                Id = Guid.NewGuid(),
                Title = "A title of a forum",
                Author = new SimpleUser()
                {
                    Id = Guid.NewGuid(),
                    Name = "Some forum author"
                }
            };

            context.Forums.Add(forum1);

            context.SaveChanges();

        }
        
        public void AddTestPosts(ApiContext context)
        {
            var post1 = new Post.Models.Post
            {
                Title = "a post",
                author = new SimpleUser()
                {
                    Id = Guid.NewGuid(),
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

            var post2 = new Post.Models.Post
            {
                Title = "b post",
                author = new SimpleUser()
                {
                    Id = Guid.NewGuid(),
                    Name = "Yet another author"
                },
                Content = new Content()
                {
                    Id = Guid.NewGuid(),
                    Characters = 1234,
                    Text = "the quick brown fox..."
                },
                Id = Guid.NewGuid(),
                thread = new Thread()
            };
            
            context.Posts.Add(post2);
            
            context.SaveChanges();
        }
        
    }
}