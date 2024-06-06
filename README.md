[ISO Format]

2024-05-09
TMD BAba Ismail
0850359
Web Application
Made using : VS , .NET 7
No Auth

# WORK LOG (Time in UTC) 

17:50 
- Updated Index.cshtml file to change the text

19:00
- Added youtube video emebed code in "/Views/Movie"

19:08
- Added controller
- Tested adding image inside prject at path "/img/" dir 

20:30
- Added a Welcome View
- Showed Welcome page with link of pattern https://localhost:7242/Movie/Welcome/xxxxxx?id=yyyy 



- 
2024-05-23
Ismail
0850359
Web Application

1411
- added model for movie index
- Added NuGet packages
- executed Add-Migration InitialCreate
- Update-Database Executed


14:30 
- Added the list 
- Recieved an error
- Fixed the page error 



Added Migration 

- 20240523184902_InitialCreate
- added a class to load the index for adding database

14:30
- Seed the database
- Created SeedData to add 5 movies data to database 


14:55
- Added Seed Initializer program.cs

Edited Models page to add release Date

- Unable to see release date 


 [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    [Column(TypeName ="decimal(18,2)")]

 - [Display(Name = "Release Date")]

 made the changes in the movie.cs to make "Release Date" visible but the error persists


2024-05-30
Baba Ismail
0850359
Web Application

Time 

1349

-Updated the Index method found inside Controllers/MoviesController.cs with a piece of code to search the movie names.


1405
-Added Search by genre

1425
-Added search by genre to the Index view
- Checked if Genre tab is showing in the web page
- Works fine

1435

1450
- Added a Rating Property to the Movie Model
- Rating was added to the Bind funtion 

1503
-Added Rating to bind function

1508
-Executed the commands using -
  Add-Migration Rating
  Update-Database

2024-06-06
Baba Ismail
0850359
Web Application

1430

- Delete the previously edited data completely
- Added validation rules to the movie model

1450
- Added the seeed data 
- Checked for validation 
- Validation works perfectly!

14:55
- Edited the colums in Edit.cshtml
- Added Rating section to the code

1503
- Edited the Create.cshtml 
- Included the rating section 

1516

- Added the entries in the seed data to check for validation
- The application works perfextly. 

1520
- Commited the chages in the GIT to push the code
- Checked for README.md
- Updated the README.md file
- Checked for the public repository setting in the setting 
- Comfirmed the repository creation in the git

 

