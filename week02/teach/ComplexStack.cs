public static class ComplexStack {
    public static bool DoSomethingComplicated(string line) {
        //creates new Stack
        var stack = new Stack<char>();
        //for each item in the string
        foreach (var item in line) {
            //if any item is (,[,or{ it moves it to the end of the stack
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }
            //if item is ) 
            else if (item is ')') {
                //checks if the string is empty or the current pop is does not = (
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            //if the item is ]
            else if (item is ']') {
                //checks if the stack is empty or the current pop is not [
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            //if item is }
            else if (item is '}') {
                //checks if the stack is empty or current pop does not equal {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }
        //clears the stack to empty
        return stack.Count == 0;
    }
}


//input:(a == 3 or (b == 5 and c == 6))
//returns true

//input:(students]i].Grade > 80 and students[i].Grade < 90)
//returns false because ther was a ] but the pop was a ( not a [

//input:(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))
//returns false because there still is a missing (