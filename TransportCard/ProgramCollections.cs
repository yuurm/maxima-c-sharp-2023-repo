static void Main(string[] args)
{
    Stack<TransportCard> cardStack = new Stack<TransportCard.TransportCard>(); // Create a stack to store TransportCard objects

    // Adding cards to the stack
    TransportCard card1 = new TransportCard();
    TransportCard card2 = new TransportCard();
    cardStack.Push(card1);
    cardStack.Push(card2);

    // Retrieving cards from the stack
    TransportCard retrievedCard1 = cardStack.Pop();
    TransportCard retrievedCard2 = cardStack.Pop();

    Console.WriteLine("Retrieved Card 1: " + retrievedCard1);
    Console.WriteLine("Retrieved Card 2: " + retrievedCard2);

    // Searching for a card in the stack (not possible with a regular stack as it follows LIFO - Last In, First Out order)

    // Other basic operations
    int cardCount = cardStack.Count; // Get the number of cards in the stack
    cardStack.Clear(); // Remove all cards from the stack

    Console.ReadLine();
}




