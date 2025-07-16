// Stack - First In Last Out

Stack<string> actionStack = new Stack<string>();

actionStack.Push("Action_One"); // The first assigned value will be on the bottom of the Stack, grabbed as the last
actionStack.Push("Action_Two"); // The last assigned vallue will be on the top of the Stack, grabbed as the first

Console.WriteLine(actionStack.Pop()); // Take the value from the top of the Stack (Action_Two)

// Useful for some sort of Undo system, where's the last action is the one to be Undone


// Queue - First In First Out

Queue<string> playerQueue = new Queue<string>();

playerQueue.Enqueue("Player1"); // Add the first element to the queue - it will be the first one to be grabbed out
playerQueue.Enqueue("Player2");
playerQueue.Enqueue("Player3"); // Add the last one - it will be the last one to be grabbed out

Console.WriteLine(playerQueue.Dequeue()); // "Player1" will be dequeued (removed)

// Useful for making Player lists, or wait queue and etc.
