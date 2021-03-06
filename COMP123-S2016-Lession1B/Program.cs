﻿using System;
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
 * Version: 0.6 - Refactor 
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



    public class Program
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

            OutputStringToConsole("Enter UserName: ",true);
            UserName = Console.ReadLine();

            Console.WriteLine("/n========================");
            Console.WriteLine("You Entered: " + UserName);

            return UserName;
        }

        /**
         * This method writes a string to the consol. Parameters allow the user to
         * choose to add a newline charecher
         * @method OutputStringToConsole
         * @param {string} putputString
         * @param {bool} hasNewLine
         * @retun {string} outPutString
         
             */

        public static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
           /* if (hasNewLine)
            {
                Console.WriteLine(outputString);
            }
            else {
                Console.Write(outputString);
            }

            // (hasNewLine==true) ? Console.WriteLine(outputString) : Console.Write(outputString);
            */


            // refactored using the ternary operator

            string suffixString = hasNewLine ? "\n" : "";
            Console.Write(outputString+suffixString);
            return outputString;
        }
    }
}
