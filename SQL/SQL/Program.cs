using System.Data;
using System.Data.SqlClient;

// How to connect to database

// METHOD 1 - create StringBuilder
SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
csb.DataSource = "Lazik";
csb.InitialCatalog = "Words";
csb.IntegratedSecurity = true;
string connectionStringExample = csb.ConnectionString;

// METHOD 2 - copy connection string from dbo Properties in Server Explorer
string connectionStringDBO = @"Data Source=Lazik; Initial Catalog = Words; Integrated Security = True";

using (SqlConnection connection = new SqlConnection(connectionStringDBO))
{
    connection.Open();
    Console.WriteLine("Application successfully connected to database");


    SqlCommand cmd = connection.CreateCommand();
    cmd.Connection = connection;
    cmd.CommandText = "SELECT COUNT(*) FROM WORD";


    // Methods - ExecuteReader(), ExecuteScalar(), ExecuteNonQuery()

    // ExecuteScalar()
    // - used when we get single data, for example SELECT with AGGREGATE method
    int numberOfWords = (int)cmd.ExecuteScalar();
    cmd.Connection.Close();
    Console.WriteLine("Number of words in Word table is {0}", numberOfWords);

    // ExecuteReader() 
    // - used when we get more data, for example with SELECT
    SqlCommand cmd1 = new SqlCommand("SELECT Id, Czech, English FROM Word", connection);
    connection.Open();
    SqlDataReader reader = cmd1.ExecuteReader();

    string header = "ID".PadRight(15) + "Czech".PadRight(15) + "English".PadRight(15);
    Console.WriteLine();
    Console.Write(header);
    Console.WriteLine("\n");

    while (reader.Read())
    {
        Console.WriteLine("{0}{1}{2}",
            reader[0].ToString().PadRight(15),              // ID sloupce
            reader["Czech"].ToString().PadRight(15),        // Nazev sloupce
            reader.GetString(2).PadRight(15));   // index sloupce s prevedenim na pozadovany datovy typ
    }
    connection.Close();

    // ExecuteNonQuery()
    // - used when we don't get any data back, for example INSERT, UPDATE, DELETE


    ///
    /// WRONG - SQL INJECTION
    ///
    string word = Console.ReadLine();
    SqlCommand sqlInjection = new SqlCommand(@"SELECT Id, Czech, English FROM Word WHERE English='" + word + "'", connection);
    connection.Open();
    SqlDataReader reader2 = sqlInjection.ExecuteReader();

    while (reader2.Read())
    {
        Console.WriteLine("{0} {1}", reader2[0], reader2[1]);
    }
    connection.Close();

    ///
    /// CORRECT VERSION
    ///
    // We need to asume, that every parameter can contain malware / sql injection
    string word1 = Console.ReadLine();
    SqlCommand sqlCorrectCommand = new SqlCommand(@"SELECT Id, Czech, English FROM Word WHERE English=@word", connection);
    sqlCorrectCommand.Parameters.AddWithValue("@word", word1);

    connection.Open();
    SqlDataReader reader3 = sqlCorrectCommand.ExecuteReader();

    while (reader3.Read())
    {
        Console.WriteLine("{0} {1}", reader3[0], reader3[1]);
    }
    connection.Close();

    ///
    /// CRUD - Create, Read, Update, Delete
    ///

    // READ
    // examples above

    // INSERT (CREATE)
    Console.Write("Please insert czech word: ");
    string czechWord = Console.ReadLine();
    Console.Write("Please insert english translation: ");
    string englishWord = Console.ReadLine();

    string queryInsert = "INSERT INTO Word (Czech, English) VALUES (@czech, @english)";
    using (SqlCommand sqlQuery = new SqlCommand(queryInsert, connection))
    {
        connection.Open();
        sqlQuery.Parameters.AddWithValue("@english", englishWord);
        sqlQuery.Parameters.AddWithValue("@czech", czechWord);
        int changedRows = sqlQuery.ExecuteNonQuery();
        Console.WriteLine(changedRows);
    }

    // DELETE
    Console.WriteLine("Please insert which english word you want to delete: ");
    string deleteWord = Console.ReadLine();

    string deleteQuery = "DELETE FROM Word WHERE English=@english";
    using (SqlCommand sqlDelete = new SqlCommand(deleteQuery, connection))
    {
        sqlDelete.Parameters.AddWithValue("@english", deleteWord);
        int changedRows = sqlDelete.ExecuteNonQuery();
        Console.WriteLine(changedRows);
    }

    // UPDATE
    Console.WriteLine("Please insert a czech word which translation you would like to change: ");
    string czechWordToChange = Console.ReadLine();
    Console.WriteLine("Please insert new translation: ");
    string translation = Console.ReadLine();

    string queryUpdate = "UPDATE Word SET English=@english WHERE Czech=@czech";
    using (SqlCommand sqlUpdate = new SqlCommand(queryUpdate, connection))
    {
        sqlUpdate.Parameters.AddWithValue("@english", translation);
        sqlUpdate.Parameters.AddWithValue("@czech", czechWordToChange);
        int changedRows = sqlUpdate.ExecuteNonQuery();
        Console.WriteLine(changedRows);
    }
    connection.Close();

    ///
    /// Data Set / DataTable
    /// Data Set can store multiple tables at once, DataTable only one
    ///
    string connectionString = @"Data Source=Lazik; Initial Catalog = Words; Integrated Security = True";
    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
    {
        connection.Open();

        string selectQuery = "SELECT * FROM Word";
        using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
        using (DataSet result = new DataSet())
        {
            // automatically opens and closes connection so we don't have to open it manually
            adapter.Fill(result);

            foreach (DataRow row in result.Tables[0].Rows)
            {
                Console.WriteLine("Id: " + row[0] + " Cesky: " + row["Czech"] + " Anglicky: " + row["English"]);
                //Console.WriteLine(row);
            }
        }

        connection.Close();
    }

    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
    {
        connection.Open();

        Console.WriteLine("Please insert english word to be translated.");
        string inputWord = Console.ReadLine();
        string query = "SELECT Czech FROM Word WHERE English=@english";
        using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            using (DataTable result = new DataTable())
        {
            adapter.SelectCommand.Parameters.AddWithValue("@english", inputWord);
            adapter.Fill(result);

            Console.WriteLine("Translation: {0}", result.Rows[0]["Czech"]);
        }
    }
}

