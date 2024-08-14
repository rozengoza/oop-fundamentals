// Vehicle vehicle = new Vehicle();
// vehicle.VehicleNumber = "BA 70 PA 9395";
// var x = vehicle.VehicleNumber;

// ElectricVehicle ev= new ElectricVehicle();
// ev.BatteryCapacity = 200;
// Console.WriteLine($"Mileage of electric vehicle is {ev.GetMileage(875.6f, 95.8f)}");

//modify Instantiation process 
//EV = number, range, batteryCapacity 
IVehicle carEv = new ElectricVehicle("BA 70 PA 9395",420, 1000.5f);
Console.WriteLine(carEv.GetDistanceCovered(20.0f));

//Engine = number , engineCC, mileage
IVehicle carEg = new EngineVehicle("BA 70 PA 1234", 800.0f, 12.0f);
