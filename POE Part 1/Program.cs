using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
using System.Media;


namespace POE_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\RC_Student_lab\\Desktop\\Final\\POE-PART-1\\POE Part 1\\MzuraVoice.wav");
            soundPlayer.Load();
            soundPlayer.PlaySync();
            Console.WriteLine("Sound finished playing........");

            Console.WriteLine(FiggleFonts.Standard.Render("Cybersecurity Awareness"));

            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            User user = new User(userName);
            Chatbot chatbot = new Chatbot("Chatbot");
            Dialogue dialogue = new Dialogue(user,chatbot);
            dialogue.StartChat();
            dialogue.EndChat();
        }
    }
}
