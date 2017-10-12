using System;
using System.Collections.Generic;

namespace GoFish.Models
{
  public class Player
  {
    public int Id { get; set; }
    private static Random _randomGame = new Random();
    private List<Game> _hand = new List<Game>{};
    private static List<Player> _players = new List<Player>{};

    public Player(int id)
    {
      for (int i = 0; i < 5; i++)
      {
        List<Game> deck = Game.GetDeck();
        int card = _randomGame.Next(0, deck.Count);
        _hand.Add(deck[card]);
        Game.SetDeck(card);
      }
      Id = id;
      _players.Add(this);
    }

    public static Player Find(int id)
    {
      return _players[id-1];
    }

    public static Random GetRandomGame()
    {
      return _randomGame;
    }

    public List<Game> GetHand()
    {
      return _hand;
    }

  }

}
