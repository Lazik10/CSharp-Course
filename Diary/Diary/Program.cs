Diary.Diary diary = new Diary.Diary();
diary.ShowDiary();
char choice = '0';

while (choice != '6')
{
    diary.OptionsMenu();

    Console.Write("Choose your option: ");
    Console.WriteLine();
    while (!char.TryParse(Console.ReadLine(), out choice)) ;

    switch (choice)
    {
        case '1':
            diary.AddRecord();
            break;
        case '2':
            diary.FindRecord();
            break;
        case '3':
            diary.DeleteRecord();
            break;
        case '4':
            diary.ShowAllRecords();
            break;
        case '5':
            diary.ShowSpecificDay(diary.GetDateAndTime(), false);
            break;
        case '6':
            Console.WriteLine("End");
            break;
        default:
            Console.WriteLine("Select number between 1 to 6");
            break;
    }
}
