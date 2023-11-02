using PasswordGenerator;

var pwd = new Password();
var password = pwd.Next();
Console.WriteLine(password.ToString());
Console.ReadLine();