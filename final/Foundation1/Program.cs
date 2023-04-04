using System;
using System.Collections.Generic;

namespace YouTubeVideos
{




public class Video
{

    public string _title;
    public string _author;
    public int _videoLength;
    // Make sure to initialize the list to a new List before using it.
    public List<Comment> _comments = new List<Comment>();



    public void DisplayVideoInfo()


    {
        Console.WriteLine($"Video Title: {_title} Author: {_author} Video Length: {_videoLength} ");
        Console.WriteLine("Comments:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Comment comment in _comments)
        {
            // This calls the Display method on each Comment
            comment.DisplayCommentInfo();
        }
    }


}




public class Comment
{

		public string _nameOfWhoCommented;
	public string _commentText;
	public void DisplayCommentInfo()
	{
		Console.WriteLine($"Comment by: {_nameOfWhoCommented} Comment text: {_commentText} ");
	}



}








    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");



            //First set of Comments
            Comment commentObject1a = new Comment();
            commentObject1a._nameOfWhoCommented = "Olagoke Amiola";
            commentObject1a._commentText = "Fantastic video. I can watch over and over again!";

            Comment commentObject1b = new Comment();
            commentObject1b._nameOfWhoCommented = "David Cole";
            commentObject1b._commentText = "Wow! I recommend for all to watch!";

            Comment commentObject1c = new Comment();
            commentObject1c._nameOfWhoCommented = "Smith Roy";
            commentObject1c._commentText = "Lovely video";


            //Second set of Comments

            Comment commentObject2a = new Comment();
            commentObject2a._nameOfWhoCommented = "Olagoke Amiola";
            commentObject2a._commentText = "Great video. I can't stop watching!";

            Comment commentObject2b = new Comment();
            commentObject2b._nameOfWhoCommented = "Mike Andrew";
            commentObject2b._commentText = "Great! I recommend for all to watch!";

            Comment commentObject2c = new Comment();
            commentObject2c._nameOfWhoCommented = "Sarah James";
            commentObject2c._commentText = "Fantastic video";


            //Third set of Comments

            Comment commentObject3a = new Comment();
            commentObject3a._nameOfWhoCommented = "Olagoke Amiola";
            commentObject3a._commentText = "Wonderful video. It's an award-winning video!";

            Comment commentObject3b = new Comment();
            commentObject3b._nameOfWhoCommented = "John Davies";
            commentObject3b._commentText = "Awesome! Good thinking! Good product! ";

            Comment commentObject3c = new Comment();
            commentObject3c._nameOfWhoCommented = "Babara Hope";
            commentObject3c._commentText = "Great video";

            //First Video 

            Video videoObject = new Video();
            videoObject._title = "Understanding C#";
            videoObject._author = "Dan Rivo";
            videoObject._videoLength = 60;

            videoObject._comments.Add(commentObject1a);
            videoObject._comments.Add(commentObject1b);
            videoObject._comments.Add(commentObject1c);

            videoObject.DisplayVideoInfo();


            Console.WriteLine("\n");


            //Second Video 

            Video videoObject2 = new Video();
            videoObject2._title = "The Concept of Abstraction in C#";
            videoObject2._author = "Wilson Stone";
            videoObject2._videoLength = 120;

            videoObject2._comments.Add(commentObject2a);
            videoObject2._comments.Add(commentObject2b);
            videoObject2._comments.Add(commentObject2c);

            videoObject2.DisplayVideoInfo();

            Console.WriteLine("\n");

            //Third Video 

            Video videoObject3 = new Video();
            videoObject3._title = "Demystifying Abstration in C#";
            videoObject3._author = "George Witson";
            videoObject3._videoLength = 90;

            videoObject3._comments.Add(commentObject3a);
            videoObject3._comments.Add(commentObject3b);
            videoObject3._comments.Add(commentObject3c);

            videoObject3.DisplayVideoInfo();


        }
    }
}
