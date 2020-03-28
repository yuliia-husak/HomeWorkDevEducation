using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EmtityFram
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author
            {
                FirstName = "Isaac",
                LastName = "Azimov"
            };

            AddAuthor(author);
            GetAllAuthors();

            Console.ReadKey();
        }

        static void AddAuthor(Author author)
        {
            using (Library_EntityFramEntities db = new Library_EntityFramEntities())
            {
                db.Author.Add(author);
                db.SaveChanges();

                Console.WriteLine("New author added: " + author.LastName);
            }
        }

        static void GetAllAuthors()
        {
            using (Library_EntityFramEntities db = new Library_EntityFramEntities())
            {
                var au = db.Author.ToList();
                foreach (var a in au)
                {
                    Console.WriteLine(a.FirstName + " " + a.LastName);
                }
            }
        }

    }

    

}
