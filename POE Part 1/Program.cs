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
            Console.WriteLine(@"
 _____       _                                        _ _            ___                                             
/  __ \     | |                                      (_) |          / _ \                                            
| /  \/_   _| |__   ___ _ __ ___  ___  ___ _   _ _ __ _| |_ _   _  / /_\ \_      ____ _ _ __ ___ _ __   ___  ___ ___ 
| |   | | | | '_ \ / _ \ '__/ __|/ _ \/ __| | | | '__| | __| | | | |  _  \ \ /\ / / _` | '__/ _ \ '_ \ / _ \/ __/ __|
| \__/\ |_| | |_) |  __/ |  \__ \  __/ (__| |_| | |  | | |_| |_| | | | | |\ V  V / (_| | | |  __/ | | |  __/\__ \__ \
 \____/\__, |_.__/ \___|_|  |___/\___|\___|\__,_|_|  |_|\__|\__, | \_| |_/ \_/\_/ \__,_|_|  \___|_| |_|\___||___/___/
        __/ |                                                __/ |                                                   
       |___/                                                |___/                                                    
");
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            User user = new User(userName);
            Chatbot chatbot = new Chatbot("Chatbot");
            Dialogue dialogue = new Dialogue(user,chatbot);
            dialogue.StartChat();
        }
    }
}
