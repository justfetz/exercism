using System;
using System.Collections.Generic;

public class Robot
{
    
    Random _random = new Random();
    public static List<string> Names = new List<string>();
    const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public Robot()
    {
        Name = GenerateName();
    }

    public string Name { get; private set; }

    public void Reset()
    {
        Names.Remove(Name);
        Name = GenerateName();
    }

    public string GenerateName()
    {
        int i = _random.Next(0, 9);
        int j = _random.Next(0, 9);
        int k = _random.Next(0, 9);
        string l = alphabet[_random.Next(0, 25)].ToString();
        string m = alphabet[_random.Next(0, 25)].ToString();
       string nameToReturn = (l + m + i + j + k).ToString();

        if (Names.Contains(nameToReturn))
        {
            nameToReturn = GenerateName();
        }

        Names.Add(nameToReturn);
        return nameToReturn;
    }
}
   