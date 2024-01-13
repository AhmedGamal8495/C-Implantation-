using System.Data;

namespace StackApp
{
    public class Program
    {
        public static void Main()
        { 
            Stack<Command> undo = new Stack<Command>();
            Stack<Command> forword = new Stack<Command>();

            string url; 
            while (true)
            {
                url = Console.ReadLine().ToLower();

                if (url == "exsit")
                {
                    break;
                }
                else if (url == "back")
                {
                    if (undo.Count > 0)
                    {
                        var item = undo.Pop();
                        forword.Push(item);

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (url == "undo")
                {
                    if (forword.Count > 0)
                    {
                        var item = forword.Pop();
                        undo.Push(item);

                    }
                    else
                    {
                        continue;
                    }
                }
                else 
                {
                    //add url to undo
                    undo.Push(new Command(url));
                }

                Console.Clear();
                Print("Undo", undo);
                Print("Back", forword);


            }



        }

        public static void Print(string name , Stack<Command> commands)
        {
            Console.WriteLine($"{name} history");
            Console.BackgroundColor = 
                name.ToLower() == "back"?ConsoleColor.DarkBlue : ConsoleColor.DarkGreen;

            foreach (var item in commands)
            { 
                Console.WriteLine($"\t{item}"); 
            }

            Console.BackgroundColor= ConsoleColor.Black;
        
        }

    }

    public class Command 
    {
        private readonly string _url; 
        private readonly DateTime _createdAt;

        public Command(string url)
        {
            _url = url;
            _createdAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{this._createdAt.ToString("yyyy-MM-dd")}] {this._url}";
        }
    }
}