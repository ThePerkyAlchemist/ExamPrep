namespace ExamPrep;

public class Cocktail : Drink
{
        public Cocktail(string name, double volume, double abv)
    {
        Name = name;
        Volume = volume;
        ABV = abv;
    }
    public Cocktail(string name, double abv){
        Name = name;
        ABV = abv;
    }
    public string BaseAlcohol {get;set;}
    public int BaseAlcoholVolume {get;set;}
    public string Garnish {get;set;}
    //Add ingredients and ingredients volume
    public override void ListIngredients(){
        Console.WriteLine("Plasceholder for implementation");
    }
    public override void Serve(){
        //PLaceholder
    }
    public void TellStory(){
        //implement case/switch for specific drinks
    }
}
