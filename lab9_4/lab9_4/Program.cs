using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
namespace lab9_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            StringBuilder htmlText = new StringBuilder();//creating a new stringBuilder object htmltext
            string headOpen = "<head>";
            string titleopen = "<title>";
            string titleclose = "</title>";
            string headClose = "</head>";
            string bodyOpen = "<body bgcolor=red>";
            string bodyClose = "</body>";
            string hOpen = "<h1 color = red>";
            string hClose = "</h1>";

            Console.WriteLine("Enter Text For Html Header :");
            string htmltitle = Console.ReadLine();
            string listOpen = "<ul>";
            string listClose = "</ul>";
            string liOpen = "<li>";

            Console.WriteLine("Add another item to the list :");
            string litem1 = Console.ReadLine();
            Console.WriteLine("Add another item to the list :");
            string litem2 = Console.ReadLine();
            Console.WriteLine("Add another item to the list :");
            string litem3 = Console.ReadLine();
            string liClose = "</li>";
            string webtitle = "Creaing html using c#";

            //appending the strings
            htmlText.Append(headOpen);//<head>
            htmlText.Append(titleopen);//<title>
            htmlText.Append(webtitle);//first item
            htmlText.Append(titleclose);//</title>
            htmlText.Append(headClose);//</head>
            htmlText.Append(bodyOpen);//<body>
            htmlText.Append(hOpen);//<h1>
            htmlText.Append(htmltitle);//html title
            htmlText.Append(hClose);//</h>
            htmlText.Append(listOpen);//<ul>
            htmlText.Append(liOpen);//<li>
            htmlText.Append(litem1);//first item
            htmlText.Append(liClose);//</li>
            htmlText.Append(liOpen);//<li>
            htmlText.Append(litem2);//second item
            htmlText.Append(liClose);//</li>
            htmlText.Append(liOpen);//<li>
            htmlText.Append(litem3);//last item
            htmlText.Append(liClose);//</li>
            htmlText.Append(listClose);//</ul>
            htmlText.Append(bodyClose);//</body>

            FileWriter newfile = new FileWriter(); //creating a new object to access filewriter class methods 
            newfile.CreateHtml(htmlText);



        }
    }

    class FileWriter
    {
        private const string myhtmlpath = "C:\\weblogs\\lab994.html";
        public void CreateHtml(StringBuilder htmldata)
        {
            File.WriteAllText (myhtmlpath, htmldata.ToString());
        }
    }
    
}
