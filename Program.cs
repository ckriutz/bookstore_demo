var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IBookDatabase, InMemoryBookDatabase>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapGet("/hello", () => "Hello World!");

// Lets add some fake books to the database for testing. The books should seem realistic and not just random text.


var bookDatabase = app.Services.GetService<IBookDatabase>();
if (bookDatabase != null)
{
    bookDatabase.AddBook(new Book(0, "The Great Gatsby", "F. Scott Fitzgerald", "Fiction", new DateTime(1925, 4, 10)));
    bookDatabase.AddBook(new Book(0, "To Kill a Mockingbird", "Harper Lee", "Fiction", new DateTime(1960, 7, 11)));
    bookDatabase.AddBook(new Book(0, "1984", "George Orwell", "Dystopian", new DateTime(1949, 6, 8)));
    bookDatabase.AddBook(new Book(0, "Pride and Prejudice", "Jane Austen", "Romance", new DateTime(1813, 1, 28)));
    bookDatabase.AddBook(new Book(0, "The Catcher in the Rye", "J.D. Salinger", "Fiction", new DateTime(1951, 7, 16)));
}


app.Run();
