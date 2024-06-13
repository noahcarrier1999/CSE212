public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        //Proccess: 
        //     1. I first need a place to put the results so I will create and array to place the results in
        //     2. I will need to loop through each of the items in length to multiply the number by each
        //     3. I will add the result to the results list

        //list to store the results into a new array
        double[] results = new double[length];

        //loops through the length for example the firts time around it is 0 then 1,2,3,4,5
        //then multiplies the number by the length + 1 so it doesn't start with 0
        //It adds the result to the array

        //Example:
        for (int i = 0; i < length; i++){
             results[i] = number * (i + 1);
        }
        
        
    
        //returns the array 
        return results; // replace this return statement with your own
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Process:
        //   The process that I a thinking now is to have 2 separate lists one that grabs the numbers with
        //   the indexes over the count of the list subtracting the chosen amount to grab the number that 
        //   will need to be moved to the front of the new list. The second list will be full of the numbers
        //   are the other portion of the list. Then I combined the two lists into one list.

        //list for the values that index is under the rotate amount
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();

        //This finds the the items that are above the amount partition
        //  for example:
        //      List[1,2,3,4,5,6,7,8,9] 
        //      Amount 3
        // this would make list1 be [7,8,9]
        for (int i = data.Count - amount; i < data.Count; i++){
            list1.Add(data[i]);
        }

        //This finds the items that are below the partition amount
        // For the same example above 
        // This would make list2 be [1,2,3,4,5,6]
        for (int i = 0; i < data.Count - amount; i++){
            list2.Add(data[i]);
        }

        //this combines the 2 lists
        //so the list now is [7,8,9,1,2,3,4,5,6]
        //which makes it look like it has rotated to the right
        List<int> combinedList = new List<int>();
        combinedList.AddRange(list1);
        combinedList.AddRange(list2);

        //this clears the original data in the list given
        data.Clear();
        //this adds the new list to the origianl now blank data
        data.AddRange(combinedList);
    }
}
