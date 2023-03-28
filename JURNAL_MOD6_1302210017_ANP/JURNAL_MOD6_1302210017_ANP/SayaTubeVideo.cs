using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    public string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Contract.Requires(title.Length < 200);
        Contract.Requires(title != null);
        Contract.Requires(title.Length > 0);
        Random r = new Random();
        this.title = title;
        
    }

    public void IncreasePlayCount(int playCount)
    {
        Contract.Requires(playCount <= 25000000);
        try
        {
            int cek = checked(this.playCount + playCount);
            this.playCount= cek;
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Overflow Exception : "+ ex.Message);
        }
        this.playCount = playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("===Video Details===");

        Console.WriteLine("Video ID\t " + this.id);
        Console.WriteLine("Title\t\t: " + this.title);
        Console.WriteLine("Play Count\t: " + this.playCount);
    }
    public int GetPlayCount()
    {
        return this.playCount;
    }

}
