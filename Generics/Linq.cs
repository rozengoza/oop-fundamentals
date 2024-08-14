using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics;

internal class Linq //Language Integrated Query 
{
    double[] marks = [90.5, 40.2, 38.0, 42.1,22,33.1, 88.1, 7.0]; // "90.50"  into  string and to  two  decimal  place

    // get all marks  which surpass  the passmarks 40 

    public void LearnLinq()
    {
        List<double> passMarks = [];
        foreach ( var mark in marks)
        {
            if( mark > 40 )
            {
                passMarks.Add(mark);
            }
        }

        //declarative
        var passMarks1 = marks.Where( mark => mark > 40 ); //Filter

        var result = marks.Select( x => x.ToString("d2"));
        
       // byte y = 32;
        //int e = y; //implicit casting


    }

}