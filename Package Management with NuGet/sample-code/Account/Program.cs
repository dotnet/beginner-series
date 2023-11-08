// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json; 

Account account = new Account
{
    Email = "james@example.com",
    Active = true,
    CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
    Roles = new List<string>
    {
        "User",
        "Admin"
    }
};

string json = JsonConvert.SerializeObject(account, Formatting.Indented);
Console.WriteLine(json);