# Asp.nerMVCCRUD
ASP.NET CORE MVC CRUD operation tutorial

Let's take about steps of starting the project 

first of all we need to install Microsoft.Entityframeworkcore, Microsoft.Entityframeworkcore.sqlserver, Microsoft.Entityframeworkcore.tools

let's start the project.

1 - Create Models folder.
2 - create cs file named DbContext - DbContainer <- will Manage "transactions-processes" between you and the database using entityframeworks.

                                        public DbContainer(DbContextOptions<DbContainer> options):base(options)
                                                { }
                                                
                                                
We have two main files "Startup.cs - appsettings" 


4 - appsetting is a json file of some setting in our project in our example we define the connectionStrings.

                                        "ConnectionStrings": {
                                            "DefaultConnection": "Server = .\\SQLEXPRESS; Database = Employees_Db; Trusted_Connection = True; MultipleActiveResultSets = True"
                                          },

5 - then using it in startup.cs 

                          services.AddDbContext<DbContainer>(
                                          options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                                          );
                                          
6 - Create your first table in our case { Employee.cs }

Using migration to create our database and tables.

7 - using Package Manager Console to use it (Tools -> Nuget Package Manager -> Package Manager Console)

8 - type Add-Migration "InitialModel" will create new folder called migration contain the design of our database tables.

9 - then type Update-Database 

10 - go to sql server and check the new table.

then start to implement your logical code.
best of luck and Enjoy! :) 
