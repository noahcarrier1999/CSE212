public static class MysteryStack2 {
    private static bool IsFloat(string text) {
        return float.TryParse(text, out _);
    }

    public static float Run(string text) {
        //Creates a new stack of floats
        var stack = new Stack<float>();
        //for each character in a spited text exp: Happy H,a,p,p,y
        foreach (var item in text.Split(' ')) {
            //if there are any of these +,-,*,/
            if (item == "+" || item == "-" || item == "*" || item == "/") {
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!");
                //gets that last item in the stack
                var op2 = stack.Pop();
                //gets the second to last item in stact 
                var op1 = stack.Pop();
                float res;
                //adds the two if it sees a +
                if (item == "+") {
                    res = op1 + op2;
                }
                //subtracts the two when it sees a -
                else if (item == "-") {
                    res = op1 - op2;
                }
                //Multiplys the 2 when it sees *
                else if (item == "*") {
                    res = op1 * op2;
                }
                //if op2 is 0 shrow an error
                else {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;
                }
                //pushes the result to the end of the stack
                stack.Push(res);
            }
            else if (IsFloat(item)) {
                stack.Push(float.Parse(item));
            }
            else if (item == "") {
            }
            else {
                throw new ApplicationException("Invalid Case 3!");
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!");

        return stack.Pop();
    }
}


//5 3 7 + * should return 50
//6 2 + 5 3 - / should return a 4

//display Invalid Case 1: if there are less than 2 numbers in the stack
//display Invalid Case 2: if there is a 0 in the Op2
//display Invalid Case 3: if its not an empty string, if its not a float and there is no +-*/
//      this would be if you just put a number in the input without any operations
//      you could do this if you put a opperation in that is not allowed also
//display Invalid Case 4: this will be if the result has more than one item in the stack