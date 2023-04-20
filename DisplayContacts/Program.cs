// See https://aka.ms/new-console-template for more information
using MyPortfolio;

Console.WriteLine("Welcome to Display Contacts!");
Mongodb db = new Mongodb();

var contacts = await db.GetAllContacts();

foreach (var contact in contacts)
{
    Console.WriteLine(contact.Name);
    Console.WriteLine(contact.Email);
}
