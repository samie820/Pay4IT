# Pay4IT
An ecommerce application built using Vue.JS and ASP.NET core API

# Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 
See deployment for notes on how to deploy the project on a live system.

# Prerequisites

So before you get started here are the things you might need:


- NodeJS >= 8.0

- ASP.NET core/CLI >= 2.0

- Git (You definitely need GIT)

- PostgreSQL - To get the latest version of the database for your development system just checkout this [link](https://www.postgresql.org/download/)

- VSCode - To download this awesome editor click [here](https://code.visualstudio.com/Download) and install the c# extension

# Installing

Now that you have all the requirements setup, these are the installation steps:

- Make a folder and Clone the repo:
```
mkdir Project && cd Project
git clone https://github.com/samie820/Pay4IT.git
```

- Navigate into the `Pay4IT` directory:
```
cd Pay4IT
```

- Install the dependencies and Run the app
```
npm install && dotnet run
```

- In case asp.net defaults to a production environment, this is a fix, Just use that command:
```
 export ASPNETCORE_ENVIRONMENT=Development
```

# Note: If you have database connection issues, then follow this step:
- Open PGAdmin (it comes with the Postgres setup)
- Select the PostgreSQL item and click the Properties tab on the top
- In the `Connection` section, check the value for username
- Open your editor(Vscode), then open the `appsettings.json` file
- Replace the `DefaultConnection` values with your database details
Your `appsettings.json` file should now look like this:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "host=localhost;database=<database-name>;username=<default-username(postgres)>;password=<default-password(postgres)>"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  }
}
```

Then run the command `dotnet run` again, everything should work fine

# Deployment
Coming soon

# Built With
- ASP.NET core - Web framework used(Backend)
- VueJS - Web framework used(Frontend)
- PostgreSQL - Database used

# Authors
Omole Samuel - [@ajeboDeveloper](https://twitter.com/ajeboDeveloper)

