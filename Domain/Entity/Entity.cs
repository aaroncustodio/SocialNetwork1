using System;

namespace Domain.Entity
{
    public class Entity
    {
        private int id;
        private DateTime dateCreated;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

    }
}
