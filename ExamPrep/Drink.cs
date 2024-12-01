using System.Dynamic;

namespace ExamPrep;


public abstract class Drink
{


    public string Name {get;set;}
    public double Volume {get;set;}
    public string GlassType {get;set;}
    public double ABV {get;set;}
    public int Price{get;set;}

    public abstract void ListIngredients(); //This is an abstract method and must be implemented in child classes

    public virtual void Serve(){
        Console.WriteLine("The drink is served"); //Base implementation for serving a drink 
    }
    public void BrowseDrinks(){
    Console.WriteLine("Browsing...");
    }
}
