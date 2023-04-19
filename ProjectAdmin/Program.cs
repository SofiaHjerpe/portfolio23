// See https://aka.ms/new-console-template for more information

using MyPortfolio;
using MyPortfolio.Models;

Console.WriteLine("Welcome to project admin!");
Console.WriteLine("Create Project: ");
Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Description: ");
string description = Console.ReadLine();

Console.Write("Level 0-10: ");
string input = Console.ReadLine();
int level = int.Parse(input);

Console.Write("Link: ");
string link = Console.ReadLine();


Project newProject = new Project()
{
    Name = name,
    Description = description,
    Level = level,
    Link = link
};

Mongodb db = new Mongodb();
await db.SaveProject(newProject);

var projects = await db.GetAllProjects(); 

foreach (var project in projects)
{
    Console.WriteLine(project.Name);
}


