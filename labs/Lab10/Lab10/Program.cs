using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Email a = new Email("This is an email reminding you to pause and take a breath", "Ur brain", "You", "Reminder");
            Email b = new Email("Hello friend I am a deposed Nigerian Prince and I need your help to get back my familial wealth", "Prince", "you", "I need your help");
            File x = new File("./documents/thisdocument", "I have thoughts");
            File y = new File("./photos/adocumentinphotos", "this is a document in the photos folder. Isn't that wild");

            Console.WriteLine(ContainsKeyword(b, "Prince"));
            Console.WriteLine(ContainsKeyword(a, "westley"));
            Console.WriteLine(ContainsKeyword(x, "thoughts"));
            Console.WriteLine(ContainsKeyword(y, "This"));
        }
        public static bool ContainsKeyword(Document docObject, string keyword)

        {

            if (docObject.ToString().IndexOf(keyword, 0) >= 0)

            {

                return true;

            }

            return false;

        }
    }
}
