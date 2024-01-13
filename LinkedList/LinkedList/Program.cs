namespace LinkedList
{
    public class Program
    {
        public static void Main()
        {
            var lesson1 = new YouTubeVideo(10 , "Datatype" , new TimeSpan(00,43,00));
            var lesson2 = new YouTubeVideo(10 , "Datatype" , new TimeSpan(00,43,00));
            var lesson3 = new YouTubeVideo(10 , "Datatype" , new TimeSpan(00,43,00));
            var lesson4 = new YouTubeVideo(10 , "Datatype" , new TimeSpan(00,43,00));
            var lesson5 = new YouTubeVideo(10 , "Datatype" , new TimeSpan(00,43,00));
            var lesson6 = new YouTubeVideo(10 , "Datatype" , new TimeSpan(00,43,00));


            LinkedList<YouTubeVideo> playlist = new LinkedList<YouTubeVideo>(
                new YouTubeVideo[]
                {
                    lesson1, lesson2, lesson3, lesson4, lesson5, lesson6
                });


            Print(playlist);

        }

        static void Print(LinkedList<YouTubeVideo> videos)
        {
            foreach (var video in videos)
            {
                Console.WriteLine(video);
            }
        }

    }

    public class YouTubeVideo
    {
        private int _id; 
        private string _title;
        private TimeSpan _duration;

        public YouTubeVideo(int id, string title, TimeSpan duration)
        {
            _id = id;
            _title = title;
            _duration = duration;
        }

        public override string ToString()
        {
            return $"|-- {this._title} ({this._duration} \n|\thttps://www.youtube.com/watch?v ) ";
        }
    }
}