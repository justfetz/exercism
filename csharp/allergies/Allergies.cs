using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}


public class Allergies
{
    private int mask;
    //private List<string> allergens;
    
    public Allergies(int mask)
    {
        this.mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        int x = (int)allergen;
        return (x  &  mask) > mask;
    }

    public Allergen[] List()
    {
        
        List<Allergen> allergenList = new List<Allergen>();
        foreach(Allergen all in Enum.GetValues(typeof(Allergen))) {
            if(IsAllergicTo(all)) {
                allergenList.Add(all);
            }       
        }
        return allergenList.ToArray();   
          
    }
}