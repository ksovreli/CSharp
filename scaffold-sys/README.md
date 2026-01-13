# 🎬 IMDB-like Movie Database Project

A relational database project inspired by **IMDb**, implemented in **Microsoft SQL Server**.

This database stores and manages information about **movies**, **directors**, **screenwriters**, **actors**, **genres**, and **users**.  
The main goal of the project is to practice key relational database concepts:

- Table design and normalization
- **PRIMARY KEY** / **FOREIGN KEY** constraints
- Various types of **JOIN**s (INNER, LEFT, multi-table)
- **GROUP BY** + aggregate functions (**AVG**, **COUNT**, etc.)
- Filtering (**WHERE**), sorting (**ORDER BY**), and complex queries

## 📊 Database Schema

### Tables

1. **MovieDirector**  
   - `DirectorId` **INT** PRIMARY KEY  
   - `DirectorName` **VARCHAR**  
   - `DirectorSurname` **VARCHAR**

2. **ScreenWriter**  
   - `ScreenWriterId` **INT** PRIMARY KEY  
   - `ScreenWriterName` **VARCHAR**  
   - `ScreenWriterSurname` **VARCHAR**

3. **Movie** (core table)  
   - `MovieId` **INT** PRIMARY KEY  
   - `DirectorId` **INT** FOREIGN KEY → MovieDirector  
   - `ScreenWriterId` **INT** FOREIGN KEY → ScreenWriter  
   - `Title` **VARCHAR**  
   - `ReleaseYear` **INT**  
   - `Duration` **INT** (in minutes)  
   - `Rating` **DECIMAL(3,1)**  
   - `Description` **TEXT** / **VARCHAR(MAX)**

4. **Actor**  
   - `ActorId` **INT** PRIMARY KEY  
   - `ActorName` **VARCHAR**  
   - `ActorSurname` **VARCHAR**

5. **MovieActor** (junction table – many-to-many)  
   - `MovieId` **INT** FOREIGN KEY → Movie  
   - `ActorId` **INT** FOREIGN KEY → Actor  
   - **Composite PRIMARY KEY**: `(MovieId, ActorId)`

6. **Genre**  
   - `GenreId` **INT** PRIMARY KEY  
   - `GenreName` **VARCHAR** (e.g. Action, Drama, Comedy…)

7. **MovieGenre** (junction table – many-to-many)  
   - `MovieGenreId` **INT** PRIMARY KEY (or composite PK: MovieId + GenreId)  
   - `MovieId` **INT** FOREIGN KEY → Movie  
   - `GenreId` **INT** FOREIGN KEY → Genre

8. **User**  
   - `UserId` **INT** PRIMARY KEY  
   - `Username` **VARCHAR**  
   - `Email` **VARCHAR**  
   - `JoinDate` **DATE** / **DATETIME**

### 🔗 Relationships

- **Movie** → **MovieDirector** (Many-to-One)  
- **Movie** → **ScreenWriter** (Many-to-One)  
- **Movie** ↔ **Actor** (Many-to-Many via **MovieActor**)  
- **Movie** ↔ **Genre** (Many-to-Many via **MovieGenre**)

All relationships are enforced using **FOREIGN KEY** constraints to maintain **referential integrity**.

## 🧪 Implemented SQL Features & Queries

The project demonstrates practical usage of:

- **INNER JOIN** and **LEFT JOIN**  
- Multi-table **JOIN**s (3+ tables)  
- **GROUP BY** + aggregates: **COUNT**, **AVG**, **MAX**, **MIN**  
- **WHERE**, **ORDER BY**, **HAVING** clauses  
- Complex filtering and sorting  
- Basic examples of subqueries
