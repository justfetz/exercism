using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak(string sellerName = "you")
    {
        //return "One for you, one for me.";
        
        //String x = Console.ReadLine();

        if (sellerName.Length < 1)
        {
            throw new NotImplementedException("One for you, one for me.");
        }
        else {
            return "One for " + sellerName + ", one for me.";

        }
        

    }
}
