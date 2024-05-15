# cveditornetcore6mvcdapper

> visit my website at https://awhz.net

This project was created using visual studio 2022 and mvc 6

## Nugget Packages

here's the list of nugget package that was installed :
- dapper version 2.13.5 for orm and data mapper that will enchance the ado.net connectivity
- npgsql version 8.0.3 connectivity to postgree database

## list of required application

if you'r using local pc or laptop makesure when you'r running this project.
you should have installed this list of application :
- Visual Studio 2022 with mvc 6.0 package
- pgJDBC 42.7.2
- Npgsql 3.2.6
- pgAgent_PG16.4.2.2
- PostgreSQL 16
- PgBouncer 1.22.1

## create the database "cveditor" using pgAdmin on postgree

step by step:
1. make sure you have installed the list of application that located on section "list of required application"
2. open application pgAdmin 4 and login using your credential
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createdatabaseiconpgadmin.png)
3. here's the view then you'r success login using your credential on pgAdmin 4
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createdatabaseexpanddatabases.png)
4. find Node "Server" and click the arrow on the node in pgAdmin 4
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createdatabaseservernode.png)
5. find Node Database on you pgAdmin 4 then right click
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createdatabasenodedatabases.png)
6. it will show context menu like image bellow
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createdatabasenodedatabasesshowcontext.png)
7. find and hover "Create" on context menu and click "Database" on sub context menu like image bellow
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createdatabasecontextmenucreate.png)
8. it will show the dialog of create database like image bellow
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createdatabasedialogcreate.png)
9. find and click field database and fill with "cveditor" like image bellow
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createdatabasefielddatabasefilled.png)
10. click save button but make sure you'r fill the field database like step number 6
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createdatabasesavebutton.png)
11. please wait several minute until it show the popup information "database connected"
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createdatabasepopupsuccesscreateddatabase.png)
12. then the page will show cveditor on node "database"
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createdatabasesuccesscreateddatabase.png)


## create table "data" in database "cveditor" on postgree using pgAdmin
before you create table "data" make sure your have created the database "cveditor" and it will show on your node "database" if not found you can check follow the instruction in the section "create the database "cveditor" using pgAdmin on postgree"

there are two ways
a. create using export menu
b. create using query tools
the different between the step a and b is the b already have one data in tables.
please choose what the step do you like.


## a. create table "data" in database "cveditor" on postgree using pgAdmin using menu export
before you create table "data" make sure your have created the database "cveditor" and it will show on your node "database" if not found you can check follow the instruction in the section "create the database "cveditor" using pgAdmin on postgree"

step by step :
1. find and click node "cveditor"
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtablecveditor.png)
2. find and click node "Schemas"
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtableschemas.png)
3. find and right click node "Public"
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtablepublic.png)
3. it will show context menu like image bellow
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtablepubliccontextmenu.png)
4. find and click "Restore" on context menu
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtablecontextmenurestore.png)
5. it will show the Restore dialog like image bellow
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtablecontextmenudialogrestore.png)
6. click icon folder on field filename that are located on Restore Dialog
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtablecontextmenudialogrestoreiconfolder.png)
7.  find the files name "cveditor" the path are located on the same project in folder manual book so makesure for it
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtablefieldfilename.png)
8. after you find the filename "cveditor.sql" double click it
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtabledialogpickfilenamecveditor.png)
9. please make sure your using the correct path on field filename and click button "Restore"
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtabledialogclickrestorebutton.png)
10. please wait several minute and the page will show alert like image bellow
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtabledialogsucesscreatedtable.png)
11. find and click the arrow on node "tables"
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtableclicktables.png)
12. it will show the table "data" has been created
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtableclicktablesdetails.png)
13. if you want to see the coloumn just click the node coloumn
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/createtableclickcoloumns.png)

## b. create table "data" in database "cveditor" on postgree using pgAdmin using query tools
before you create table "data" make sure your have created the database "cveditor" and it will show on your node "database" if not found you can check follow the instruction in the section "create the database "cveditor" using pgAdmin on postgree"

step by step :
1. find and right click node "cveditor"
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtablecveditor.png)
2. it will show context menu like image bellow
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtablescveditorcontextmenu.png)
3. find and click "Query Tool" on context menu
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtablescontextmenuquerytools.png)
4. it will show the dialog "Query Tool"
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtablesdialogquerytools.png)
5. find text file with name "script create public schema and create table data.txt" on folder "Manual Book" and copy the content into Field "Query" on dialog Query Tool
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtablesdialogquerytoolsclickfieldquery.png)
6. please make sure the content that are paste on field "Query" on dialog "Query Tools" are same with the files name "script create public schema and create table data.txt"
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtablesdialogquerytoolsclickfieldquery.png)
7. find and click the play button on dialog Query Tools
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtablesdialogquerytoolsbuttonplay.png)
8. please wait several minute and check the output message on Query Tools
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtablesdialogquerytoolsoutput.png)
9. if the output message like "schema "public" already exists, skipping
ALTER TABLE" it means you'r succed for created schema and table
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtablesdialogquerytoolsoutputdetails.png)
10. to makesure the tables are created find and click the arrow on node "Schemas"
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtableschemas.png)
11. find and right click the arrow on node "Public"
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtablepublic.png)
12. find and click the arrow on node "tables"
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtableclicktables.png)
13. it will show the table "data" has been created
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtableclicktablesdetails.png)
14. if you want to see the coloumn just click the node coloumn
![cveditornetcore6mvcdapper-create-database-pgadminb](ImagesReadme/createtableclickcoloumns.png)


## Run the visual studio project
oke here's the final step after you created the database "cveditor" and table "data" please open visual studio project and run the project.
here's the step by step
1. go to your path download of this project and find and double click the filename "cveditornetcore6mvcdapper.sln"
![cveditornetcore6mvcdapper-runproject-solution](ImagesReadme/runcveditornetcore6mvcdapper.png)
2. it will show the project are open on visual studio
![cveditornetcore6mvcdapper-runproject-opensolution](ImagesReadme/runshowvisualstudioproject.png)
3. find file with name "appsettings.json" on solution explore and double click , on image bellow i have color it with blue or cyan
![cveditornetcore6mvcdapper-runproject-appsettings](ImagesReadme/runappsettings.png)
4. it will show the detail of filename "appsettings.json"
![cveditornetcore6mvcdapper-runproject-appsettingsdetail](ImagesReadme/rundetailsappsettings.png)
5. please makesure the database connection like host , port , username , password , database name are same with your postgree on local pc
![cveditornetcore6mvcdapper-runproject-appsettingsdetailmakesure](ImagesReadme/rundetailsappsettings.png)
6. find and click the green play button 
![cveditornetcore6mvcdapper-runproject-play](ImagesReadme/rungreenbuttonplay.png)
7. please wait several menit until it open the default browser and will show the website completely
![cveditornetcore6mvcdapper-runproject-completed](ImagesReadme/runwebsitecompleted.png)

## Known Bug and how to handle it

## No such host is known
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/knownbughost.png)
for local pc makesure your instaled the required application that are listed on "list of required application" section
after your makesure all the program has been instaled if your on local pc try using "localhost" but if your using outside your pc just using the ip or hostname

## Failed to connect to 127.0.0.1:543
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/knownbugport.png)
please makesure your using right port of your instaled postgree services

## password authentication failed for user "postgres1"
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/knownbugauthentication.png)
please makesure your using right credential for login into postgree

## database "cveditor" does not exist

![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/knownbugdatabase.png)
please makesure your created database "cveditor" on your postgree

## relation "data" does not exist
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/knownbugtable.png)
please makesure there are table "data" on database "cveditor"

## column "skills" of relation "data" does not exist
![cveditornetcore6mvcdapper-create-database-pgadmin](ImagesReadme/knownbugcoloumn.png)
please makesure there are coloumn "id", "name", "gender", "nationality", "education", "skills", "experience" in table "data" on database "cveditor" or you can reimport the table using files name "cveditor.sql" on folder "Manual Book"