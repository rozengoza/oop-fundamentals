public class HomePage
{
    public HomePage(string menuItemTitle)
    {
        this.menuItemTitle = menuItemTitle;
    }
    private string menuItemTitle;
    private string[]? menuItems;
    public string[]? MenuItems
    {
        get => menuItems ;
        set 
        {
            if(value == null) //If value is null, then initialize an array with the menuItemTitile
            {
                menuItems = new[] { menuItemTitle };
            }
            else // else, append menuItemTitle to the existing array
            {
                menuItems = value.Concat(new[] {menuItemTitle}).ToArray();
            }
        }
    }
    public int? HeightPixels
    {
        get;
        set;
    }
    public int? WidthPixels
    {
        get;
        set;
    }

    public byte[]? ProfileAvatar
    {
        get;
        set;
    }

    //first method to navigate on MenuClick
    public string HandleMenuClick (string menuItem)
    {
        return menuItem; //url return garnuparcha inorder to  navigate
    }
    //second method to facilitate login
    public string Login(string userName, string password)
    {
        return $"Try logging in user with userName {userName} and password {password}";
    }

}