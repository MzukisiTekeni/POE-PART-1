using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part_1
{
    internal class Dialogue
    {
        private User user;
        private Chatbot chatbot;

        public Dialogue(User user, Chatbot chatbot)
        {
            this.user = user;
            this.chatbot = chatbot;
        }

        public void StartChat()
        {
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(chatbot.Name + ": ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello " + user.Name + " Welcome to the chatbot");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Chat started");
            Console.WriteLine("Type exit to end the chat!");
            Console.ForegroundColor = ConsoleColor.White;
            
            while (true) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("User: ");
                Console.ForegroundColor = ConsoleColor.White;
                string userMessage = Console.ReadLine();
               
                if (userMessage.ToLower().Equals("exit")) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(chatbot.Name + ": ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Goodbye, "+user.Name);
                    break;
                }
                string response = chatbot.Respond(userMessage,user);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(chatbot.Name+": ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(response);
            }
        }
    }
}
