using System;

public class SayaTubeVideo
{
	private int id;
	private string title;
	private int playCount;

	public SayaTubeVideo(string title)
	{
		Random r = new Random();
		this.title = title; 
		id = r.Next(10000, 99999);
		this.playCount = 0;
	}

	public void IncreasePlayCount(int playCount)
	{
		this.playCount = playCount;
	}

	public void PrintVideoDetails()
	{
		Console.WriteLine("===Video Details===")
		Console.WriteLine("Video ID\t " + this.id);
		Console.WriteLine("Title\t\t: " + this.title);
		Console.WriteLine("Play Count\t: " + this.playCount);
	}

}
