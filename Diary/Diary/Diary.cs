using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    internal class Diary
    {
        private Database db;

        public Diary()
        {
            db = new Database();
        }

        public void ShowDiary()
        {
            Console.WriteLine("Welcome in your diary!");
            Console.WriteLine("Today's date is: {0}", DateTime.Today.ToShortDateString());
            Console.WriteLine("Current time is: {0}", DateTime.Now.ToShortTimeString());

            Console.WriteLine("Your plans for today are: ");
            ShowSpecificDay(DateTime.Today, false);
        }


        public DateTime GetDateAndTime()
        {
            Console.WriteLine("Please insert your date and time in this format [dd, mm, yyyy hh, mm]: ");
            DateTime date;
            while(! DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("This time is not valid!");
            }
            return date;
        }

        public string GetName()
        {
            Console.WriteLine("Name of your diary record: ");
            string name;
            while (string.IsNullOrWhiteSpace(name = Console.ReadLine()))
            {
                Console.WriteLine("Please insert your name of the event again.");
            }
            return name;
        }

        public void ShowAllRecords()
        {
            List<Record?> records = db.FindAllRecords();
            if (FoundRecords(records))
                PrintRecords(records);
        }

        public void ShowSpecificDay(DateTime date, bool time)
        {
            List<Record?> records = db.FindRecordsByDate(date, time);
            if (FoundRecords(records))
                PrintRecords(records);
        }

        private void PrintRecords(List<Record?> records)
        {
            Console.WriteLine("Records: ");
            foreach (var item in records)
            {
                Console.WriteLine("{0} {1}", item?.Date.ToShortDateString(), item?.Name);
            }
        }

        private bool FoundRecords(List<Record?> records)
        {
            if (records is null)
            {
                Console.WriteLine("There are no records in your diary yet.");
                return false;
            }
            return true;
        }

        public void AddRecord()
        {
            db.AddRecord(GetDateAndTime(), GetName());
        }

        public void DeleteRecord()
        {
            Console.WriteLine("Records from this day and time will be erased: ");
            DateTime time = GetDateAndTime();
            db.DeleteRecord(time);
        }

        public void FindRecord()
        {
            Record? record = db.FindRecord(GetName());
            Console.WriteLine(record?.Date + " " + record?.Name);
        }

        public void OptionsMenu()
        {
            Console.WriteLine("1 - Add Record");
            Console.WriteLine("2 - Find Record");
            Console.WriteLine("3 - Remove Record");
            Console.WriteLine("4 - Show All Records");
            Console.WriteLine("5 - Show Specific Day");
            Console.WriteLine("6 - End");
        }
    }
}
