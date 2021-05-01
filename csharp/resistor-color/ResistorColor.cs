using System;
using System.Security.Cryptography;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        for (int i = 0; i < Colors().Length; i++) {
            if (color.Equals(Colors()[i])) {
                return i;
            }
        }
        return 0;
      
    }

    public static string[] Colors()
    {
        return new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        //throw new NotImplementedException("You need to implement this function.");
    }
}