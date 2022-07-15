using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAccount
{
    public class Logic
    {
        public static void catch_All_Logic()
        {
            //!=======================
            bool isValid_1;
            int Input_1;
            //!=======================
            do
            {//todo==============================================================
                //!=======================
                MainMenu.clearScreen();
                MainMenu.catch_All();
                Console.WriteLine("task successful, Please select a choice.");
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
            {//?============================= 
                case 1:
                    MainMenu.AccountMenuhandler();
                    break;
                case 2:
                    MainMenu.have_A_goodDay();
                    break;
                default:
                    Console.WriteLine("Out of bounds selection.Please Choose a correct selection");
                    break;
            }//?============================= 
        }
        public static void depositMenu()
        {
            //!=======================
            bool isValid_1;
            int Input_1;
            //!=======================
            do
            {//todo==============================================================
                //!=======================
                MainMenu.clearScreen();
                MainMenu.deposite_Screen();
                Console.WriteLine("Deposit Menu Screen, Please select a choice.");
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
            {//?============================= 
                case 1:
                   Logic.deposit_case1();
                    break;
                case 2:
                    deposit_case2();
                    break;
                case 3:
                    deposit_case3();
                    break;
                case 4:
                    MainMenu.AccountMenuhandler();
                    break;
                default:
                    Console.WriteLine("Out of bounds selection.Please Choose a correct selection");
                    break;
            }//?============================= 
        }
        public static void withdrawMenu()
        {
            //!=======================
            bool isValid_1;
            int Input_1;
            //!=======================
            do
            {//todo==============================================================
                //!=======================
                MainMenu.clearScreen();
                MainMenu.withdraw_Screen();
                Console.WriteLine("WithDraw Menu Screen, Please select a choice.");
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
            {//?============================= 
                case 1:
                    withdraw_case1();
                    break;
                case 2:
                    withdraw_case2();
                    break;
                case 3:
                    withdraw_case3();
                    break;
                case 4:
                    MainMenu.AccountMenuhandler();
                    break;
                default:
                    Console.WriteLine("Out of bounds selection.Please Choose a correct selection");
                    break;
            }//?============================= 
        }
        public static void showBalanceMenu()
        {
            //!=======================
            bool isValid_1;
            int Input_1;
            //!=======================
            do
            {//todo==============================================================
                //!=======================
                MainMenu.clearScreen();
                MainMenu.show_BalanceMenu();
                Console.WriteLine("Balance Menu Screen, Please select a choice.");
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
            {//?============================= 
                case 1:
                    MainMenu.show_BalanceMenu();
                    break;
                case 2:
                    catch_All_Logic();
                    break;
                case 3:
                    
                    break;
                case 4:
                    MainMenu.AccountMenuhandler();
                    break;
                default:
                    Console.WriteLine("Out of bounds selection.Please Choose a correct selection");
                    break;
            }//?============================= 
        }
        public static decimal deposit_case1()
        {
            
            decimal amount = 100;
            catch_All_Logic();
            return amount;
        }
        public static decimal deposit_case2()
        {
            Account account = new Account();
            decimal amount = 500;
            catch_All_Logic();
            return account.CheckingDeposite(amount);
        }
        public static decimal deposit_case3()
        {
            Account account = new Account();
            decimal amount = 1000;
            catch_All_Logic();
            return account.CheckingDeposite(amount);
        }
        public static decimal withdraw_case1()
        {
            Account account = new Account();
            decimal amount = 1000;
            catch_All_Logic();
            return account.CheckingWithDraw(amount);
        }
        public static decimal withdraw_case2()
        {
            Account account = new Account();
            decimal amount = 1000;
            catch_All_Logic();
            return account.CheckingWithDraw(amount);
        }
        public static decimal withdraw_case3()
        {
            Account account = new Account();
            decimal amount = 1000;
            catch_All_Logic();
            return account.CheckingWithDraw(amount);
        }
      /*  public static decimal showBalance()
        {
            
            

            return showBalanceMenu();

        }*/
    }
}
