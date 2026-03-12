public class User
{
    public string nama;
    public string email;
    public string password;
    public string role;

    public User(string name, string email, string password, string role)
    {
        this.nama = name;
        this.email = email;
        this.password = password;
        this.role = role;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {nama} | Role: {role}");
    }
}

