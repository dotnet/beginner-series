public class Account
{

    public string Email {get; set;}
    public bool Active {get; set;}
    public DateTime CreatedDate {get; set;} 
    public IList<string> Roles {get; set;}  
}