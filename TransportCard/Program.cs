// See https://aka.ms/new-console-template for more information

TransportCard.TransportCard card = new TransportCard.TransportCard();

card.TransportCardEvent += message =>
{
    Console.WriteLine(message);
};

card.AddPredicate(balance => balance >= 100);
card.AddCashbackFunc(balance => balance >= 100 ? 10 : 0);
card.AddPaymentHistory(message => Console.WriteLine(message));

card.Replenish(50); // + 50 rub. Current balance: 50
card.Payment(); // Not enough funds on the card
card.Replenish(100); // + 100 rub. Current balance: 150
card.Payment(); // Cashback - 10 rub. Payment of 30 rub successful. Current balance: 120

//Array
{
TransportCard[] cards = new TransportCard[10]; 


TransportCard card1 = new TransportCard();
TransportCard card2 = new TransportCard();
cards[0] = card1;
cards[1] = card2;


TransportCard retrievedCard1 = cards[0];
TransportCard retrievedCard2 = cards[1];


TransportCard searchedCard = Array.Find(cards, card => card != null && card.Payment());


int cardCount = cards.Length; 
cards[0] = null;
}


//2D Array
{

TransportCard[,] cardSheet = new TransportCard[3, 3]; 


TransportCard card1 = new TransportCard();
TransportCard card2 = new TransportCard();
cardSheet[0, 0] = card1;
cardSheet[1, 1] = card2;


TransportCard retrievedCard1 = cardSheet[0, 0];
TransportCard retrievedCard2 = cardSheet[1, 1];


TransportCard searchedCard = null;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (cardSheet[i, j] != null && cardSheet[i, j].Payment())
        {
            searchedCard = cardSheet[i, j];
            break;
        }
    }
}


int numRows = cardSheet.GetLength(0); 
int numColumns = cardSheet.GetLength(1); 
cardSheet[0, 0] = null; 
}

//Stack
{


Stack<TransportCard> cardStack = new Stack<TransportCard>(); 


TransportCard card1 = new TransportCard();
TransportCard card2 = new TransportCard();
cardStack.Push(card1);
cardStack.Push(card2);


TransportCard retrievedCard1 = cardStack.Pop();
TransportCard retrievedCard2 = cardStack.Pop();
}

//Dictionary
{
    Dictionary<string, TransportCard> cardDictionary = new Dictionary<string, TransportCard>();

    TransportCard card1 = new TransportCard("123456789");
    TransportCard card2 = new TransportCard("987654321");
    cardDictionary.Add(card1.CardNumber, card1);
    cardDictionary.Add(card2.CardNumber, card2);


    TransportCard retrievedCard1;
    if (cardDictionary.TryGetValue("123456789", out retrievedCard1))
    {
        Console.WriteLine("Retrieved Card 1: " + retrievedCard1);
    }


    string cardNumberToSearch = "987654321";
    if (cardDictionary.ContainsKey(cardNumberToSearch))
    {
        TransportCard retrievedCard2 = cardDictionary[cardNumberToSearch];
        Console.WriteLine("Retrieved Card 2: " + retrievedCard2);
    }


    int cardCount = cardDictionary.Count;
    cardDictionary.Remove("123456789");
}


