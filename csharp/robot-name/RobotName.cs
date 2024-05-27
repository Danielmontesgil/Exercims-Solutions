using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Robot
{
    private HashSet<string> namesCreated = new HashSet<string>();
    private string name;
    
    public string Name
    {
        get
        {
            if (!string.IsNullOrEmpty(name))
            {
                return name;
            }

            Reset();
            return name;
        }
    }

    public void Reset()
    {
        var newName = new StringBuilder(5);
        do
        {
            for (int i = 0; i < 5; i++)
            {
                if (i < 2)
                {
                    newName.Append((char)new Random().Next(65, 90 + 1));
                    continue;
                }

                newName.Append(new Random().Next(0, 10));
            }
            
        } while (namesCreated.Contains(newName.ToString()));

        namesCreated.Add(newName.ToString());
        name = newName.ToString();
    }
}