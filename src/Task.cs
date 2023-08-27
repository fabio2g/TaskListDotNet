using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Task
    {
        private int Id;
        private string Title;
        private string Description;
        private DateTime Timestamp;

        public Task() 
        {
            Timestamp = DateTime.Now;
        }

        public Task(int id, string description)
        {
            this.Id = id;
            this.Description = description;
        }

        public void setId(int id)
        {
            this.Id = id;
        }

        public int getId()
        {
            return this.Id;
        }

        public string getTitle()
        {
            return this.Title;
        }

        public void setTitle(string title)
        {
            this.Title = title;
        }

        public string setDescription(string description)
        {
            return Description = description;
        }

        public override string ToString()
        {
            return $"\n{{ id: {Id}, description: {Description}, timestamp: {Timestamp} }}";
        }
    }
}
