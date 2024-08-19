
public class UserAuthService
{
    private readonly Dictionary<string, string> users = new Dictionary<string, string>();

    public void RegisterUser(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Username and password cannot be empty.");

        if (users.ContainsKey(username))
            throw new InvalidOperationException("User already exists.");

        users[username] = password;
    }

    public bool AuthenticateUser(string username, string password)
    {
        if (!users.ContainsKey(username))
            return false;

        return users[username] == password;
    }
}