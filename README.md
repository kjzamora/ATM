# ATM C# Project

With this project, I had 3 main goals:

- Create my first C# program and familiarize myself with the sytatx
- Introduce myself to MySQL and the interactions between the program and an external database
- Attempt to properly implement and familiarize myself with the SOLID principles

## Dependencies
This project utilizes some additional projects and librarys:

- [Dapper](https://github.com/DapperLib/Dapper)
- [MySQL.data](https://www.mysql.com/)
- [Database Access Library](https://github.com/kjzamora/DatabaseAccessLibrary)

## MySQL Setup

	This project will utilize a local hosted MySQL database

	To Setup the MySQL database:

	Need to intsall MySQL (do your own Google search):
	Run installer and install by selection using developers install option
	https://www.youtube.com/watch?v=WuBcTJnIuzo

### My Default Credentials for this project
MySQL root pass: SQLpass

### My Default MySQL Account:
MySQL user account:
user: DBAdmin
pass: admin

### Continuing Installation:
hit next/accept defaults everywhere else

### Initialization:
GUI: Database -> Connect to database ->
	Select stored connection -> Local instance MySQL router
	password -> store in vault -> MySQL root pass

### Table Setup

Two tables will be created for this: tbluseraccount & tbladminaccount:


<p align="center">
  <img src="docs/images/MySQL_userdb_tlbuseraccount.png" width="1000" title="tbluseraccount properties">
</p>