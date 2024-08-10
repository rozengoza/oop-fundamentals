public class AboutUsPage : HomePage, IDriver
{
    public AboutUsPage(string title, int[] contacts)
    : base(title)
    {
        Contacts = contacts;
    }

    public int[] Contacts { get; set; }

    public string InitiatePhone( string phoneNumber)
    {
        return $"Calling to phone number {phoneNumber}";
    }

    public string InitiateEmail( string email )
    {
        return $"Email sent to  {email}";
    }
}