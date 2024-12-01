using System.Security.Cryptography.X509Certificates;

namespace ExamPrep;

public class FermentedDrink : Drink
{
    public FermentedDrink(string name, double volume, double abv)
    {
        Name = name;
        Volume = volume;
        ABV = abv;
    }
    public FermentedDrink(string name, double abv){
        Name = name;
        ABV = abv;
    }
    public int BubblesPer100ml {get;set;} //number of bubbles in 100ml 
    public double Tannins {get;set;}// g/L 

    public override void ListIngredients(){
    Console.WriteLine("Placeholder for implementation");
    
    }
    

    
    
}
