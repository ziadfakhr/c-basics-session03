using System.Threading.Channels;

namespace C__Basics_Session03
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region question 1 
            int Pages = 464; 

            if (Pages > 300)
            {
                Console.WriteLine("long book");
            }
            else
            {
                Console.WriteLine("short book");
            }
            #endregion
            // ##############################
            #region question 2
            bool isAvailable = true;
            if (Pages > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }
            else
            {
                Console.WriteLine("not available");
            }

            #endregion
            // ###############################

            #region question 3 
            string title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default: Console.WriteLine("Never heard of it");
                    break;
                    
            }

            #endregion
            // #################################

            #region question 4 

            string sizeLabel = Pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion

            //###################################

            #region question 5 

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int i = 0;
            for ( i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i+1} : {books[i]}");
            }

            #endregion

            //###################################
            #region question 6
            
            while ( i < books.Length)
            {
                Console.WriteLine(books[i]);
                i++;
            }
            #endregion

            //#####################################
            #region question 7
            int Count = 0;
            do
            {           
                Console.WriteLine("checking books ...");
                Count ++;

            } while (Count < 3);
            #endregion

            //######################################

            #region question 8
            foreach ( var book in books )
            {
                Console.WriteLine(book);
            }
            #endregion

            //######################################

            #region question 9
            for (i = 0; i < books.Length; i++)
            {

                if ( books[i] == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(books[i]);
            }
            #endregion

            //#######################################
            #region question 10 
            for (i = 0; i < books.Length; i++)
            {

                if (books[i] == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(books[i]);
            }
            #endregion

            //#########################################
            #region question 11
            static void PrintFirstBook()
            {
                string[] books = { "Clean Code", "Refactoring" };
                if (books.Length == 0)
                {
                    return;
                }

                Console.WriteLine(books[0]);
            }
           PrintFirstBook();
            #endregion

        }
    }
}
