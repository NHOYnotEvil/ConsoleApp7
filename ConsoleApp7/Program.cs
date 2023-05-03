namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesInAlbum = 52;
            int maximumPicturesInSeries = 3;
            int fullyFilledSerises = picturesInAlbum / maximumPicturesInSeries;
            int incompleteSeries = picturesInAlbum % maximumPicturesInSeries;
            Console.WriteLine(fullyFilledSerises);
            Console.WriteLine(incompleteSeries);    
        }
    }
}