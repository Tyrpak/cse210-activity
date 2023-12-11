using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        // Video 1 - https://www.youtube.com/watch?v=WmsDDuSYWFo
        Video video1 = new Video("Seeing what people offer for OG hyperyellow 4", "Konrad", 100);

        Comment video1Comment1 = new Comment("dakshprasad9653", "Hey ill give u thrusters, void and beam. Do u have discord?");
        Comment video1Comment2 = new Comment("Paweek-bw1wv", "congrats for lvl4 yellow");
        Comment video1Comment3 = new Comment("lewix3816", "How long did it take you to get up to lvl 4?");
        Comment video1Comment4 = new Comment("user-qs7my1ob3j", "How much is diamond 4 worth?");

        video1.ListComments(video1Comment1);
        video1.ListComments(video1Comment2);
        video1.ListComments(video1Comment3);
        video1.ListComments(video1Comment4);

        videoList.Add(video1);

        // Video 2 - https://www.youtube.com/watch?v=TBhN27rCk80
        Video video2 = new Video("Squirrels vs Cops in Jailbreak", "JailbreakMKG", 198);

        Comment video2Comment1 = new Comment("Konrad", "This is my first video like this so dont worry I'll get better by time.");
        Comment video2Comment2 = new Comment("TrippboyplayzYT", "Dw bro you did fine, but as A creator, I would cut back on the memes, like the run one. Old memes kinda get annoying and that would mean less viewers.");
        Comment video2Comment3 = new Comment("Konrad", "ok thank you");

        video2.ListComments(video2Comment1);
        video2.ListComments(video2Comment2);
        video2.ListComments(video2Comment3);

        videoList.Add(video2);

        // Video 3 - https://www.youtube.com/watch?v=Vzhu_UICQao
        Video video3 = new Video("Jailbreak trading montage INSANE TRADES", "Konrad", 46);

        Comment video3Comment1 = new Comment("MonkeCYX", "That trade for jav was the biggest w ever");
        Comment video3Comment2 = new Comment("Milek_polish_guy", "I got 18mil offer for brulee xd");
        Comment video3Comment3 = new Comment("cryzz2695", "This is Ronaldo from jailbreak busted you in bank once sorry");

        video3.ListComments(video3Comment1);
        video3.ListComments(video3Comment2);
        video3.ListComments(video3Comment3);

        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            video.DisplayVideo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}