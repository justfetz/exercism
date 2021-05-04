using System;
using System.Collections.Generic;

public class GradeSchool
{
    //2 dimensional list

    Dictionary<string, int> openSchool =
    new Dictionary<string, int>();
    public void Add(string student, int grade)
    {
        if(openSchool.ContainsKey(student)) 
        {
            throw new ArgumentException(student.ToString() + " already in list.");
        }
        else
        {
            //openSchool.
            openSchool.Add(student, grade);
        }
    }

    public IEnumerable<string> Roster()
    {
         
        List<string> ros = new List<string>();
        foreach (KeyValuePair<string, int> kvp in openSchool)
            {
            ros.Add((kvp.Key, kvp.Value).ToString());
            }
            return ros;
            
    }

    public IEnumerable<string> Grade(int grade)
    {
    List<string> ros = new List<string>();
        foreach (KeyValuePair<string, int> kvp in openSchool)
            {
            ros.Add((kvp.Key, kvp.Value).ToString());
            }
            return ros;
    }
}