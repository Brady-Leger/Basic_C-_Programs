﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new BlackJack();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Brady";
            game = game + player;
            game = game - player;

            Deck deck = new Deck();
            deck.Shuffle(3);
            
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
       

    }
}
