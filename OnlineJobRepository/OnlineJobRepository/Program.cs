using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobRepository
{
    class Job
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        static void Main(string[] args)
        {
        }
    }
}
