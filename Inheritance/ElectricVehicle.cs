public class ElectricVehicle : Vehicle //Syntax for inheritance
{
    public int BatteryCapacity { get; set; }
    public short Range { get; set; }

    // Complete this 
    // if 20%  battery is used,  BatteryCapacity will also be used

    public float GetMileage(float distanceCovered, float batteryUsedPercentage)
    {
        var energyConsumed = (batteryUsedPercentage * BatteryCapacity)/100;
        var energyConsumptionPerKilometer = energyConsumed/distanceCovered;
        var mileage = 1/ energyConsumptionPerKilometer;
        return mileage;

        // double energyConsumed = (batteryUsedPercentage * BatteryCapacity) / 100;
        // double energyConsumptionPerKilometer = energyConsumed / distanceCovered;
        // double mileage = 1 / energyConsumptionPerKilometer;
        // return (float)Math.Round(mileage, 2);

        // return distanceCovered / ((batteryUsedPercentage * BatteryCapacity)/ 100);
    }
}