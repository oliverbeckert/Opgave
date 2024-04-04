using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmopgave.DataAccess
{
    public class DAFileReader
    {
        public DAFileReader() { }
        public string[] GetAllLinesFromFile()
        {
            string filepath = "C:\\Users\\45418\\Downloads\\TopratedRelations.csv";
            return File.ReadAllLines(filepath);
        }




        public void GG()
        {
            string[] lines = GetAllLinesFromFile();

            List<string> movies = new List<string>();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                try
                {

                    string[] columns = line.Split(";");
                    double VoteAverage = double.Parse(columns[2]);
                    string OriginalLanguage = columns[4];



                    if (columns.Length == 5)
                    {

                        movies.Add(line);


                    }


                }
                catch (Exception ex)
                {


                    Console.WriteLine($"Ugyldig dataform i linje: {line} {ex.Message}");


                }
            }

            Console.WriteLine("Movies:");
            foreach (string movie in movies)
            {
                string[] columns = movie.Split(";");
                Console.WriteLine($"Title: {columns[0]}");
                Console.WriteLine($"Overview: {columns[1]}");
                Console.WriteLine($"Rating: {columns[2]}");
                Console.WriteLine($"Release Date: {columns[3]}");
                Console.WriteLine($"Language: {columns[4]}");
                Console.WriteLine();
            }
        }
    }
}
