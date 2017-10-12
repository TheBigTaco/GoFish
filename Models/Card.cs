using System;
using System.Collections.Generic;
// using System.Random;

namespace GoFish.Models
{
  public class Card
  {
    private static List<string> _suits = new List<string> {"Hearts", "Diamonds", "Spades", "Clubs"};

    private static List<string> _rank = new List<string> {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};

    private static List<Card> _deck = new List<Card>{};

    private static List<Card> _playerOne = new List<Card>{};

    public string Suit { get; set; }
    public string Rank { get; set; }
    private static Random _randomCard = new Random();

    public Card (string suit, string rank)
    {
      Suit = suit;
      Rank = rank;
    }

    public static void DeckGenerator()
    {
      for (int i = 0; i < 4; i++)
      {
        for (int j = 0; j < 13; j++)
        {
          _deck.Add(new Card(_suits[i], _rank[j]));
        }
      }
    }

    public static List<Card> DrawHand()
    {
      for (int i = 0; i < 5; i++)
      {
        int card = _randomCard.Next(0, _deck.Count);
        _playerOne.Add(_deck[card]);
        _deck.RemoveAt(card);
      }
      Console.WriteLine(_deck.Count);
      return _playerOne;
    }
  }
}
