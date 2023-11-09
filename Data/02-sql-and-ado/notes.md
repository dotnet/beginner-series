# Notes for Relational Database Basics and ADO.NET

## SQL for CRUD

```sql
-- Create a new product
INSERT INTO dbo.Products (Name, Price)
VALUES ('Cam''s favorite', 9.99);

-- Read all products
SELECT * FROM dbo.Products;

-- Read a specific product by Id
SELECT * FROM dbo.Products WHERE Id = 1;

-- Update a product by Id
UPDATE dbo.Products SET Name = 'Updated Product', Price = 14.99 WHERE Id = 1;

-- Delete a product by Id
DELETE FROM dbo.Products WHERE Id = 1;
```

## ADO.NET

```csharp

string connectionString = "Data Source=sqlserver;Initial Catalog=ContosoPizza;Integrated Security=True";

// Create a new product
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    string insertSql = "INSERT INTO dbo.Products (Name, Price) VALUES (@Name, @Price);";
    SqlCommand command = new SqlCommand(insertSql, connection);
    command.Parameters.AddWithValue("@Name", "New Product");
    command.Parameters.AddWithValue("@Price", 9.99);
    command.ExecuteNonQuery();
}

// Read all products
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    string selectSql = "SELECT * FROM dbo.Products;";
    SqlCommand command = new SqlCommand(selectSql, connection);
    SqlDataReader reader = command.ExecuteReader();

    while (reader.Read())
    {
        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Price: {reader["Price"]}");
    }
}

// Read a specific product by Id
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    string selectSql = "SELECT * FROM dbo.Products WHERE Id = @Id;";
    SqlCommand command = new SqlCommand(selectSql, connection);
    command.Parameters.AddWithValue("@Id", 1);
    SqlDataReader reader = command.ExecuteReader();

    while (reader.Read())
    {
        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Price: {reader["Price"]}");
    }
}

// Update a product by Id
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    string updateSql = "UPDATE dbo.Products SET Name = @Name, Price = @Price WHERE Id = @Id;";
    SqlCommand command = new SqlCommand(updateSql, connection);
    command.Parameters.AddWithValue("@Name", "Updated Product");
    command.Parameters.AddWithValue("@Price", 14.99);
    command.Parameters.AddWithValue("@Id", 1);
    command.ExecuteNonQuery();
}

// Delete a product by Id
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    string deleteSql = "DELETE FROM dbo.Products WHERE Id = @Id;";
    SqlCommand command = new SqlCommand(deleteSql, connection);
    command.Parameters.AddWithValue("@Id", 1);
    command.ExecuteNonQuery();
}
```