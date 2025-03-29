using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Make Perfect Pancakes", "ChefMaster", 485);
        video1.AddComment(new Comment("BakingFan22", "I tried this recipe and it was amazing!"));
        video1.AddComment(new Comment("CookingNewbie", "How much butter should I use if I double the recipe?"));
        video1.AddComment(new Comment("PancakeLover", "Best pancake tutorial I've found online."));
        videos.Add(video1);

        Video video2 = new Video("Product Review: New Gaming Headset", "TechReviewer", 732);
        video2.AddComment(new Comment("Gamer123", "Does it work with PlayStation 5?"));
        video2.AddComment(new Comment("AudiophileGuy", "The sound quality is much better than I expected."));
        video2.AddComment(new Comment("HeadsetShopper", "Is the microphone detachable?"));
        video2.AddComment(new Comment("GamerGirl", "I bought this last week and love it!"));
        videos.Add(video2);

        Video video3 = new Video("5-Minute Morning Workout Routine", "FitLifeCoach", 312);
        video3.AddComment(new Comment("ExerciseFan", "Do you recommend doing this every day?"));
        video3.AddComment(new Comment("NewToFitness", "This is perfect for beginners like me!"));
        video3.AddComment(new Comment("EarlyBird", "I've been doing this for a month and see great results."));
        videos.Add(video3);

        Video video4 = new Video("Crocheting an Oversized Unicorn", "Yarn-Woman", 1638);
        video4.AddComment(new Comment("Pencil Woman", "That is a fat unicorn."));
        video4.AddComment(new Comment("Magic_Woman", "There's enough fluff there to give your cat a run for the money, ngl"));
        video4.AddComment(new Comment("BobJoe", "Did you skadoodole the skadoodler"));
        videos.Add(video4);

        Console.WriteLine("YouTube Video Analysis Report\n");

        foreach (Video video in videos)
        {
            video.FormatedVideoInfo();
        }

    }
}