using System.Collections;

internal class Program
{
//    Задание: Реализация интерфейсов IComparable и IComparer
//Описание:

//Создай класс Book, представляющий книгу с такими свойствами, 
//        как Title(название), Author(автор) и Year(год издания). Реализуй интерфейс IComparable<Book> в этом классе,
//        чтобы по умолчанию книги можно было сортировать по названию.Также создай отдельный компаратор BookComparerByYear,
//            реализующий интерфейс IComparer<Book>, для сортировки книг по году издания
    private static void Main(string[] args)
    {
        Book beleberda = new Book("Evil Dead","Rob Zombie",1989);
        Book beleberda2 = new Book("Tom soer", "Kventin Tatantino", 1999);  
        Book beleberda3 = new Book("Don Kixot", "Xer Morzhovui", 1987);
        Book beleberda4 = new Book("Titans", "Bomzh pozornui", 1979);
        Book beleberda5= new Book("Brozers Karamazovi", "Lev Tolstoi", 1981);
        Book beleberda6 = new Book("Fathers and kids", "Some Tyrgenew", 1948);
        List<Book> list = new List<Book> {beleberda,beleberda2,beleberda3,beleberda4,beleberda5,beleberda6 };
        
        foreach (Book book in list)
        {
            Console.WriteLine(book.Title,book.Author,book.Year);
        } 
        list.Sort(new BookCompareYears());
        foreach (var item in list)
        {
            Console.WriteLine(item.Year);
        }
    }
}
class Book

{
    public Book(string title, string author, int year)
        {
        this.Title = title;
        this.Author = author;
        this.Year = year;
        }
  public  string Title;
   public string Author;
   public int Year;


}
class BookCompareYears : IComparer<Book>
{
    public int Compare(Book? x, Book? y)
    {
        //if (x.Year==y.Year) return 0;
       // if(x.Year>y.Year) return -1;
        if(y.Year>x.Year) return 1;
       else if(y.Year<x.Year) return -1;
        else return 0;
       

    }
}

