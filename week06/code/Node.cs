public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data){
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data){
            return true;
        } else if (value < Data){
            return Left != null && Left.Contains(value);
        }else{
            return Right != null && Right.Contains(value);
        }
    }

    public int GetHeight() {
        // TODO Start Problem 4
        int leftHeight = (Left != null) ? Left.GetHeight() : 0;

        // Calculate the height of the right subtree. If Right is null, use 0.
        int rightHeight = (Right != null) ? Right.GetHeight() : 0;

        // The height of the current node is the maximum of the heights of its subtrees, plus 1 for the current node.
        return Math.Max(leftHeight, rightHeight) + 1;
         // Replace this line with the correct return statement(s)
    }
}