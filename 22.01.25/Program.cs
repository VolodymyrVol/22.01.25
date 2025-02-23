namespace _22._01._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new())
            {
                // создаем два объекта User
                Book book1 = new Book { Name = "Book 1", Author = "Author 1", YearPublished = 2022 };
                Book book2 = new Book { Name = "Book 2", Author = "Author 2", YearPublished = 2021 };

                // добавляем их в бд
                db.Books.Add(book1);
                db.Books.Add(book2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var books = db.Books.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Book u in books)
                {
                    Console.WriteLine($"{u.Id}.{u.Name}, {u.Author} - {u.YearPublished}");
                }
            }
        }
    }
}
