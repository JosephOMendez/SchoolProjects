/**
	Database Creation for Deliverable 3
	Name - Joseph Mendez
	UTSA ID - qxo307
	Class - IS.6503.001
**/
--Create the Database used
Create Database "Deliverable 2 Database"


--Table Creation
Create Table EMPLOYEE (
Employee_ID CHAR(6) PRIMARY KEY,
Emp_FName VARCHAR(15) NOT NULL,
Emp_LName VARCHAR(15),
Supervisor CHAR(6),
Department VARCHAR(30),
Age INT,
Gender CHAR(7),
Foreign Key (Supervisor) References EMPLOYEE(Employee_ID)
);

Create Table TIER (
Tier_ID CHAR(6) PRIMARY KEY,
Tier_Name VARCHAR(20),
Movie_Tier BIT NOT NULL,
Game_Tier BIT NOT NULL,
Tier_Price NUMERIC(3,1) NOT NULL,
Tier_Lead CHAR(6) NOT NULL,
Foreign Key (Tier_Lead) References EMPLOYEE(Employee_ID)
);

Create Table CUSTOMER (
Customer_ID CHAR(6) PRIMARY KEY,
Cust_FName VARCHAR(15) NOT NULL,
Cust_LName VARCHAR(15),
Gender VARCHAR(12),
Age INT NOT NULL,
Country VARCHAR(20) NOT NULL,
Email VARCHAR(25) NOT NULL,
Tier_ID CHAR(6) NOT NULL,
Foreign Key (Tier_ID) References TIER(Tier_ID)
);

Create Table DIRECTOR (
Director_ID CHAR(6) PRIMARY KEY,
F_Name VARCHAR(15) NOT NULL,
L_Name VARCHAR(15),
Nationality VARCHAR(20)
);

Create Table MOVIE (
Movie_ID CHAR(6) PRIMARY KEY,
Movie_Title VARCHAR(30) NOT NULL,
Full_Title VARCHAR(50),
Movie_ReleaseYear CHAR(4),
Movie_Genre VARCHAR(10),
Movie_Duration VARCHAR(20),
Director_ID CHAR(6) NOT NULL,
MPA_Rating VARCHAR(6) NOT NULL,
Country VARCHAR(20),
Foreign Key (Director_ID) References DIRECTOR(Director_ID)
);

Create Table MOVIE_TIER (
Movie_ID CHAR(6),
Tier_ID CHAR(6),
Expiration_Date VARCHAR(11),
PRIMARY KEY (Movie_ID, Tier_ID),
Foreign Key (Movie_ID) References MOVIE(Movie_ID),
Foreign Key (Tier_ID) References TIER(Tier_ID)
);

Create Table PARENT_COMPANY (
Company_ID CHAR(6) PRIMARY KEY,
Company_Name VARCHAR(12) NOT NULL,
Country VARCHAR(20)
);

Create Table DEVELOPER (
Developer_ID CHAR(6) PRIMARY KEY,
Developer_Name VARCHAR(20) NOT NULL,
Parent_Company CHAR(6),
Country CHAR(20),
Foreign Key (Parent_Company) References PARENT_COMPANY(Company_ID)
);

Create Table GAME (
Game_ID CHAR(6) PRIMARY KEY,
Game_Title VARCHAR(20) NOT NULL,
Game_ReleaseYear CHAR(4),
Game_Genre VARCHAR(7),
Rating VARCHAR(10) NOT NULL,
Developer_ID CHAR(6) NOT NULL,
Foreign Key (Developer_ID) References DEVELOPER(Developer_ID)
);

Create Table DLC (
DLC_ID CHAR(6) PRIMARY KEY,
DLC_Name VARCHAR(20) NOT NULL,
Game_ID CHAR(6) NOT NULL,
Foreign Key (Game_ID) References GAME(Game_ID)
);

Create Table GAME_TIER (
Game_ID CHAR(6),
Tier_ID CHAR(6),
ExpirationDate VARCHAR(11) NOT NULL,
PRIMARY KEY (Game_ID, Tier_ID),
Foreign Key (Game_ID) References GAME(Game_ID),
Foreign Key (Tier_ID) References TIER(Tier_ID)
);


--Insert Data
--Employee:
Insert Into EMPLOYEE Values (175764, 'Joseph', 'Johannes', NULL, 'Accounting', 50, 'Male');
Insert Into EMPLOYEE Values (175766, 'Leonardo', 'Velasquez', NULL, 'Information Systems', 44, 'Other');
Insert Into EMPLOYEE Values (175763, 'Voltaire', NULL, NULL, 'HR', 47, 'Male');
Insert Into EMPLOYEE Values (175762, 'Kyle', 'Martinez', 175764, 'Accounting', 25, 'Male');
Insert Into EMPLOYEE Values (175765, 'Victoria', 'Cecilia', 175766, 'Information Systems', 38, 'Female');
Insert Into EMPLOYEE Values (175767, 'Bartholomew', 'Fatima', 175764, 'Accounting', 18, 'Male');


--Tier:
Insert Into TIER Values (000001, 'Basic Movie Plan', 1, 0, 12.99, 175765);
Insert Into TIER Values (000002, 'Movie Plan Plus', 1, 0, 16.99, 175765);
Insert Into TIER Values (000003, 'The Game Plan', 0, 1, 15.99, 175766);
Insert Into TIER Values (000004, 'Game Plan Advance', 0, 1, 19.99, 175766);
Insert Into TIER Values (000005, 'One for All Plan', 1, 1, 29.99, 175766);

--Customer:
Insert Into CUSTOMER Values (874935, 'Giovanni', 'Rivers', 'Male', 23, 'United States', 'georiv98@gmail.com', 000002);
Insert Into CUSTOMER Values (874936, 'Crystal', 'Guadalupe', 'Female', 33, 'United States', 'cFgUS@gmail.com', 000002);
Insert Into CUSTOMER Values (874937, 'Karla', 'Carolina', 'Female', 32, 'Mexico', 'karlitas@yahoo.com', 000003);
Insert Into CUSTOMER Values (874938, 'Fumihito', NULL, 'Male', 32, 'United States', 'FumiYumi@aol.com', 000004);
Insert Into CUSTOMER Values (874939, 'Nate', 'Michaels', 'Male', 48, 'United States', 'mettsbabyy@gmail.com', 000002);
Insert Into CUSTOMER Values (874940, 'Anthony', 'Espiga', 'Male', 28, 'Mexico', 'pichuEsg00d@gmail.com', 000005);
Insert Into CUSTOMER Values (874941, 'Yvonne', 'Villa', NULL, 18, 'Mexico', 'c0raz0n@gmail.com', 000001);
Insert Into CUSTOMER Values (874942, 'Fatima', 'Morgnana', NULL, 18, 'United States', 'shatteredheart@aol.com', 000004);

--Director:
Insert into DIRECTOR Values (644452, 'Franklin', 'Schaffner', 'United States');
Insert into DIRECTOR Values (644453, 'John', 'Carpenter', 'United States');
Insert into DIRECTOR Values (644454, 'Carlos Enrique', 'Taobada', 'Mexico');
Insert into DIRECTOR Values (644455, 'Ridley', 'Scott', 'England');

--Movie:
Insert into MOVIE Values (254644, 'Planet of the Apes', NULL, '1968', 'Sci-Fi', '1:52:00', 644452, 'G', 'United States');
Insert into MOVIE Values (254645, 'Escape from New York', NULL, '1981', 'Adventure', '1:39:00', 644453, 'R', 'United States');
Insert into MOVIE Values (254646, 'Even the Wind Is Afraid', 'Hasta el Viento Tiene Miedo', '1968', 'Horror', '1:30:00', 644454, 'R', 'Mexico');
Insert into MOVIE Values (254647, 'Gladiator', NULL, '2000', 'Action', '2:35:00', 644455, 'R', 'United States');
Insert into MOVIE Values (254648, 'Blacker than Night', 'Mas Negro que la Noche', '1975', 'Horror', '1:42:00', 644454, 'R', 'Mexico');

--Movie_Tier:
Insert into MOVIE_TIER Values (254644, 000002, '12-30-2022');
Insert into MOVIE_TIER Values (254644, 000005, '12-30-2022');
Insert into MOVIE_TIER Values (254645, 000001, '09-15-2024');
Insert into MOVIE_TIER Values (254645, 000002, '09-15-2024');
Insert into MOVIE_TIER Values (254645, 000005, '09-15-2024');
Insert into MOVIE_TIER Values (254646, 000001, '08-28-2028');
Insert into MOVIE_TIER Values (254646, 000002, '08-28-2028');
Insert into MOVIE_TIER Values (254646, 000005, '08-28-2028');
Insert into MOVIE_TIER Values (254647, 000002, '08-28-2028');
Insert into MOVIE_TIER Values (254647, 000005, '08-28-2028');
Insert into MOVIE_TIER Values (254648, 000002, '08-28-2025');
Insert into MOVIE_TIER Values (254648, 000005, '08-28-2025');

--Parent_Company:
Insert into PARENT_COMPANY Values (352573, 'SEGA', 'Japan');
Insert into PARENT_COMPANY Values (352574, 'Microsoft', 'United States');
Insert into PARENT_COMPANY Values (352575, 'Dwango', 'Japan');
Insert into PARENT_COMPANY Values (352576, 'Square Enix', 'Japan');

--Developer:
Insert into DEVELOPER Values (826923, 'Bandai Namco', NULL, 'Japan');
Insert into DEVELOPER Values (826924, 'Techland', NULL, 'Poland');
Insert into DEVELOPER Values (826925, 'Bethesda', 352574, 'United States');
Insert into DEVELOPER Values (826926, 'Atlus', 352573, 'Japan');
Insert into DEVELOPER Values (826927, 'Spike Chunsoft', 352575, 'Japan');
Insert into DEVELOPER Values (826928, 'Tokyo RPG Factory', 352576, 'Japan');

--Game:
Insert into GAME Values (439054, 'Tales of Arise', '2021', 'JRPG', 'T', 826923);
Insert into GAME Values (439055, 'Call of Juarez', '2006', 'FPS', 'M', 826924);
Insert into GAME Values (439056, 'Skyrim', '2011', 'RPG', 'M', 826925);
Insert into GAME Values (439057, 'Shin Megami Tensei 3', '2003', 'JRPG', 'M', 826926);
Insert into GAME Values (439058, 'Persona 4 Golden', '2008', 'JRPG', 'M', 826926);
Insert into GAME Values (439059, 'AI The Somnium Files', '2019', 'Mystery', 'M', 826927);
Insert into GAME Values (439060, 'I am Setsuna', '2016', 'RPG', 'E10+', 826928);

--DLC:
Insert into DLC Values (375610, 'Starter Pack', 439054);
Insert into DLC Values (375611, 'Maniax Pack', 439057);
Insert into DLC Values (375612, 'Chronicle Pack', 439057);
Insert into DLC Values (375613, 'BGM Pack', 439057);

--Game_Tier:
Insert into GAME_TIER Values (439054, 000004, '11-16-2025');
Insert into GAME_TIER Values (439054, 000005, '11-16-2025');
Insert into GAME_TIER Values (439055, 000003, '12-01-2027');
Insert into GAME_TIER Values (439055, 000004, '12-01-2027');
Insert into GAME_TIER Values (439055, 000005, '12-01-2027');
Insert into GAME_TIER Values (439056, 000004, '03-27-2034');
Insert into GAME_TIER Values (439056, 000005, '03-27-2034');
Insert into GAME_TIER Values (439057, 000003, '11-16-2025');
Insert into GAME_TIER Values (439057, 000004, '11-16-2025');
Insert into GAME_TIER Values (439057, 000005, '11-16-2025');
Insert into GAME_TIER Values (439058, 000004, '12-01-2027');
Insert into GAME_TIER Values (439058, 000005, '12-01-2027');
Insert into GAME_TIER Values (439059, 000004, '11-16-2025');
Insert into GAME_TIER Values (439059, 000005, '11-16-2025');
Insert into GAME_TIER Values (439060, 000003, '03-27-2034');
Insert into GAME_TIER Values (439060, 000004, '03-27-2034');
Insert into GAME_TIER Values (439060, 000005, '03-27-2034');