// #nullable enable

using System;

namespace CS8NullBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // #nullable disable
            // string message = null;
            // #nullable enable

            // string? message = null;

            Message message = new Message()
            {
                Text = "Hello there!",
                // Text = null!,
                From = null
            };

            MessagePopulator.Populate(message);

            Console.WriteLine(message.Text);
            Console.WriteLine(message.From ?? "From is not specified.");
            Console.WriteLine(message.From!.Length);
            Console.WriteLine(message.ToUpperFrom());

            Console.WriteLine("Press enter to end!");
            Console.ReadLine();
        }
    }
}
