// See https://aka.ms/new-console-template for more information
/*
//Starting with .NET 6, new C# projects using the console template generate different code than previous versions.
//The new output uses recent C# features that simplify the code you need to write for a program. Traditionally, 
//the console app template generated the following code.
//These two forms represent the same program. Both are valid with C# 10.0. When you use the newer version, you only 
//need to write the body of the Main method. You don't need to include the other program elements. You have two options 
//to work with existing tutorials:
//Use the new program style, adding new top-level statements as you add features.
//Convert the new program style to the older style, with a Program class and a Main method.
*/
/*
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/
// Console.WriteLine("Hello, World!");
/*
Console.WriteLine("");
Console.WriteLine("--------------");
Console.WriteLine("Type and excute the following commands (don't type $) in a terminal window in your chosen solution folder:");
Console.WriteLine("Create a new solution named 'mysln': $ dotnet new sln -n mysln");
Console.WriteLine("Create a new console app, output to be saved in the 'myapp' folder:$ dotnet new console -o myapp");
Console.WriteLine("By default new app name will be same as the folder name if no name is supplied.");
Console.WriteLine("Create a new class library, output to be saved in the 'mylib' folder:$ dotnet new classlib -o mylib");
Console.WriteLine("Create a 2nd class library named 'my2ndlib', output to be saved in the 'mylib2' folder:$ dotnet new classlib -n mylib2 -o my2ndlib");
Console.WriteLine("Add the console app to the solution: $ dotnet sln mysln.sln add myapp/myapp.csproj");
Console.WriteLine("Add the class library to the solution: $ dotnet sln mysln.sln add mylib/mylib.csproj");
Console.WriteLine("Add the 2nd class library to the solution: $ dotnet sln mysln.sln add my2ndlib/mylib2.csproj");
Console.WriteLine("Check the contents of the solution: $ dotnet sln mysln.sln list");
Console.WriteLine("Open the solution in VS Code from your solution folder: $ code .");
Console.WriteLine("In vscode press Ctrl + ` (bactick) to bring the command line window.");
Console.WriteLine("Now go to the 'myapp' folder from with VS Code using command line window and build the app: $ dotnet build");
Console.WriteLine("If you just run the app directly, it will first build before it runs the app and display any build error.");
Console.WriteLine("Now from the 'myapp' run the app: $ dotnet run");
Console.WriteLine("--------------");
Console.WriteLine("");
*/
using System; //Not necessary for C# 10.0.

namespace myapp {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("");
            Console.WriteLine("--------------");
            Console.WriteLine("Type and excute the following commands (don't type $) in a terminal window in your chosen solution folder:");
            Console.WriteLine("Create a new solution named 'mysln': $ dotnet new sln -n mysln");
            Console.WriteLine("Create a new console app, output to be saved in the 'myapp' folder:$ dotnet new console -o myapp");
            Console.WriteLine("By default new app name will be same as the folder name if no name is supplied.");
            Console.WriteLine("Create a new class library, output to be saved in the 'mylib' folder:$ dotnet new classlib -o mylib");
            Console.WriteLine("Create a 2nd class library named 'my2ndlib', output to be saved in the 'mylib2' folder:$ dotnet new classlib -n mylib2 -o my2ndlib");
            Console.WriteLine("Add the console app to the solution: $ dotnet sln mysln.sln add myapp/myapp.csproj");
            Console.WriteLine("Add the class library to the solution: $ dotnet sln mysln.sln add mylib/mylib.csproj");
            Console.WriteLine("Add the 2nd class library to the solution: $ dotnet sln mysln.sln add my2ndlib/mylib2.csproj");
            Console.WriteLine("Check the contents of the solution: $ dotnet sln mysln.sln list");
            Console.WriteLine("Open the solution in VS Code from your solution folder: $ code .");
            Console.WriteLine("In vscode press Ctrl + ` (bactick) to bring the command line window.");
            Console.WriteLine("Now go to the 'myapp' folder from with VS Code using command line window and build the app: $ dotnet build");
            Console.WriteLine("If you just run the app directly, it will first build before it runs the app and display any build error.");
            Console.WriteLine("Now from the 'myapp' run the app: $ dotnet run");
            Console.WriteLine("--------------");
            Console.WriteLine("");
        }
    }
}