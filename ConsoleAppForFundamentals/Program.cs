//data type in c-sharp
// number : integer &  floating point  fixed point

// integer - smallest data type - byte - 8 bits - 255 for age
// byte? age = 32; // adding  ?  after datatype makes the variable nullable
// byte? ageOfChild = null;
// short numberOfPeopleInCompany = 32221; //camel casing 
//pascal casing used for  class/methods

// int areaOfCountry = 29213910; // 32 bits
// long distanceBetweenTwoGalaxies = 2173712321899021931;// 64 bits

// doesn't care about range  , but with precision (accuracy); float is less precise, double is more precise, decimal is most precise
// float averageWeight = 72.1f;//32bit
// double averageDistanceOfCheckpoints = 23423.23232232323; //
// decimal averageDistanceBetweenElectrons = 23243.2322323223232321m;


//precision check 
//float :- 7,8  digits after decimal point 
//double :- 15,16
//decimal :- 27,28 

//by default float lai  double bhanera bujhcha


// string name = "Rozen Shrestha";
// char gender = 'M'; // "" for string  '' for character

//Boolean / Flags
// bool isNepali = true;

// DateTime - not primitive - custom
// DateTime dob = new(1999,07,31);

// datatypes can be nullable
// add ?  after dataypes to make the variables nullable


//display output

// Console.WriteLine("Enter a  string to  count number of characters of.");

// string? userInput = Console.ReadLine();
// Console.WriteLine($"You entered {userInput.Length} characters");

// get username and convert it  to uppercase
// Console.WriteLine("Enter your username:");
// string? userName = Console.ReadLine();
// Console.WriteLine(userName?.ToUpper());

// Program  to calculate the bill amount for electricity consumption 
// Ask user to supply electricity units consumed on his/her meter and calculate total  amount  based on following slabs

