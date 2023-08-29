ChestState currentState = ChestState.Locked;

while (true)
{
    Console.Write($"The chest is {currentState}. What do you want to do? ");
    string command = Console.ReadLine();
    
    if (command == "lock" && currentState == ChestState.Closed) currentState = ChestState.Locked;
    if (command == "unlock" && currentState == ChestState.Locked) currentState = ChestState.Closed;
    if (command == "open" && currentState == ChestState.Closed) currentState = ChestState.Open;
    if (command == "close" && currentState == ChestState.Open) currentState = ChestState.Closed;

}

enum ChestState
{
    Open,
    Closed,
    Locked
}