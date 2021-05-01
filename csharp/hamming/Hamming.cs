using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int counter = 0;

        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException("Distances are different and cannot be calculated.");
       
        }
        else {
            for (int i = 0; i < firstStrand.Length; i++) {
                if (firstStrand[i] != secondStrand[i]) {
                    counter++;
                }
            }
        }
        return counter;
        throw new NotImplementedException("You need to implement this function.");
    }
}