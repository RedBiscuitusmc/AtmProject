using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAccount
{
    public class MainMenu
    {
        public static void main_Menu()
        {
            clearScreen();
            addSpace();
            Console.WriteLine("Please Choose from one of the following options....");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }
        public static void deposite_Screen()
        {
            clearScreen();
            addSpace();
            Console.WriteLine("Please Choose from one of the following options....");
            Console.WriteLine("1. Deposit $100");
            Console.WriteLine("2. Deposit $500");
            Console.WriteLine("3. Deposit $1000");
            Console.WriteLine("4. Go back to main screen");
            addSpace();
        }
        public static void withdraw_Screen()
        {
            clearScreen();
            addSpace();
            Console.WriteLine("Please Choose from one of the following options....");
            Console.WriteLine("1. Withdraw $100");
            Console.WriteLine("2. Withdraw $500");
            Console.WriteLine("3. Withdraw $1000");
            Console.WriteLine("4. Go back to main screen");
            addSpace();
        }
        public static void show_BalanceMenu()
        {

            Console.WriteLine(Account.CheckingBalance);
            Logic.catch_All_Logic();
        }
        public static void catch_All()
        {
            clearScreen();
            addSpace();
            Console.WriteLine("Your input is completed.");
            Console.WriteLine("1. Go back to main menu.");
            Console.WriteLine("2. To exit program.");
            addSpace();
        }

        public static void have_A_goodDay()
        {
            clearScreen();
            addSpace();
            Console.WriteLine("Thanks for banking with us!");
        }
        public static void addSpace()
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("===============================================================");
            Console.WriteLine("===============================================================");
        }
        public static void clearScreen()
        {
            Console.Clear();
        }
        public static void AccountMenuhandler()
        {
            bool isValid_1;
            int Input_1;

            do
            {//todo==============================================================
             //!=======================
                addSpace();
                main_Menu();
                addSpace();
                Console.WriteLine("Enter a Number.");
                isValid_1 = int.TryParse(Console.ReadLine(), out Input_1);
                //!=======================
                if (!isValid_1)
                {//?============================= 
                    Console.WriteLine("You didn't type a number, Please try again");
                    isValid_1 = false;
                }//?============================= 
            }//todo==============================================================
            while (!isValid_1);

            switch (Input_1)
            {
                case 1:
                   Logic.depositMenu();
                    break;
                case 2:
                    BankAccount.Logic.withdrawMenu();
                    break;
                case 3:
                    BankAccount.Logic.showBalanceMenu();
                    break;
                case 4:
                    have_A_goodDay();
                    break;
                default:
                    Console.WriteLine("Out of bounds selection.Please Choose a correct selection");
                    break;
            }
        }
    }
}

