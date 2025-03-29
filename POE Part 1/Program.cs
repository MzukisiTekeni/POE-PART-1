using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            User user = new User(userName);
            Chatbot chatbot = new Chatbot("Chatbot");
            Dialogue dialogue = new Dialogue(user,chatbot);
            dialogue.StartChat();
        }
    }
}
