# C# Essentials
Introduction to C# Languages and .NET Framework. Using Visual Studio Code (VS Code) and Visual Studio Community 2022 IDE (VS IDE).

**Please refer to my PDF files for more details and explanations**

# About C#
C# is a general-purpose, type-safe, object-oriented programming language. 

# CLRs, BCLs, and Runtimes
Runtime consists of:
 - Common Language Runtime (CLR)
 - Basic Class Library

 Application Layer => BCL => CLR

 > Application Layer => ASP.NET, WPF, Xamarin, Maui, etc...
 > BCL and CLR => Lower=level functionality (collections, threading, networking, i/o, json)

# Common Language Runtime (CLR)
Provides essential runtime services such as automatic memory management and exception handling.

C# is called a **managed language** because it compiles source code into managed code, which is represented in **Intermediate Language (IL)**.

> Source Code = Converted To => Managed Code

The container for managed code is called **"assembly"**. An assembly contains not only IL but also type information (metadata). The presence of metadata allows assemblies to reference types in other assemblies without needing additional files.

# Base Class Library (BCL)
A CLR always consists of a **set of assemblies** called a **Base Class Library (BCL)**. A BCL provides core functionality to programmers, such as collections, input/output, text processing, XML/JSON handling, networking, encryption, interop, concurrency, and parallel programming.

# Runtimes
A runtime (also called a framework) which consists of a CLR (with its BCL). Runtime also has an optional application layer which is specific to the type of application that we build like mobile, Web applications, etc.

NOTE:
Notice with a simple Console Application (Command-Line Console App) or any non-UI library, we don't need an application layer.

The following table is just a sample of some application layers:

| Application layer | CLR/BCL         | Application Type    | Platforms
| -----------       | -----------     |-----------------    | --------
| ASP.NET           | .NET 6 / .NET 7 | Web Application     | Windows, MacOS, Linux   
| Windows Desktop   | .NET 6 / .NET 7 | Windows Application | Windows 7, 10, 11

# Assemblies
An assembly is the basic unit of deployment in .NET. It is also the container for all types. When building an executable application in .NET, we end up with two files inside the folder "bin" for binary: 
> The assembly file (.dll) 
> The executable launcher file (.exe) based to the platform we running our application on

# .NET 6
.NET 6 is the long-time support open-source runtime. the .NET 7 has the standard support.

# C# Application:
- Solution File (.sln): The top-level solution file. Each application contains a single solution file. A solution can contain one or more projects, and Visual Studio 2022 creates the solution file to help organize these projects. Read more about [Dotnet sln](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln)
-  C# project file (.csproj): contains the source code and other artifacts for the project, such as graphics images. 
- "obj" folder: contains configuration files and other bits of data that the .NET CLI will use to compile and run the application.
- "bin" folder that contains the two assemblies files plus others

### NOTE: 
Notice that "bin" and "obj" folders are ignored in this repo, we don't need upload them as they can be generated when creating a new project! Just:
- The .cs file(s)
- The .csproj file

# C# Naming:
Some general naming recommendations based on the book "MS Visual C#" by John Sharp:

- Don't start an identifier with an underscore. Although this is legal in C#, it can limit the interoperability of your code with applications built by using other languages, such as Microsoft Visual Basic.

- Don't create identifiers that differ only by case. For example, don't create one variable named myVariable and another named MyVariable for use at the same time because it's too easy to confuse one with the other. Also, defining identifiers that differ only by case can limit the ability to reuse classes in applications developed with other languages that are not case sensitive, such as Visual Basic.

- Start the name with a lowercase letter.

- In a multi-word identifier, start the second and each subsequent word with an uppercase letter. (This is called camelCase notation.)

- Don't use Hungarian notation. (If you are a Microsoft Visual C++ developer, you're probably familiar with Hungarian notation. If you don't know what Hungarian notation is, don't worry about it!)

For example, score, footballTeam, _score, and FootballTeam are all valid variable names, but only the first two are recommended.

- The Microsoft .NET documentation recommends that you preface the name of your interfaces with the capital letter I. 

You can learn more about [.NET Naming Guidelines](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)

# The basic .NET CLI commands:
The commands:
> dotnet new sln 
> dotnet new console -f net6.0 -n Project4Methods                  
> dotnet new gitignore
> dotnet new list
> dotnet run

# Credits, References, and Resources:
- [Microsoft.NET]​(https://dotnet.microsoft.com/en-us/)
- [Microsoft C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Visual Studio 2022 System Requirements]​(https://learn.microsoft.com/en-us/visualstudio/releases/2022/system-requirements#supported-operating-systems)
- [Null safety in C#](https://learn.microsoft.com/en-us/training/modules/csharp-null-safety/)
- [Dotnet Youtube Official Channel]​(https://www.youtube.com/@dotnet)
- [Joe Marini](https://github.com/joemarini): Creative technology leader Partner Developer Relations Manager for Google
- [Tim Corey](https://github.com/TimCorey): Software Development (.NET Specialized) Instructor​
- [Scott Hanselman](https://github.com/shanselman): ASP.NET and Azure Cloud Program Manager, Speaker, Instructor, and Programmer​
- Microsoft Visual C# Step by Step By John Sharp - Published by Microsoft
- C# 10 in a Nutshell By Joseph Albahari - Published by O'Reilly

