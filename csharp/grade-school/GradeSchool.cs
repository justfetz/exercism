using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{

    Dictionary<string, int> openSchool = new Dictionary<string, int>();

    public void Add(string student, int grade)
    {
        if(openSchool.ContainsKey(student)) 
        {
            throw new ArgumentException(student.ToString() + " already in list.");
        }
        else
        {
            openSchool.Add(student, grade);
        }
    }

    public IEnumerable<string> Roster()
    {
         
        return openSchool.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key); 
            
    }

    public IEnumerable<string> Grade(int grade)
    {
        return openSchool.Where(x => x.Value == grade).Select(x => x.Key).OrderBy(x => x);
        
    }
}