using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

public class SayaTubeUser
{
	public int id;
	private List<SayaTubeVideo> uploadedVideos;
	public string Username;

	public SayaTubeUser(string username)
	{
		Random rn = new Random();
		this.Username = username;

		this.id = rn.Next();
		this.uploadedVideos = new List<SayaTubeVideo>();
	}

	public int GetTotalVideoPlayCount()
	{
		int total = 0;
		foreach (SayaTubeVideo video in uploadedVideos)
		{
			total += video.GetPlayCount();
		}
		return total;
	}

	public void AddVideo(SayaTubeVideo video)
	{
		Debug.Assert(video != null);
		Debug.Assert(video.GetPlayCount() < 1000000000000);
		this.uploadedVideos.Add(video);
	}

	public void PrintAllVideoPlayCount()
	{
		Console.WriteLine("USER: " + this.Username);
		for (int i = 0; i < GetTotalVideoPlayCount(); i++)
		{

			Console.WriteLine("Video " + (i + 1) + "Judul: " + uploadedVideos[i] + "count" + uploadedVideos[i].GetPlayCount);

		}
	}
}


