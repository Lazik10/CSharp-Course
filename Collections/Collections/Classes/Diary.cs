using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal class Diary
    {
        private LinkedList<Note> _list;

        private Note _currentNote;

        public Diary()
        {
            _list = new LinkedList<Note>();
        }

        public void Intro()
        {
            Menu();
            SelectAction();
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Deník se ovládá nasledujícími příkazy: ");
            Console.WriteLine("- predchozi: Přesunutí na předchozí záznam");
            Console.WriteLine("- dalsi: Přesunutí na další záznam");
            Console.WriteLine("- novy: Vytvoření nového záznamu");
            Console.WriteLine("- uloz: Uložení vytvořeného záznamu");
            Console.WriteLine("- smaz: Odstranění záznamu");
            Console.WriteLine("- zavri: Zavření deníku");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Počet záznamů: {0}", _list.Count);

            if (_list.Count > 0)
            {
                Console.WriteLine(_currentNote);
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------");
            }
        }

        public void CreateNote()
        {
            Menu();
            Console.WriteLine();

            // Set Datum
            Console.Write("Datum: ");
            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Zadejte spravne format datumu!");
            }
            Console.WriteLine();
            // Set multiline text
            Console.WriteLine("Text: ");
            string input, text = "";
            while ((input = Console.ReadLine()) != "uloz")
                text += input;

            // Create and add note
            SaveNote(date, text);
        }

        public void SaveNote(DateTime date, string text)
        {
            Note note = new Note(date, text);
            _list.AddLast(note);
            _currentNote = note;
        }

        public Note PreviousNote(Note note)
        {
            LinkedListNode<Note>? node = _list.Find(note);
            node = node?.Previous;
            if (node is null)
            {
                Console.WriteLine("Další záznam už neexistuje");
                return note;
            }
            return node.Value;
        }

        public Note NextNote(Note note)
        {
            LinkedListNode<Note>? node = _list.Find(note);
            node = node?.Next;
            if (node is null)
            {
                Console.WriteLine("Další záznam už neexistuje");
                return note;
            }
            return node.Value;
        }

        public bool DeleteNote(Note note)
        {
            if (_list.Count == 0)
                return false;

            Menu();
            Console.WriteLine();
            Console.WriteLine("Pro odstranění tohoto záznamu stiskni \"a\", pro zrusešení jiný znak.");
            if (Console.ReadKey().KeyChar == 'a')
            {
                LinkedListNode<Note>? node = _list.Find(note);
                if (node is null)
                    return false;

                _currentNote = new Note(new DateTime(0), "default");

                if (node.Previous is not null)
                    _currentNote = node.Previous.Value;
                else if (node.Next is not null)
                    _currentNote = node.Next.Value;

                _list.Remove(note);
                return true;
            }
            return false;
        }

        public void SelectAction()
        {
            bool end = false;
            Console.WriteLine("Zadej příkaz: ");
            string action = Console.ReadLine();
            switch (action)
            {
                case "predchozi":
                    _currentNote = PreviousNote(_currentNote);
                    break;
                case "dalsi":
                    _currentNote = NextNote(_currentNote);
                    break;
                case "novy":
                    CreateNote();
                    break;
                case "smaz":
                    DeleteNote(_currentNote);
                    break;
                case "zavri":
                    end = true;
                    break;
                default:
                    Console.WriteLine("Neznama akce");
                    break;
            }

            if (end)
                return;

            Menu();
            SelectAction();
        }
    }

    internal class Note
    {
        public string Text { get; private set; }

        public DateTime Date { get; private set; }

        public Note(DateTime date, string text)
        {
            Date = date;
            Text = text;
        }

        public override string ToString()
        {
            return Date.ToShortDateString() + "\n\n" + Text;
        }
    }
}
