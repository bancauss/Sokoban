﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class InputView
    {

        public int input
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void showView()
        {
            System.Console.WriteLine(" _______________________________________________________");
            System.Console.WriteLine("|                                                       |");
            System.Console.WriteLine("|   Welkom bij Sokoban                                  |");
            System.Console.WriteLine("|                                                       |");
            System.Console.WriteLine("| Betekenis van symbolen     |   Doel van het spel      |");
            System.Console.WriteLine("|                            |                          |");
            System.Console.WriteLine("| spatie : outerspace        |   Duw met de truck       |");
            System.Console.WriteLine("|      W : muur              |   de krat(ten)           |");
            System.Console.WriteLine("|      * : vloer             |   naar de bestemming     |");
            System.Console.WriteLine("|      O : krat              |                          |");
            System.Console.WriteLine("|      o : krat op bestemming|                          |");
            System.Console.WriteLine("|      X : bestemming        |                          |");
            System.Console.WriteLine("|      @ : truck             |                          |");
            System.Console.WriteLine("|_______________________________________________________|");
            Console.WriteLine("");
     
        }
    }
}
