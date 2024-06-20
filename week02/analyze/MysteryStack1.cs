public static class MysteryStack1 {
    public static string Run(string text) {
        //create a new stack
        var stack = new Stack<char>();
        //for each character in the line of text
        //it pushes to the stack
        foreach (var letter in text)
            stack.Push(letter);

        
        var result = "";
        //as long ast there are still characters in the stack
        while (stack.Count > 0)
            //at to result
            result += stack.Pop();

        return result;
    }
}




//This shoud reverse the order of the text

//racecar should return racecat
//stressed should return desserts
//a nut for a jar of tuna should return anut fo raj a rof tun a


