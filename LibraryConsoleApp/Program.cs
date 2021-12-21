using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //**1**
            string[] nameArray = new string[] { "matan", "lior", "avi", "ermi", "haim", "marcos", "asci" };

            var filterName = (from name in nameArray where name.ToLower()[0]=='e' select name).ToList();


            //foreach (var name in filterName)
            //{
            //    Console.WriteLine(name);
            //}


            //**2**

            Random rand = new Random();
            
            int [] ages=new int[10];

           for (int i = 0; i < ages.Length; i++)
            {
                ages[i]= rand.Next(0, 100);
            }

           var filterAge=(from age in ages where age>20 select age).ToList();

            //foreach(var age in filterAge)
            //{
            //    Console.WriteLine(age);
            //}



            //**4**

            Random random = new Random();

            Book[] bookArray = new Book[] { new Book("boby", "cod", random.Next(500)), new Book("hobit", "cod", random.Next(500)), new Book("matan", "cod", random.Next(500)), new Book("ermiy", "cod", random.Next(500)) , new Book("avi", "rrr", random.Next(500)), new Book("yosi", "gad", random.Next(500)) };

            //**5**
            var BookOver200=(from book in bookArray where book.numOfPages>200 select book).ToList();

            //foreach(Book book in BookOver200)
            //{
            //    Console.WriteLine(book.name);
            //}
            //**6**
            var autothorNameOver4=(from book in bookArray where book.autothor.Length>4 select book).ToList();

            //foreach (Book book in autothorNameOver4)
            //{
            //    Console.WriteLine(book.name);
            //}
            //**7**

            List<Book> over150Pages=bookArray.Where(book=>book.numOfPages<150).ToList();

          Book firstBook=over150Pages.Find(item => item.numOfPages <150);

         
                Console.WriteLine(firstBook.name);
            

            //**8***\


            List<Book> bookEndY = bookArray.Where(book => book.name.ToLower()[book.name.Length- 1] == 'y').ToList();

            foreach (Book book in bookEndY)
            {
                Console.WriteLine(book.name);
            }




            //**9**

            
            
            List <Book> booksList=new List<Book>()  { new Book("boby", "cod", random.Next(500)), new Book("hobit", "cod", random.Next(500)), new Book("matan", "cod", random.Next(500)), new Book("ermiy", "cod", random.Next(500)), new Book("avi", "rrr", random.Next(500)), new Book("yosi", "gad", random.Next(500)) };


            var filterBookList = (from book in booksList group book by book.autothor);

            foreach(var group in filterBookList)
            {
                Console.WriteLine($"group name:{group.Key}");
                foreach(Book book in group)
                {
                    Console.WriteLine($"{book.name} {book.autothor} {book.numOfPages}");
                }
            }






            //**10**


            var filterBookList2 = (from book in booksList group book by book.autothor);

            foreach (var group in filterBookList2)
            {
                Console.WriteLine($"group name:{group.Key}");
                foreach (Book book in group)
                {
                    Console.WriteLine(book.name);
                }
            }




        }






        
    }
}
