using System;


public static class Bob
{
    public static string Response(string statement)
    {
        int x = 0;
        
        foreach(Char c in statement) {
            if (Char.IsUpper(c)) {
                x += 1;
            }
            
        }
        /*throw new NotImplementedException("You need to implement this function.");



        Bob answers 'Sure.' if you ask him a question.

        He answers 'Whoa, chill out!' if you yell at him.

        He answers 'Calm down, I know what I'm doing!' if you yell a question at him.

        He says 'Fine. Be that way!' if you address him without actually saying
        anything.

        He answers 'Whatever.' to anything else. */
   

        if(statement.EndsWith('?')) 
        {
            return "Sure.";
        } 
        else if(statement.Length==0) 
        {
            return "Fine, be that way.";
        } 
        else if((x == statement.Length-1 && statement.EndsWith(Char.IsPunctuation(statement[statement.Length-1]).ToString())) || x==statement.Length) 
        {
            return "Whoa, chill out!";
        } 
        else if (x == statement.Length-1 && statement.EndsWith("?")) 
        {
            return "Calm down, I know what I'm doing!";
        } 
        else
        {
            return "Whatever.";
        } 

    }
}