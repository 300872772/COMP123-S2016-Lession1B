using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Author: Md Mamunur Rahman
 * Date: May 13, 2016
 * Student ID: 300872772 
 * 
 * Description: This program demostrait GitHub and Version control
 * best practice. We also explore Unit Testing
 * 
 * Version: 0.1 - Added GetUserName Method
 */




namespace COMP123_S2016_Lession1B
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserName();

        }


        //YUI DOC

        /**
         * This method reads the UserName from the console
         * @method GetUserName
         * @retun {string} UserName 
         * */

        public static string GetUserName()
        {
            //initialise variables
            string UserName = "";

            Console.WriteLine("Enter Username: ");
            UserName=Console.ReadLine();

            Console.WriteLine("/n========================");
            Console.WriteLine("You Entered: " + UserName);

            return UserName;
        }
    }
}
