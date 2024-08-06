class PersonBMI
{

    public PersonBMI(string name, double height, double weight)
    {
        this.name = name;
        this.height = height;
        this.weight = weight;
    }
    public string name;
    public double height;
    public double weight;

    double CalculateBMIOfPerson(double height, double weight )
    {
        double bmi = weight / Math.Pow((0.3048 * height), 2);
        return Math.Round(bmi,2);
    }
    public void PrintPersonDetails()
    {
        Console.WriteLine($"BMI of {this.name} of height {this.height} feet and weight {this.weight} kgs is {CalculateBMIOfPerson(this.height, this.weight)}");
    }

}