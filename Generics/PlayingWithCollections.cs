using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace ConsoleAppForFundamentals.Generics;

//internal class PlayingWithCollections
//{

//}

internal class PlayingWithCollections // Can be accessed by the classes that  inherits this class
{
    //Arrays,  Lists, Dictionaries

    public static void LearnArrays()
    {
        string[] empNames = new string[10];

        empNames[0] = "Rozen Shrestha";
        empNames[1] = "Hari Shrestha";
        empNames[2] = "Shyam Shrestha";
        empNames[3] = "Laxmi Shrestha";

        //string[] names = ["Rozen", "Hari", "Shyam", "Laxmi"]; // can be intialized this way

        byte[] evenNumbers = [2, 4, 6, 8, 10, 12, 14, 16, 20];
        // int[][] or int [,]
        int[][] matrix1 = [(2, 3), (3, 4)]; //Jagged arrays

        int[,,] matirx2 = { { 1, 2, 3 }, { 4, 5 , 6} };

        //create an array of numbers from 1 to  100 
        //print  that collection , print the number to console  if its multiple of 3 or 5

        int[] numberArrays = new int[100];
        for(int i = 0; i<100; i++)
        {
            numberArrays[i] = i + 1;
        }

        int[] generatedArray = new int[];
       generatedArray =  foreach (var item in numberArrays)
        {
            if(item % 3 == 0 || item % 5 == 0)
            {
                return item;
            }
        }

        Console.WriteLine(generatedArray);

    }

    public void LearnLists()
    {
        List<string> names = ["R1", "R2", "R3"];
        names.Add("Rozen");

        List<Person> people = new(); // File heirarchy milayera  garda milcha .sln file basis
        Person person1 = new Person();
        Person person2 = new Person();

        Person person3 = new Person();

        Person person4 = new Person();

        Person person5 = new Person();
        people.Add(person1);
        people.Add(person2);
        people.Add(person3);
        people.Add(person4);
        people.Add(person5);
        //country ra capital lai  store garna paryo 
        List<(string Country, string Capital)> countries = new(); // makes sense for 2 values tuple

        countries.Add(("Nepal", "Kathmandu"));
        countries.Add(("China", "Beijing"));
        countries.Add(("India", "Delhi"));
        countries.Add(("Bhutan", "Thimpu"));

    }

    public void LearnDictionaries() // dictionaires  :- key value pair
    {
        Dictionary<string,  int> countryPopn = new (); // key  must be unique, error if duplicate key
        countryPopn.Add("Nepal", 31534235);
        countryPopn.Add("India", 1431534235);
        countryPopn.Add("China", 1131534235);

    }






}