using System;

namespace Pliczek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two boards - with starting and with current fields


            char[,] startboard =
            {
                {'1','2','3'},
                 {'4','5','6'},
                 {'7','8','9'}
            };

            char[,] gameboard = startboard.Clone() as char[,];

            //Flags

            bool player1Won = false;
            bool player2Won = false;
            bool nextisplayer = true; // true-player 1 move   false-player 2 move


            //loop over rounds

            for(int round =0;round<gameboard.Length;round++)
            {
                Console.Clear();
                // TODO: draw the board   //Do zrobienia //Metody

                if(nextisplayer)
                {
                    //TODO: player 1 move  //Do zrobienia //Metody
                    nextisplayer = false;
                }
                else
                {
                    //TODO: player 2 move  //Do zrobienia //Metody
                    nextisplayer = true;
                }

                if(player1Won || player2Won)
                {
                    break;
                }
            }

            Console.Clear();
            Console.WriteLine("Game ended");































        }
    }
}
