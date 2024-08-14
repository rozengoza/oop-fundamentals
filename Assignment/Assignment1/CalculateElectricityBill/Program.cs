Console.WriteLine("Enter the electricity consumption units due to be paid");
string? electricityUnits = Console.ReadLine();
if (float.TryParse(electricityUnits, out float units))
{
    float calculatedBillAmount = CalculateBill(units);
    Console.WriteLine($"Total Bill Amount: {calculatedBillAmount}");
}
else
{
    Console.WriteLine("Please input a numeric value");
}

static float CalculateBill(float units)
{
    float bill = 0;
    switch (units)
    {
        case <= 20:
            bill = 100;
            break;
        case <= 25:
            bill = 100 + (units - 20) * 5.0f;
            break;
        case <= 50:
            bill = 100 + 5 * 5.0f + (units - 25) * 10.0f;
            break;
        default:
            bill = 2000;
            break;
    }

    return bill;
}