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
 * Version: 0.3 - Updated Comments for driver class progam
 */




namespace COMP123_S2016_Lession1B
{
    /**
     * This is the driver class for our program
     * 
     * @class Program
     * 
     * 
     * */



    class Program
    {
        /**
         * Main Method for class program
         * 
         * @parm {String {}} args
         * @contructor Main
         * */


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
