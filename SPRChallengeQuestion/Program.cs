using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRChallengeQuestion
{
    public class SPRChallengeQuestion
    {

        static List<string> newList = new List<string>();

        public static void Main()
        {
            List<string> text = new List<string> { "Hey", "Guy's", "Thank", "You", "So", "Much", "For", "Meeting", "With" , "Me.",
                "I'm", "Beyond", "Excited", "That", "I", "Was", "Given", "This", "Oppurtunity!"};
            PrintHandler(text);
        }
        private static void PrintHandler(List<string> message)
        {
            var max = 0;
            foreach (string item in message)
            {
                var current = item.Length;
                if (current > max)
                {
                    max = current;
                }
            }
            TopFrame(max, message, newList);
            StarHandler(max, message, newList);
            BottomFrame(max, newList);

            foreach(string item in newList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static void TopFrame(int max, List<string> message, List<string> newList)
        {
            foreach(string item in message)
            {
                if (newList.Count == 0)
                {
                    var s = "";
                    var starLength = max + 4;
                    for (int i = 0; i < starLength; i++)
                    {
                        s = (s + "*");
                    }
                    newList.Add(s);
                }
                return;
            }

        }

        private static void BottomFrame(int max, List<string> newList)
        {
            var s = "";
            var starLength = max + 4;
            for(int i = 0; i < starLength; i++)
            {
                s = (s + "*");
            }
            newList.Add(s);
        }
        private static void StarHandler(int number, List<string> message, List<string> newList)
        {
            foreach (string item in message)
            {
                var current = item.Length;
                if (current == number)
                {
                    var tempString = ("* " + item + " *");
                    newList.Add(tempString);
                }
                else if (current < number)
                {
                    var n = number - current;
                    var otherString = item;
                    for (int i = 0; i < n; i++)
                    {
                        if (item.Length == current)
                        {
                            otherString = ("* " + otherString);
                            current++;
                        }
                        else if (current <= number)
                        {
                            otherString = (otherString + " ");
                            current++;
                        }
                    }
                    otherString = (otherString + "  *");
                    newList.Add(otherString);
                }
            }
        }
    }

}
