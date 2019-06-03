using System;
using Domain.Entity;

namespace Domain.Business
{
    public class PostActions
    {
        public void ViewPost()
        {

        }

        public void CreatePost(int id, string postedby, string content)
        {
            Post NewPost = new Post();

            NewPost.ID = id;
            NewPost.PostedBy = postedby;
            NewPost.Content = content;
            NewPost.DateCreated = DateTime.Now;
        }

        public void DeletePost()
        {

        }
    }
}
