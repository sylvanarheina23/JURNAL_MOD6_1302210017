public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo sayaTubeVideo1 = new SayaTubeVideo("Review Film Danur 1 oleh Sylvana Rheina" );
        SayaTubeVideo sayaTubeVideo2 = new SayaTubeVideo("Review Film Danur 2 oleh Sylvana Rheina");
        SayaTubeVideo sayaTubeVideo3 = new SayaTubeVideo("Review Film Kramat oleh Sylvana Rheina");
        SayaTubeVideo sayaTubeVideo4 = new SayaTubeVideo("Review Film The glory 1 oleh Sylvana Rheina");
        SayaTubeVideo sayaTubeVideo5 = new SayaTubeVideo("Review Film Breaking Dawn oleh Sylvana Rheina");
        SayaTubeVideo sayaTubeVideo6 = new SayaTubeVideo("Review Film Breaking Dawn 2 oleh Sylvana Rheina");
        SayaTubeVideo sayaTubeVideo7 = new SayaTubeVideo("Review Film NewMoon oleh Sylvana Rheina");
        SayaTubeVideo sayaTubeVideo8 = new SayaTubeVideo("Review Film Eclipse oleh Sylvana Rheina");
        SayaTubeVideo sayaTubeVideo9 = new SayaTubeVideo("Review Film Cars oleh Sylvana Rheina");
        SayaTubeVideo sayaTubeVideo10 = new SayaTubeVideo("Review Film Cloy oleh Sylvana Rheina");

        sayaTubeVideo1.IncreasePlayCount(2);
        sayaTubeVideo1.PrintVideoDetails();

        sayaTubeVideo2.IncreasePlayCount(2);
        sayaTubeVideo2.PrintVideoDetails();

        sayaTubeVideo3.IncreasePlayCount(2);
        sayaTubeVideo3.PrintVideoDetails();

        sayaTubeVideo4.IncreasePlayCount(2);
        sayaTubeVideo4.PrintVideoDetails();

        sayaTubeVideo5.IncreasePlayCount(2);
        sayaTubeVideo5.PrintVideoDetails();

        sayaTubeVideo6.IncreasePlayCount(2);
        sayaTubeVideo6.PrintVideoDetails();

        sayaTubeVideo7.IncreasePlayCount(2);
        sayaTubeVideo7.PrintVideoDetails();

        sayaTubeVideo8.IncreasePlayCount(2);
        sayaTubeVideo8.PrintVideoDetails();

        sayaTubeVideo9.IncreasePlayCount(2);
        sayaTubeVideo9.PrintVideoDetails();

        sayaTubeVideo10.IncreasePlayCount(2);
        sayaTubeVideo10.PrintVideoDetails();

        Console.WriteLine();
        SayaTubeUser sayaTubeUser1 = new SayaTubeUser("Sylvana Rheina");
        sayaTubeUser1.AddVideo(sayaTubeVideo1);
        sayaTubeUser1.AddVideo(sayaTubeVideo1);
        sayaTubeUser1.AddVideo(sayaTubeVideo1);
        sayaTubeUser1.AddVideo(sayaTubeVideo1);
        sayaTubeUser1.AddVideo(sayaTubeVideo1);
        sayaTubeUser1.AddVideo(sayaTubeVideo1);
        sayaTubeUser1.AddVideo(sayaTubeVideo1);
        sayaTubeUser1.AddVideo(sayaTubeVideo1);
        sayaTubeUser1.AddVideo(sayaTubeVideo1);
        sayaTubeUser1.AddVideo(sayaTubeVideo1);
    }
}