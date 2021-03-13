# <div align="center"> **Eau Claire Hair Salon Client and Stylist Tracker** </div>
### This is a web application in order to track Stylists and Clients

 ### _Contributor(s) and Contact Info_
> Logan Roth diamondintheroth@gmail.com - [GitHub(Lo-GR)](https://github.com/Lo-GR)

---

## _Technologies Used_ ⚙

* **C# 9**
* **.NET 5.0.102**
* **SDK 8.0.19**
* **Razor**
* **Bootstrap 4.5**
* **HTML 5 (CS version)/CSS3**
* **My SQL 8.0.19/WorkBench 8.0.19**
* **Entity Framework**
* **HTML Helper**

## _Concepts Used_ 🧠

* **MVC**
* **RESTful Conventions**
* **CRUD Functionality**
* **Database Retrieval/Storage**

---

## _Description_ 📃
This MVC webpage will present it's user with a splash screen and options to view Stylist or Client indexes. All CRUD functionality is present for both Stylist and Client data and options are presented in an explorable fashion on the webpage. 

This is a practice project for practicing C#, Razor, ASP .NET framework, Entity Framework, MySQl, Databases and MVC for a course at Epicodus.

---

## _Installation Guide_ 💻 

<details>
<summary>Open for full Guide</summary>

### _Cloning and Initial Setup_

> Repository: https://github.com/Lo-GR/HairSalon.Solution.git
1. In your terminal of choice or [GitHub's Desktop Application](https://desktop.github.com/) , clone the above repository from Github. For further explanation on how to clone this repository, please visit [GitHub's Documentation](https://docs.github.com/en/github/using-git/which-remote-url-should-i-use).
2. Ensure you are running .NET Core SDK by using the command dotnet --version in your terminal. If a version number is not presented, please visit [this download page for .NET 5 and install the applicable software for your OS](https://dotnet.microsoft.com/download/dotnet/5.0). 
3. Once you verify you are running a .NET 5, navigate in your terminal to HairSalon directory within the HairSalon.Solution directory you just cloned. Once there, run "dotnet build" in your terminal to build application within directory. 
4. In your terminal, while still in HairSalon directory, run "dotnet restore."
5. You will require a text or code editor to complete the following steps. [VS Code is recommended](https://code.visualstudio.com/)


### _Installation: Database Recreation_

1. Ensure you are running MySQL Server 8 and MySQL WorkBench 8. If you are running windows, use the [Windows Installer ](https://dev.mysql.com/downloads/installer/) for MySQL and follow the instructions provided by the installer. For Macs, visit [MySQL Commuinity Downloads](https://dev.mysql.com/downloads/mysql/) and select macOS from the Operation Systems. This will be a manual installation. If you need additonal assistance on this, please visit Epicodus's [Learn How to Program Article](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).
2. Once you verify you have SQL installed, import the database structure and example data dump named "logan_roth.sql" in the root directory. In order to do this, open MySQL Workbench and navigate to a server. Then open the Administration tab in the Navigator window. Select Data Import/Restore. In Import Options, select "Import from Self-Contained File". Navigate to the file mentioned above and then click "Start Import." This should create a copy of the database used to make this application. 
3. Create a file called "appsettings.json" in the root directory HairSalon.Solution. Paste the following into this file.
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port={PORT OF SERVER};database=logan_roth;uid=root;pwd={PASSWORD OF SERVER};"
  }
}
```
### _Installation: General Use_

1. Back in your terminal in the HairSalon production directory, type "dotnet run." The terminal will present local host routes for you to navigate to in your browser. An example would be "http://localhost:5000." Enter this into a web browser of choice to use this application. Keep the terminal running as it is being used to control the local server.
2. When finished, exit the terminal or use the command "CTRL C"(Windows) or "CMD C"(Mac) to shut down the local server.

</details>

---

## _Known Bugs_ 🩹
* No known bugs at this time. Please contact a contributor to report any bugs found during use.

---

## _Future Updates_ 🛠
* Additional UI
* A feature to search and retrieve Stylists or Clients
* A feature to sort data

---

## _Preplanning/Whiteboard Work_ 📋
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
---

## _License_ ⚖️

[![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://lbesson.mit-license.org/)

Copyright (c) 2021, Logan Roth.

Please contact Contributor for further use information or if you would like to make a contribution.