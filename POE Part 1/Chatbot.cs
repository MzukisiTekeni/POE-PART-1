using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part_1
{
    internal class Chatbot
    {
        public string Name { get; set; }

        public Chatbot(string Name)
        {
            this.Name = Name; 
        }
       public string Respond(string UserMessage, User newUser)
       {
            if (string.IsNullOrWhiteSpace(UserMessage))
                return "I didn't catch that. could you repeat?";

            UserMessage = UserMessage.ToLower();

            if (UserMessage.Contains("hello") || UserMessage.Contains("hi"))
            {
                return "Hello! " + newUser.Name + " How can i assist you today?";
            }
            else if (UserMessage.Contains("how are you?"))
            {
                return "I'm just a bot " + newUser.Name + ", but i'm doing great! what about you?";
            }
            else if(UserMessage.Contains("fine")|| UserMessage.Contains("good")|| UserMessage.Contains("okay"))
            {
                return "How can i assist you today? " + newUser.Name;
            }
            else if (UserMessage.Contains("bye"))
            {
                return "Goodbye " + newUser.Name + "Have a great day!";
            }
            else 
            {
                return "Im not sure i Understand. Can you paraphrase";
            }
       }
    }
}
