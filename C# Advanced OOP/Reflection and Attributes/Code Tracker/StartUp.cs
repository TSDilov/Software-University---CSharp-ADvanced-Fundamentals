using System;

namespace AuthorProblem
{
    [Author("Dilov")]
    public class StartUp
    {
        [Author("Tsvetelin")]
        public static void Main(string[] args)
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor("Tsvetelin");
        }
    }
}
