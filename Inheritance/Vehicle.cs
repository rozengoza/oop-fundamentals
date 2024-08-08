public class Vehicle
{
    public string vehicleNumber; // Field lai  camelcasing

    //Full implemented property
    public string VehicleNumber // Property lai pascalcasing
    {
        get => vehicleNumber;
        set
        {
            if (value != "" && value.Length > 5)
            {
                vehicleNumber = value;
            }
        }
    }

    public string Brand { get; set; } = string.Empty; //Auto Implemented Property


    public DateTime Year { get; set; }

    public VehicleType Type { get; set; } = VehicleType.Wagon;

    //Method for Mileage
    // public float CalculateMileage() => 0.0f;
}