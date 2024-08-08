Vehicle vehicle = new();
vehicle.VehicleNumber = "BA 70 PA 9395";
var x = vehicle.VehicleNumber;

ElectricVehicle ev= new();
ev.BatteryCapacity = 200;
Console.WriteLine($"Mileage of electric vehicle is {ev.GetMileage(875.6f, 95.8f)}");
