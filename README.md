This project come from my need to repeatedly creating new .NET Core MVC project with asp.net identity (for STUDY or TESTING, NOT SUITABLE FOR PRODUCTION) while studying asp.net core.  The standard project template created a project that require you to :

1. Run migration to create a new database
2. Add user name and password that must meet strong password requirement
3. randomized the identity db name
4. randomized the port of the project

The project elimiate all these steps.
1. No need for migration, identity db is already created
2. You can add user with only a single character password
3. identity db name is always asp.net.identity.db
4. ports are provided at creation time, default to 5000 and 44300 (ssl)
5. program.cs and HomeController.cs files are appended with project name so that you know which project's program.cs you are editing when you have many projects.


In addition, this project include 

Code to seed identity user




WHO might find this project useful ?

Those who need to create asp.net core app with individual account often (for STUDY or TESTING), and may need to swtich between SQLite and SQL Server Localdb


The only explanation that is needed is that in order to allow unrestricted password , these files are copied from identity scalfolding and modified as needed

Register.cshtml
Register.cshtml.cs


You probably want to open this project, and modify template.json according your need and export this project as a project template


dotnet commands ;

dotnet new install .

dotnet new list ponyspeed888-mvc-templates

dotnet new uninstall .







