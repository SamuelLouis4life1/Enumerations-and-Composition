using System;
using PostAndComment.Entities;

namespace PostAndComment
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip !!!");
            Comment c2 = new Comment("Wow that's awesome !!!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("Good night to all !!!");
            Comment c4 = new Comment("May the force be with you !!!");
            Post p2 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Good night guys",
                "See you all tomorrow !!",
                124);
            p1.AddComment(c3);
            p1.AddComment(c4);

            Console.Write(p1);
            Console.Write(p2);

            Console.ReadLine();
        }
    }
}
