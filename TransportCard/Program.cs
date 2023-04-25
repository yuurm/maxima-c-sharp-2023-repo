

namespace TransportCard
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Array
            
            TransportCard[] cards = new TransportCard[10]; 
            TransportCard cart1 = new TransportCard();
            TransportCard cart2 = new TransportCard();
            cards[0] = cart1;
            cards[1] = cart2;


            TransportCard retrievedCart1 = cards[0];
            TransportCard retrievedCart2 = cards[1];


            TransportCard searchedCard = Array.Find(cards, card => card != null && card.Payment());


            int cardCount1 = cards.Length; 
            cards[0] = null; 
            
            Console.WriteLine(cardCount1);
            
            
            
            //Stack
            
            Stack<TransportCard> cardStack = new Stack<TransportCard>(); 

            
            TransportCard card1 = new TransportCard();
            TransportCard card2 = new TransportCard();
            cardStack.Push(card1);
            cardStack.Push(card2);

            
            TransportCard retrievedCard1 = cardStack.Pop();
            TransportCard retrievedCard2 = cardStack.Pop();

            Console.WriteLine("Retrieved Card 1: " + retrievedCard1);
            Console.WriteLine("Retrieved Card 2: " + retrievedCard2);

            
            int cardCount = cardStack.Count; 
            cardStack.Clear(); 

            Console.WriteLine(cardCount);
            
            
            //2D Array
            TransportCard[,] cardSheet = new TransportCard[3, 3]; 
            TransportCard card3 = new TransportCard();
            TransportCard card4 = new TransportCard();
            cardSheet[0, 0] = card3;
            cardSheet[1, 1] = card4;


            TransportCard retrievedCard3 = cardSheet[0, 0];
            TransportCard retrievedCard4 = cardSheet[1, 1];


            TransportCard searchedCard1 = null;
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
            
            
            
            //Dictionary
            Dictionary<string, TransportCard> cardDictionary = new Dictionary<string, TransportCard>(); // Create a dictionary to store TransportCard objects with card numbers as keys

            // Adding cards to the dictionary
            TransportCard card10 = new TransportCard();
            TransportCard card20 = new TransportCard();
            cardDictionary.Add("1", card10);
            cardDictionary.Add("2", card20);

            // Retrieving cards from the dictionary
            TransportCard retrievedCard10;
            if (cardDictionary.TryGetValue("1", out retrievedCard10))
            {
                Console.WriteLine("Retrieved Card 1: " + retrievedCard10);
            }

            // Searching for a card in the dictionary
            string cardNumberToSearch = "1";
            if (cardDictionary.ContainsKey(cardNumberToSearch))
            {
                TransportCard retrievedCard20 = cardDictionary[cardNumberToSearch];
                Console.WriteLine("Retrieved Card 2: " + retrievedCard20);
            }

            // Other basic operations
            int cardCount10 = cardDictionary.Count; // Get the number of cards in the dictionary
            cardDictionary.Remove("1"); // Remove a card from the dictionary by key

            
        }
         
        }
    }

    
