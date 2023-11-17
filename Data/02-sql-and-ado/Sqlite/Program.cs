using System;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=ContosoPizza.db";

        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Display all records
            DisplayAllRecords(connection);
            DisplaySeparator();

            // Create operation
            Console.WriteLine("About to create a new record for Milkshake. Press Enter to proceed...");
            Console.ReadLine();
            string createQuery = "INSERT INTO Products (Name, Price) VALUES (@Name, @Price)";
            using (SqliteCommand command = new SqliteCommand(createQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", "Milkshake");
                command.Parameters.AddWithValue("@Price", 9.99);
                command.ExecuteNonQuery();
            }
            Console.WriteLine("New record for Milkshake created.");
            
            DisplayAllRecords(connection);
            DisplaySeparator();

            // Read operation
            Console.WriteLine("About to read the record for Milkshake. Press Enter to proceed...");
            Console.ReadLine();
            string readQuery = "SELECT * FROM Products WHERE Name = @Name";
            using (SqliteCommand command = new SqliteCommand(readQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", "Milkshake");
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Price: {reader["Price"]}");
                    }
                }
            }

            DisplaySeparator();

            // Update operation
            Console.WriteLine("About to update the price of Milkshake. Press Enter to proceed...");
            Console.ReadLine();
            string updateQuery = "UPDATE Products SET Price = @Price WHERE Name = @Name";
            using (SqliteCommand command = new SqliteCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", "Milkshake");
                command.Parameters.AddWithValue("@Price", 4.99);
                command.ExecuteNonQuery();
            }
            Console.WriteLine("Record for Milkshake updated.");

            DisplayAllRecords(connection);
            DisplaySeparator();

            // Delete operation
            Console.WriteLine("About to delete the record for Milkshake. Press Enter to proceed...");
            Console.ReadLine();
            string deleteQuery = "DELETE FROM Products WHERE Name = @Name";
            using (SqliteCommand command = new SqliteCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", "Milkshake");
                command.ExecuteNonQuery();
            }
            Console.WriteLine("Record for Milkshake deleted.");
            
            DisplayAllRecords(connection);
            DisplaySeparator();
        }
    }

    static void DisplayAllRecords(SqliteConnection connection)
    {
        Console.WriteLine("Here are all the records:\n");
        string selectQuery = "SELECT * FROM Products";
        using (SqliteCommand command = new SqliteCommand(selectQuery, connection))
        {
            using (SqliteDataReader reader = command.ExecuteReader())
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