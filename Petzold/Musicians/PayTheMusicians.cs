//------------------------------------------------ 
// PayTheMusicians.cs (c) 2006 by Charles Petzold 
//------------------------------------------------ 
using System; 
 
class PayTheMusicians 
{ 
    static void Main() 
    { 
        /* Violin and SoundEngineer are children of Musician
         * An array of Musician can include child objects, but the
         * children have their own CalculatePay() method and fields 
         * that this method can use*/

        Musician[] musicians =  
            { 
                new Musician("Leonard"),               
                new Violin("Sydney", 0),                                
                new SoundEngineer("Fitz") 
            };

        foreach (Musician mus in musicians)
            Console.WriteLine("Pay {0} the amount of {1:C}",
                mus.Name, mus.CalculatePay());
            Console.ReadLine();
    }
}

/*OUTPUT
Pay Leonard the amount of $100.00
Pay Sydney the amount of $125.00
Pay Fitz the amount of $175.00
*/