using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Preparations
{
    class Program
    {
        static void Main(string[] args)
        {
            //called my classes in my mainMethod
            new Voice_() { };
            new Logo_Image() { };
            //called this class that does not have a constructor
            Store_ValidationMethods validate = new Store_ValidationMethods();

            //used the typing effect method to enhance the Bot
            validate.AddBotTypingEffect("************************************************************************\nWelcome to the Cyber Security Awareness Bot (Cyber Sheild) \n************************************************************************", ConsoleColor.Green);

            //used the typing effect method to enhance the Bot
            validate.AddBotTypingEffect("Bot: Hello! I'm here to help you stay safe online.", ConsoleColor.Yellow);

           

            new Store_and_Prompt() { };


           // new Logo_Image() { };
        }
    }
}
