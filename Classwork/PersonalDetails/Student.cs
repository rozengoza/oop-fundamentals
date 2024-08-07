class Student( string name, DateTime dob, string college, string program)
{
    //instance member  or members of  object
    public string name = name;
    public  DateTime dob = dob;
    public string college = college;
    public string program = program;
// Calculate the age  of a person in years and months

    public string CalculateAge() 
    {
        var ageSpan = DateTime.Now -dob;
        var year = ageSpan.Days /365;
        var months = ageSpan.Days % 365 / 30 ; //operator  precedence - parenthesis not required in this case
        return $"{year} years and {months} months";
    }

    // get name initails of a  person : Rozen Shrestha RS
    //string itself is a char array so it can be indexed 

    public string GetNameInitials()
    {
        var  nameParts = name.Split(" "); //delimitter
        var  firstInitial = nameParts[0][0];
        var lengthOfArray = nameParts.Length;
        // var lastInitial = nameParts[lengthOfArray - 1][0] ;
        var lastInitial = nameParts[^1][0] ; // range functions in C# :- Index Operator 
        // var lastInitial = nameParts[0..][0] ; // range functions in C# :- Index Operator 
        return $"{firstInitial}{lastInitial}";

    }

    public string CapitalizeName() => name.ToUpper();
    // This code below can also  be written as  above arrow function
    // public string CapitalizeName
    // {
    //     return name.ToUpper();
    // }


    // Print details  of a student, Output format : NameInitials is Years years and Months months old

    //static keyword : jatibela class ko instance aru  instance member ma depend hudaina,  aru member lai  use gardaina, testo  case ma we  can mark this as static
   //benefits of static function : teslai  call garnalai object banairakhna pardaina, className. garera  call  garna milcha
    public static string PrintDetailsOfStudent(string initials, string age) => 
    $"{initials} is {age} old";
}