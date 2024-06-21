public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        
        

        // Test Cases

        // Test 1
        // Scenario: what happens when I add to the queue
        // Expected Result: shout return [Eat Food (Pri:6), Sleep (Pri:3), Breath (Pri:100), homework (Pri:50)]
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Eat Food", 6);
        priorityQueue.Enqueue("Sleep", 3);
        priorityQueue.Enqueue("Breath", 100);
        priorityQueue.Enqueue("homework",50);
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: This is working correctly

        Console.WriteLine("---------");

        // Test 2
        // Scenario: What happens if I dequeue
        // Expected Result: should get Breath
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Eat Food", 6);
        priorityQueue.Enqueue("Sleep", 3);
        priorityQueue.Enqueue("Breath", 100);
        priorityQueue.Enqueue("homework",50);
        var item = priorityQueue.Dequeue();
        Console.WriteLine(item);
        
        // Defect(s) Found: It grabed the most important so it worked

        Console.WriteLine("---------");

        // Test 3
        // Scenario: What happens if I dequeue multiple
        // Expected Result: should get Breath then homework
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Eat Food", 6);
        priorityQueue.Enqueue("Sleep", 3);
        priorityQueue.Enqueue("Breath", 100);
        priorityQueue.Enqueue("homework",50);
        item = priorityQueue.Dequeue();
        var item2 = priorityQueue.Dequeue();
        Console.WriteLine("Item 1 "+ item);
        Console.WriteLine("Item 2 "+ item2);
        Console.WriteLine(priorityQueue);
        
        // Defect(s) Found: I had to remove the highest prioity from the queue

        Console.WriteLine("---------");

        // Test 4
        // Scenario: What happens when I dequeue a empty queue
        // Expected Result: Should get The Queue is Empty
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
       
        priorityQueue.Enqueue("Breath", 100);
        priorityQueue.Enqueue("homework",50);
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        
        // Defect(s) Found: this is working!

        Console.WriteLine("---------");
        
    }
}