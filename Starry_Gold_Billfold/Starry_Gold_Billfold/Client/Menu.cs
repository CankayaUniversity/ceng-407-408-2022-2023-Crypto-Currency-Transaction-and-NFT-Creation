using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Main;
using Models;
using Newtonsoft.Json;
using Utils;

namespace Client
{
    public class Menu
    {

        public static void DisplayMenu()
        {

            MenuScreen();
            GetInputFromUser();

        }

        private static void MenuScreen()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n   UBUDKUS COIN MENU ");
            Console.WriteLine("=========================");
            Console.WriteLine("1. Genesis Block");
            Console.WriteLine("2. Last Block");
            Console.WriteLine("3. Send Coin");
            Console.WriteLine("4. Create Block (mining)");
            Console.WriteLine("5. Check Balance");
            Console.WriteLine("6. Transaction History");
            Console.WriteLine("7. Blockchain Explorer");
            Console.WriteLine("8. Exit");
            Console.WriteLine("=========================");
        }

        private static void GetInputFromUser()
        {
            int selection = 0;
            while (selection != 20)
            {
                switch (selection)
                {
                    case 1:
                        DoGenesisBlock();

                        break;
                    case 2:
                        DoLastBlock();

                        break;

                    case 3:
                        DoSendCoin();

                        break;

                    case 4:

                        DoCreateBlock();

                        break;

                    case 5:
                        DoGetBalance();

                        break;
                    case 6:
                        DoGetTransactionHistory();


                        break;
                    case 7:
                        DoShowBlockchain();

                        break;

                    case 8:
                        DoExit();
                        break;
                }

                // ......

            }
        }

        //....

    }
}