using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> d = new Dictionary<char, int>();

        int aCounter = 0;
        int cCounter = 0;
        int gCounter = 0;
        int tCounter = 0;

        foreach (char i in sequence) {
            if (i.Equals('A'))
            {
                aCounter++;
            }
            else if (i.Equals('C'))
            {
                cCounter++;
            }
            else if (i.Equals('G'))
            {
                gCounter++;
            }
            else if (i.Equals('T'))
            {
                tCounter++;
            }
            else if (!i.Equals('T') || !i.Equals('A') || !i.Equals('G') || !i.Equals('C')) {
                throw new ArgumentException();
            }
        }

        d.Add('A', aCounter);
        d.Add('C', cCounter);
        d.Add('G', gCounter);
        d.Add('T', tCounter);

        return d;
    }
}