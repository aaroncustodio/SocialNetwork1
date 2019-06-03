using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    class Post : Entity
    {
        private string postedBy;
        private string content;

        public string PostedBy
        {
            get { return postedBy; }
            set { postedBy = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}
