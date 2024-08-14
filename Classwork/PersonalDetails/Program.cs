Student rozen = new Student("Rozen Shrestha", new  DateTime(1999,05,31), "NCE"," BCT");
(string AgeString, int AgeDays)  = rozen.CalculateAge();
var n = rozen.GetNameInitials();
var details = Student.PrintDetailsOfStudent(initials: n, age: AgeString, ageDays: AgeDays ); //named parameter - explicit declaration , else we have to  send it in order 
var details2 = Student.PrintDetailsOfStudent(initials: n, age: AgeString ); //named parameter - explicit declaration , else we have to  send it in order 
Console.WriteLine(details);
Console.WriteLine(details2);

