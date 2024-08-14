public class EngineVehicle : Vehicle, IVehicle // Vehicle lai  inherit garcha ,  IVehicle interface lai  implement garcha, if we dont implement that,  error aaucha
{
    public EngineVehicle(string vehicleNumber, float engineCC, float mileage)
    : base(vehicleNumber)
    {
        EngineCC = engineCC;
        Mileage = mileage;
    }
    public float EngineCC { get; set; }
    public float Mileage { get; set; }
    public float GetDistanceCovered(float oilUsed) => Mileage * oilUsed;
}