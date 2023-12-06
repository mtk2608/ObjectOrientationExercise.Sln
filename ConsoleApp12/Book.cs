using System.Net;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp12;

internal class Book
{
    public int NoOfPages;

    public bool BestSeller;

    public string Cover;

    public string Genre;
    public string ReleaseDate;


    public Book(bool bestseller, int noOfPages,string cover,string genre,string releaseDate)
    {
        BestSeller = bestseller;
        NoOfPages = noOfPages;
        Cover = cover;
        Genre = genre;
        ReleaseDate = releaseDate;
        

    }    

}
