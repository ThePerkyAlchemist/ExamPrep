using System.Collections;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace ExamPrep;

public class Processor
{
    List<Drink> basket = new List<Drink>();
    List<Drink> menu = new List<Drink>();
    public void InitializeMenu(){
        menu.Add(new FermentedDrink("Session IPA", 4.8));
        menu.Add(new FermentedDrink("Cider", 4.5));
        menu.Add(new FermentedDrink("Sauvignon Blanc", 14));
        menu.Add(new Cocktail("Negroni", 18));
        menu.Add(new Cocktail("Old Fashioned", 26));
        menu.Add(new Cocktail("Dark and Stormy", 17));
    }
    
    public void Run(){
        Console.WriteLine("Welcome to Peter's Drink Emporium - Also known as TheBeacon!");
        InitializeMenu();
        Navigate();
    }
    public void PrintBeerMenu(){
        for(int i = 0; i < menu.Count; i++){
            Console.WriteLine(menu[i].Name + " - " + menu[i].ABV);
        }
    }
    public void Navigate(){
        
        Console.WriteLine("What would you like to order?");
        Console.WriteLine("Select the number from the list below:");
        Console.WriteLine("1) Beer, cider or wine");
        Console.WriteLine("2) Cocktails or long drinks");
        Console.WriteLine("3) To exit the bar");
        int selection = int.Parse(Console.ReadLine());

        switch(selection){

        case 1:   
        PrintBeerMenu();
        //f.BrowseDrinks();
        
        break;

        case 2:
        Console.WriteLine("Cocktail selected");
        break;

        case 3:
        Exit();
        break;

        default:
        Console.WriteLine("I don't understand");
        Navigate();
        break;
    
        }
    }
    public void Exit(){
    foreach(var drink in basket){
        Console.WriteLine(drink.Name + " - " + drink.ABV);
    }
    Console.WriteLine("Thank you, bye!"); //Consider implementing a Pay(Basket) method. 
    }
    

}

