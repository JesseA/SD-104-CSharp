using System;

namespace Lab_ClassDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("War and Peace",new string[1] { "Leo Tolstoy" },1225);
            Book myBook2=new Book("In Search of Lost Time",new string[1] { "Marcel Proust" },4215);
            Book myBook3 = new Book("Let It Snow", new string[3] { "John Green", "Maureen Johnson", "Lauren Myracle" },352);

            Movie myMovie = new Movie("Tombstone", 134,1993);
            Movie myMovie2 = new Movie("The Shining", 146, 1980);
            Movie myMovie3 = new Movie("Star Wars: A New Hope", 121, 1977);

            Game myGame = new Game("The Legend of Zelda","Nintendo Entertainment System",true);
            Game myGame2 = new Game("Minecraft", "PC", false);
            Game myGame3 = new Game("Halo: Combat Evolved", "X-Box", true);

            Console.WriteLine(myBook);
            Console.WriteLine(myBook2);
            Console.WriteLine(myBook3);
            Console.WriteLine();
            Console.WriteLine(myMovie);
            Console.WriteLine(myMovie2);
            Console.WriteLine(myMovie3);
            Console.WriteLine();
            Console.WriteLine(myGame);
            Console.WriteLine(myGame2);
            Console.WriteLine(myGame3);

            Console.ReadLine();
        }
    }
    class Book
    {
        String strTitle;
        String[] strAuthors;
        int nNumberOfPages;

        public Book(string title, string[] authors, int numberOfPages)
        {
            strTitle = title;
            strAuthors = authors;
            nNumberOfPages = numberOfPages;
        }

        public string Title
        {
            get
            {
                return strTitle;
            }
            set
            {
                strTitle = value;
            }
        }

        public string[] Authors
        {
            get
            {
                return strAuthors;
            }
            set
            {
                strAuthors = value;
            }
        }

        public string AuthorsList
        {
            get
            {
                string authorList = "";
                for (int i = 0; i < strAuthors.Length; i++)
                {
                    if (i == 0)
                    { authorList += strAuthors[i]; }
                    else
                    {
                        authorList += (", " + strAuthors[i]);
                    }
                }
                return authorList;
            }
        }

        public int NumberOfPages
        {
            get
            {
                return nNumberOfPages;
            }
            set
            {
                nNumberOfPages = value;
            }
        }

        public override string ToString()
        {
           
            return "Book Title: '"+Title+"'          Author(s): "+AuthorsList+"    Number of Pages: "+NumberOfPages;
        }

    }
    class Movie
    {
        String strTitle;
        double dRuntime;
        int nYearProduced;

        public Movie(String title, double runtime, int yearproduced)
        {
            strTitle = title;
            dRuntime = runtime;
            nYearProduced = yearproduced;
        }
        public String Title
        {
            get
            {
                return strTitle;
            }
            set
            {
                strTitle = value;
            }
        }

        public Double Runtime
        {
            get
            {
                return dRuntime;
            }
            set
            {
                dRuntime = value;
            }
        }

        public int YearProduced
        {
            get { return nYearProduced; }
            set { nYearProduced = value; }
        }

        public override string ToString()
        { return "Movie Title: '" + Title + "'             Runtime: " + Runtime + " mins    Year Produced: " + YearProduced; }
    }
    class Game
    {
        String strTitle;
        String strGameConsole;
        bool bPartOfASeries;

        public Game(string title,string gameconsole, bool partofseries)
        {
            strTitle = title;
            strGameConsole = gameconsole;
            bPartOfASeries = partofseries;
        }

        public String Title
        {
            get
            {
                return strTitle;
            }
            set
            {
                strTitle = value;
            }
        }

        public String GameConsole
        {
            get
            {
                return strGameConsole;
            }
            set
            {
                strGameConsole = value;
            }
        }

        public bool PartOfASeries
        {
            get { return bPartOfASeries; }
            set { bPartOfASeries = value; }
        }

        public string IsItPartOfSeries
        {
            get { if (bPartOfASeries) { return "Yes"; } else { return "No"; } }
        }

        public override string ToString()
        { return "Game Title: '" + Title + "'    Game Console: " + GameConsole + "    Part of a Series: " + IsItPartOfSeries; }
    }
        
}
