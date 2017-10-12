using System;
using System.Collections.Generic;

namespace GoFish.Models
{
  public class Game
  {
    private static List<string> _suits = new List<string> {"Hearts", "Diamonds", "Spades", "Clubs"};

    private static List<string> _rank = new List<string> {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};

    private static List<Game> _deck = new List<Game>{};

    public string Suit { get; set; }
    public string Rank { get; set; }


    public Game (string suit, string rank)
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
          _deck.Add(new Game(_suits[i], _rank[j]));
        }
      }
    }

    public static List<Game> GetDeck()
    {
      return _deck;
    }
    public static void SetDeck(int card)
    {
      _deck.RemoveAt(card);
    }

    public static void StartGame(int playerCount)
    {
      for (int j = 0; j < playerCount; j++)
      {
        Player player = new Player(j);
      }
      Console.WriteLine(_deck.Count);
    }
  }
}
