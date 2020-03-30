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
            //Author author = new Author
            //{
            //    FirstName = "Isaac",
            //    LastName = "Azimov"
            //};

            //AddAuthor(author);
            Console.WriteLine("All authors: ");
            GetAllAuthors();
            Console.WriteLine(new string('-', 50));

            var a = GetAuthorByName1("Isaac");
            Console.WriteLine(a.FirstName + " " + a.LastName);
            Console.WriteLine(new string('-', 50));

            a = GetAuthorById(2);
            Console.WriteLine(a.FirstName + " " + a.LastName);
            Console.WriteLine(new string('-', 50));

            a = GetAuthorById1(1);
            Console.WriteLine(a.FirstName + " " + a.LastName);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Author Strarts LastName K");
            GetAllAuthors("K");

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Author Strarts LastName A");
            GetAllAuthors("A");

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Sort deseending: ");
            GetAllAuthorsSort();           
           
            Console.WriteLine(new string('-', 50));
            GetAuthorByIdFind(1);


            Console.WriteLine("C.RK");
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

        static Author GetAuthorByName1(string fname)
        {
            using (Library_EntityFramEntities db = new Library_EntityFramEntities())
            {
                var author = db.Author.Where((x) =>
                x.FirstName == fname).FirstOrDefault();
                Console.WriteLine("Result search: ");
                return author;
            }
        }

        static Author GetAuthorById(int id)
        {
            using (Library_EntityFramEntities db = new Library_EntityFramEntities())
            {
                var author = (from s in db.Author
                              where s.Id == id
                              select s).Single();
                return author;
            }
        }

        static Author GetAuthorById1(int id)
        {
            using (Library_EntityFramEntities db = new
                Library_EntityFramEntities())
            {
                var author = db.Author.Where((x) =>
                x.Id == id).SingleOrDefault();
                return author;
            }
        }

        static void GetAllAuthors(string c)
        {

            using (Library_EntityFramEntities db =
                new Library_EntityFramEntities())
            {
                var au = db.Author.Where((x) =>
                x.LastName.StartsWith(c)).ToList();
                foreach(var a in au)
                {
                    Console.WriteLine(a.FirstName + " " +
                        a.LastName);
                }
            }
        }

        static void GetAllAuthors1(string c)
        {

            using (Library_EntityFramEntities db =
                new Library_EntityFramEntities())
            {
                var au = ( from a in db.Author
                           where a.LastName.StartsWith(c)
                           select a).ToList();                
                foreach (var a in au)
                {
                    Console.WriteLine(a.FirstName + " " +
                        a.LastName);
                }
            }
        }

        static void GetAllAuthorsSort()
        {
            using (Library_EntityFramEntities db = new Library_EntityFramEntities())
            {
                var au = (from a in db.Author 
                          orderby a.LastName descending
                          select a).ToList();
                foreach(var a in au)
                {
                    Console.WriteLine(a.FirstName + " " +
                        a.LastName);
                }
            }
        }

        static Author GetAuthorByIdFind(int id)
        {
            using (Library_EntityFramEntities db = new Library_EntityFramEntities())
            {
                var au = db.Author.Find(id);
                Console.WriteLine(au.FirstName + " " + au.LastName);
                return au;
            }
        }

    }

    

}
