using Events;

Customer lazik = new Customer("Lazik");
Order notebook = new Order("Notebook");
Order mobile = new Order("Mobile");

lazik.AddOrder(notebook);
lazik.AddOrder(mobile);

notebook.ChangeStatus(Order.OrderStatus.Confirmed);


void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine("Byl vytvořen soubor: {0}", e.Name);
}

FileSystemWatcher watcher = new FileSystemWatcher();
watcher.Path = @"C:\temp\";
watcher.Created += OnCreated;
watcher.EnableRaisingEvents = true;