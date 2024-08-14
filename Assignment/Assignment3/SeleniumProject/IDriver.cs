public interface IDriver
{
    public string Navigate( string url)
    {
        return "/"+url;
    }

    public string GetCurrentURL ()
    {
        return "hello";
    }

    public string InitiatePhone(string phoneNumber);
    public string InitiateEmail(string email);

    public string HandleMenuClick( string menuItem);

    public string Login(string userName, string password);


}