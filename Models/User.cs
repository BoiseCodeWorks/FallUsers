namespace login
{
  class User
  {
    public string Username { get; set; }
    private string Password { get; set; }
    public int AccessLevel { get; set; } = 1;

    public bool ValidatePassword(string pass)
    {
      return pass == Password;
    }

    public User(string username, string password)
    {
      Username = username;
      Password = password;
    }
  }
}