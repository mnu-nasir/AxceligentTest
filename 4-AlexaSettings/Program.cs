using System;

namespace _4_AlexaSettings
{
    class Program
    {
        private static void Main(string[] args)
        {
            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk()); //print hello, i am Alexa

            alexa.Configure(x =>
            {
                x.OwnerName = "Bob Marley";
                x.GreetingMessage = $"Hello {x.OwnerName}, I'm at your service";                
            });

            Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service

            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();

        }
    }

    public class Alexa
    {
        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }

        public string Talk()
        {
            if (string.IsNullOrEmpty(GreetingMessage))
            {
                return "hello, i am Alexa";
            }

            return GreetingMessage;
        }   

        public void Configure(Action<Alexa> p)
        {
            p.Invoke(this);
        }
    }
}
