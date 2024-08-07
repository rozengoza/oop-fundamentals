Student rozen = new Student("Rozen Shrestha", new  DateTime(1999,05,31), "NCE"," BCT");
var x = rozen.CalculateAge();
var n = rozen.GetNameInitials();
var details = Student.PrintDetailsOfStudent(initials: n, age: x); //named parameter - explicit declaration , else we have to  send it in order 
Console.WriteLine(details);

