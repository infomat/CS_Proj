﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Program
    {
        static void Main ( string [] args )
        {
            MainHassan();

        }
        static public void MainHassan()
        {
            // this will be static , anyone who wants to test , test below it and add comments 
            //HASSAN TEST HERE
            int numberOfPlayers;

            Console.WriteLine ( "Welcome to MONOPOLY" );
            Console.WriteLine ( "please enter the number of players to start the game" );
            numberOfPlayers = int.Parse ( Console.ReadLine () );

            GameMaster gameMaster = new GameMaster ();
            gameMaster.NumberOfPlayers = numberOfPlayers;

            Console.WriteLine("enter anykey to continue...");
            Console.ReadKey();

        }
        static public void MainJoe()
        {
            //JOE TEST HERE

        }

        static public void MainChang()
        {
            //CHANG TEST HERE


        }
    }
}
