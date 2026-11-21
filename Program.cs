
 using System;
using System.Text;
namespace ConsoleApp1;

class Program
{
    static string[] books =

    {
        "clean code",
        "the pragmatic programmer",
        "refactoring"
    };

    static void Main(string[] args)
    {
        //question 1
        string title = "clean code";
        string uppertitle = title.ToUpper();
        Console.WriteLine(title);
        Console.WriteLine(uppertitle);
        //question 2
        string str1 = "clean code";
        string str2 = "clean code";
        Console.WriteLine(ReferenceEquals(str1,str2));
        //question 3
        StringBuilder sb = new StringBuilder();
        sb.Append("book list");
        sb.Append("updated");;
        Console.WriteLine(sb);
        //question 4
        sb.Replace("book list","library");
        Console.WriteLine(sb);
        //question 5
        string title2 = "clean code";
        int pages = 464;
        string result1 = "book" + title2 + "pages" + pages;
        Console.WriteLine(result1);
        //question 6
        string result2 = $"book{ title2}, pages{ pages}";
        Console.WriteLine(result2);
        //question 7
        string results3 = string.Format("book:{0},pages:{1}", title2, pages);
        Console.WriteLine(results3);
        //question 8
        int pages2 = 464;
        if (pages > 300)
        {
            Console.WriteLine("long book");
        }
        else
        {
            Console.WriteLine("short book");

        }
        //question 9
        bool isavailable = true;
        if (pages > 300 && isavailable == true)
        {
            Console.WriteLine("you can borrow this book");
        }
        //question 10
        string title3 = "refactoring";
        switch (title)
        {
            case "clean code":
                Console.WriteLine("great choice");
                break;
            case "refactoring":
                Console.WriteLine("nice pick");
                break;
            default:
                Console.WriteLine("never heard of it");
                break;

        }
        //question 11
        string sizelable = pages > 300 ? "long book" : "short book";
        Console.WriteLine(sizelable);

        //question 12
        for (int i = 0; i < books.Length; i++)
        {


            Console.WriteLine((i + 1) + "." + books[i]);

        }
        //question 13
        int j = 0;

        while (j < books.Length)
        {

            Console.WriteLine(books[j]);
            j++;


        }
        //question 14
        int count = 0;
        do
        {
            Console.WriteLine("checking book");
            count++;
        }
        while (count < 30);
        //question 15
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }
        //question 16

        foreach (string book in books)
        {
            Console.WriteLine(book);
            if (book == "refactoring")
                

            break;
        }
   
    //question 17
   
    foreach (string book in books)

        
    {
        if (book == "the pragmatic programmer")
      
   continue;

    Console.WriteLine(book);
  } 
        
//question 18
static void PrintFirstBook()
    {
        if (books.Length == 0)
        {

            return;
            

               Console.WriteLine(books[0]);

            
        }
    }

























}

        }
    

