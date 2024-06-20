using System;
using System.Collections.Generic;

class D
{
    static void Main()
    {
        int[] d = R(5);
        Array.Sort(d);
        Console.WriteLine("Values: " + string.Join(", ", d));
        int s = C(d);
        Console.WriteLine("Total: " + s);
    }

    static int[] R(int n)
    {
        //initializes Random Number
        Random r = new Random();
        //Makes a new list with the length of n
        int[] d = new int[n];
        //loops through list and puts a gets a random number between 1 and 7
        for (int i = 0; i < n; i++)
        {
            d[i] = r.Next(1, 7);
        }
        //returns the list
        return d;
    }

    static int C(int[] d)
    {
        int s = 0;
        //Creates a new dictionary
        Dictionary<int, int> c = new Dictionary<int, int>();
        //loops through each of the ints in the d list
        foreach (int x in d)
        {
            if (c.ContainsKey(x))
            {
                //finds if there are multiple
                c[x]++;
            }
            else
            {
                c[x] = 1;
            }
        }
        foreach (int v in c.Values)
        {
            switch (v)
            {
                //if there is multiple then it give a greater value
                case 2:
                    s += 10;
                    break;
                case 3:
                    s += 20;
                    break;
                case 4:
                    s += 30;
                    break;
                case 5:
                    s += 40;
                    break;
            }
        }
        return s;
    }
}
