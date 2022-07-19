using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    internal class Database
    {
        private List<Record> records;

        public Database()
        {
            records = new List<Record>();
        }

        public void AddRecord(DateTime date, string name)
        {
            records.Add(new Record(date, name));
        }

        public Record? FindRecord(string name)
        {
            return records.Find(x => x.Name == name);
        }

        public List<Record?> FindRecordsByName(string name)
        {
            List<Record?> foundResults = new List<Record?>();
            foreach (var item in records)
            {
                if (item.Name == name)
                    foundResults.Add(item);
            }
            return foundResults;
        }

        public List<Record?> FindAllRecords()
        {
            return records;
        }

        public List<Record?> FindRecordsByDate(DateTime date, bool time)
        {
            List<Record?> foundResults = new List<Record?>();
            foreach (var item in records)
            {
                if (time && item.Date == date || item.Date.Date == date.Date)
                    foundResults.Add(item);
            }
            return foundResults;
        }

        public void DeleteRecord(string name)
        {
            Record? record = records.Find(x => x.Name == name);
            if (record is not null)
                records.Remove(record);
        }

        public void DeleteRecord(DateTime date)
        {
            Record? record = records.Find(x => x.Date == date);
            if (record is not null)
                records.Remove(record);
        }

        public void DeleteRecords(DateTime date)
        {
            List<Record?> foundRecords = FindRecordsByDate(date, true);
            foreach (var record in foundRecords)
            {
                foundRecords.Remove(record);
            }
            
        }
    }
}
