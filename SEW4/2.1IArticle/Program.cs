using _2._1IArticle;

double totalPrize = 0.0;

Book book1 = new Book(15, "Das Haus");
Book book2 = new Book(17, "Das Auto");

Smartphone phone1 = new Smartphone(445, "Iphone 7");
Smartphone phone2 = new Smartphone(720, "Smasung Galaxy A3");

List<IArticle> articles = new List<IArticle>();

articles.Add(book1);
articles.Add(book2);
articles.Add(phone1);
articles.Add(phone2);


foreach (IArticle article in articles)
{
    article.Price += totalPrize;
}

Console.WriteLine(totalPrize);
