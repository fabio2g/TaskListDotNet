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
        private string Description;

        public Task() { }

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

        public string setDescription(string description)
        {
            return Description = description;
        }

        public override string ToString()
        {
            return $"\n{{ Id: {Id}, Description: {Description} }}";
        }
    }
}
