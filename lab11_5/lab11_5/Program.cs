using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace lab11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is me learning how to connect and insert to a DB
            /*   Console.WriteLine("Hello to DB!");
               SakilaContext context1 = new SakilaContext();
               Actor[] actors = context1.Actor.ToArray();
               foreach (Actor a in actors)
               {
                   Console.WriteLine(a.first_name + " " + a.last_name);
               }
               Console.WriteLine("Enter the First Name");
               string first_name = Console.ReadLine();
               Console.WriteLine("Enter the Last Name");
               string lastt_name = Console.ReadLine();
               Actor newRecord = new Actor(first_name, lastt_name);

               context1.Actor.Add(newRecord);
               context1.SaveChanges(); 
            SakilaContext connection = new SakilaContext();
            Film[] films = connection.Film.ToArray();
            foreach (Film a in films)
            {
                Console.WriteLine(a.film_id + " " + a.description+" "+a.language_id+ " "+ a.last_update+ " "+ a.length+ " "+ a.original_language_id+ " "+ a.rating + " "+ a.release_year + " "+ a.rental_duration + " "+ a.rental_rate + " "+ a.replacement_cost + " "+ a.special_features + " " + a.title );
            }*/

            SakilaContext sakila = new SakilaContext();
            Film war1917 = new Film("1917", "2019 War Drama By Director Sam Mendes", "2019", 3, 5.99m, 179, 19.99m, "R");
            Film joker = new Film("Joker", "Oscar-Nominated SuperHero Drama", "2019", 3, 6.99m, 182, 23.99m, "R");
            Film jarjarAbrams = new Film("Star Wars: The Rise of SkyWalker", "Trash Disney Fanfic", "2019", 3, 4.99m, 202, 21.99m, "PG-13");

            sakila.Film.Add(war1917);  //uncomment these lines to insert the film
            sakila.Film.Add(joker);  // uncomment these lines to insert the film
            sakila.Film.Add(jarjarAbrams); //uncomment these lines to insert the film
            sakila.SaveChanges();
            //Get All Films from the Sakila DB


            Film[] allfilms = sakila.Film.ToArray();
            //Film[] allfilms = (from db in sakila.Film
            //                   select new Film(db.title, db.description, db.release_year, db.rental_duration, db.rental_rate, db.length, db.replacement_cost, db.rating)).ToArray();

            //Filter to get the new 2019 films you added
            var newfilms = allfilms.Where(x => x.release_year == "2019");

            StringBuilder html = new StringBuilder();
            html.Append("<html>\n");
            html.Append("  <head>");
            html.Append("    <title>Sakila New Films</title>\n");
            html.Append("  </head>\n");
            html.Append("  <body\n");
            html.Append("    <h1> New Films Coming Soon! </h1>\n");
            html.Append("      <ul>\n");
            foreach (var film in newfilms)
            {
                html.Append("<li>");
                html.Append(film.title + " " + film.description);
                html.Append("</li>");
            }


            html.Append("      </ul>\n");
            html.Append("  </body>\n");
            html.Append("</html>\n");

            string htmlFile = "C:\\output\\newfilms.html";
            File.WriteAllText(htmlFile, html.ToString());

        }
    }
}
