using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    internal class Record
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Record() { }

        public Record(DateTime date, string name)
        {
            Date = date;
            Name = name;
        }

        public Record(DateTime date, string name, string description) : this(date, name)
        {
            Description = description;
        }

        public override string ToString()
        {
            return Date.ToShortDateString() + " " + Name;
        }
    }
}
