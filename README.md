# **Eau Claire Hair Salon Client and Stylist Tracker**
### This is a web application in order to track Stylists and Clients

 ### _Contributor(s) and Contact Info_
> Logan Roth diamondintheroth@gmail.com - [GitHub(Lo-GR)](https://github.com/Lo-GR)

<br/>

## _Technologies Used_

* **C# 9**
* **.NET 5.0.102**
* **SDK 8.0.19**
* **MS Test**
* **Razor**
* **Bootstrap 4.5**
* **HTML 5 (CS version)/CSS3**
* **My SQL 8.0/WorkBench**
* **Entity Framework**
* **HTML Helper**

## _Concepts Used_

* **MVC**
* **TDD**
* **RESTful Conventions**
* **CRUD Functionality**
* **Database Retrieval/Storage**

## _Description_
This MVC webpage will present it's user with a splash screen and options to 

This is a practice project for practicing C#, Razor, ASP .NET framework, and MVC for a course at Epicodus.

## _Use Guide and Installation_

> Repository: https://github.com/Lo-GR/HairSalon.Solution.git
1. In your terminal of choice or [GitHub's Desktop Application](https://desktop.github.com/) , clone the above repository from Github. For further explanation on how to clone this repository, please visit [GitHub's Documentation](https://docs.github.com/en/github/using-git/which-remote-url-should-i-use).
2. Ensure you are running .NET Core SDK by using the command dotnet --version in your terminal. If a version number is not presented, please visit [this download page for .NET 5 and install the applicable software for your OS](https://dotnet.microsoft.com/download/dotnet/5.0). 
3. Once you verify you are running a .NET 5, navigate in your terminal to PierreBakery2 directory within the PierreBakery2.Solution directory you just cloned. Once there, run "dotnet build" in your terminal to build application within directory. 
4. In your terminal, while still in PierreBakery2 directory, run "dotnet restore" and then "dotnet run." The terminal will present local host routes for you to navigate to in your browser. An example would be "http://localhost:5000." Enter this into a web browser of choice to use this application. Keep the terminal running as it is being used to control the local server.
5. When finished, exit the terminal or use the command "CTRL C"(Windows) or "CMD C"(Mac) to shut down the local server.
6. Open the PierreBakery.Solution directory in a text editor of your choice to view the code.

To engage with testing regarding this application, please read below.

### _Testing Guide_
1. Navigate to the PierreBakery2.Tests directory within your terminal. Once there, run the command "dotnet restore" in order restore the required features for testing.
2. "dotnet test" will test the Models programmed in PierreBakery2.

## _Known Bugs_
* No known bugs at this time. Please contact a contributor to report any bugs found during use.

## _Future Updates_
* Additional UI
* A feature to edit or remove Orders
* A feature to edit or remove Vendors and all associated Orders

## _Preplanning/Whiteboard Work_
```
Expectations___
- User able to see list of all Stylists
- User able to select stylist and see clients belonging to Stylists
- add new stylists to system
- add new clients to specific stylists
- Naming conventions for this project:
  - Production Database: first_last
  - HairSalon as main directory
- Export sql file and commit to top level of solution.
- Include instructions in README about re-creating database.
- README instructions for recreating appsettings.json

Functionality___
- Entity used for communication
- CREATE created for both classes, VIEW created for another
- One to many relationship included
- Typical CRUD and MVC conventions.
- Splash page with links to various details
- Stylists/Categories, Clients/Items
```

## _License_

[_MIT_](https://opensource.org/licenses/MIT)

Copyright (c) 2021, Logan Roth.

Please contact Contributor for further use information or if you would like to make a contribution.