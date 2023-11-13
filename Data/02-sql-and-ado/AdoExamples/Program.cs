using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Server=sqlserver;Database=ContosoPizza;User Id=sa;Password=P@ssw0rd;Encrypt=False";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Display all records
            DisplayAllRecords(connection);
            DisplaySeparator();

            // Create operation
            Console.WriteLine("About to create a new record for Buffalo Wings. Press Enter to proceed...");
            Console.ReadLine();
            string createQuery = "INSERT INTO Products (Name, Price) VALUES (@Name, @Price)";
            using (SqlCommand command = new SqlCommand(createQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", "Buffalo Wings");
                command.Parameters.AddWithValue("@Price", 9.99);
                command.ExecuteNonQuery();
            }
            Console.WriteLine("New record for Buffalo Wings created.");
            
            DisplayAllRecords(connection);
            DisplaySeparator();

            // Read operation
            Console.WriteLine("About to read the record for Buffalo Wings. Press Enter to proceed...");
            Console.ReadLine();
            string readQuery = "SELECT * FROM Products WHERE Name = @Name";
            using (SqlCommand command = new SqlCommand(readQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", "Buffalo Wings");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Price: {reader["Price"]}");
                    }
                }
            }

            DisplaySeparator();

            // Update operation
            Console.WriteLine("About to update the price of Buffalo Wings to 19.99. Press Enter to proceed...");
            Console.ReadLine();
            string updateQuery = "UPDATE Products SET Price = @Price WHERE Name = @Name";
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", "Buffalo Wings");
                command.Parameters.AddWithValue("@Price", 19.99);
                command.ExecuteNonQuery();
            }
            Console.WriteLine("Record for Buffalo Wings updated.");

            DisplayAllRecords(connection);
            DisplaySeparator();

            // Delete operation
            Console.WriteLine("About to delete the record for Buffalo Wings. Press Enter to proceed...");
            Console.ReadLine();
            string deleteQuery = "DELETE FROM Products WHERE Name = @Name";
            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", "Buffalo Wings");
                command.ExecuteNonQuery();
            }
            Console.WriteLine("Record for Buffalo Wings deleted.");
            
            DisplayAllRecords(connection);
            DisplaySeparator();
        }
    }

    static void DisplayAllRecords(SqlConnection connection)
    {
        Console.WriteLine("Here are all the records:\n");
        string selectQuery = "SELECT * FROM Products";
        using (SqlCommand command = new SqlCommand(selectQuery, connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Price: {reader["Price"]}");
                }
            }
        }
    }

    static void DisplaySeparator()
    {
        Console.WriteLine("\n=====================\n");
    }
}