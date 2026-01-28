# 🎬 SKA Holding | .NET + EF Core Movie Database
A modern **IMDb**-inspired project built with **C#**, **Entity Framework Core** (Code First) and **SQL Server**.

This application manages information about **movies**, **directors**, **screenwriters**, **actors**, **genres**, **users**, **ratings** and **reviews**.

Main goals of the project:
- Practice clean **Code First** entity modeling
- Use **Data Annotations** + navigation properties
- Implement basic **service layer** with CRUD operations
- Understand **many-to-many** relationships in EF Core
- Prepare structure for future **ratings**, **reviews** and search features

## 📊 Database Schema

### Entities / Tables

1. **MovieDirector**  
   - `DirectorId` **INT** PRIMARY KEY  
   - `DirectorName` **VARCHAR(100)**  
   - `DirectorSurname` **VARCHAR(100)**  

2. **ScreenWriter**  
   - `ScreenWriterId` **INT** PRIMARY KEY  
   - `ScreenWriterName` **VARCHAR(100)**  
   - `ScreenWriterSurname` **VARCHAR(100)**  

3. **Movie** (core entity)  
   - `MovieId` **INT** PRIMARY KEY  
   - `DirectorId` **INT** FOREIGN KEY → MovieDirector  
   - `ScreenWriterId` **INT** FOREIGN KEY → ScreenWriter  
   - `Title` **VARCHAR(100)**  
   - `ReleaseYear` **INT** (nullable)  
   - `Duration` **INT** (minutes, nullable)  
   - `Description` **VARCHAR(MAX)** (nullable)  

4. **Actor**  
   - `ActorId` **INT** PRIMARY KEY  
   - `ActorName` **VARCHAR(100)**  
   - `ActorSurname` **VARCHAR(100)**  

5. **Genre**  
   - `GenreId` **INT** PRIMARY KEY  
   - `GenreName` **VARCHAR(100)**  

6. **MovieGenre** (junction table – many-to-many)  
   - `MovieGenreId` **INT** PRIMARY KEY  
   - `MovieId` **INT** FOREIGN KEY → Movie  
   - `GenreId` **INT** FOREIGN KEY → Genre  

7. **User**  
   - `UserId` **INT** PRIMARY KEY  
   - `Username` **VARCHAR(100)** UNIQUE  
   - `Email` **VARCHAR(100)** UNIQUE (nullable)  
   - `FirstName` **VARCHAR(50)** (nullable)  
   - `LastName` **VARCHAR(50)** (nullable)  
   - `BirthDate` **DATE** (nullable)  

8. **Rating**  
   - `RatingId` **INT** PRIMARY KEY  
   - `UserId` **INT** FOREIGN KEY → User  
   - `MovieId` **INT** FOREIGN KEY → Movie  
   - `Score` **INT** (nullable)  
   - `RatedAt` **DATE** (nullable)  
   - **Unique constraint**: (UserId, MovieId)  

9. **Review**  
   - `ReviewId` **INT** PRIMARY KEY  
   - `UserId` **INT** FOREIGN KEY → User  
   - `MovieId` **INT** FOREIGN KEY → Movie  
   - `Content` **VARCHAR(MAX)**  
   - `PublishedAt` **DATE** (nullable)  

### 🔗 Important Relationships

- **Movie** → **MovieDirector** (Many-to-One)  
- **Movie** → **ScreenWriter** (Many-to-One)  
- **Movie** ↔ **Actor** (Many-to-Many – via navigation property `Movie.Actors`)  
- **Movie** ↔ **Genre** (Many-to-Many – via `MovieGenre` table)  
- **Movie** → **Rating** (One-to-Many)  
- **Movie** → **Review** (One-to-Many)  
- **User** → **Rating** (One-to-Many)  
- **User** → **Review** (One-to-Many)  

All foreign keys are enforced. Navigation properties and `[InverseProperty]` attributes are used to configure both directions.

## 🛠️ Implemented Features (so far)

- Full **CRUD services** for:  
  → Movies  
  → Directors  
  → Genres  
- Basic console demo showing create → list → update → delete cycle  
- Proper **many-to-many** setup for genres (Movie ↔ Genre)  
- Navigation collections prepared for actors (`ICollection<Actor> Actors`)  
- Unique constraints on `User.Username` and `User.Email`  
- Unique constraint on user + movie rating combination  

Still missing / planned:
- Actor & Screenwriter full CRUD services  
- Logic to add/remove actors to/from movies  
- Rating & Review CRUD  
- Search / filtering  
- Proper input validation  

## 🧪 SQL Queries you worked with / tested

- Movies + director name  
- Director filmography count  
- Average rating per genre  
- Movies without actors  
- Genres with highest average rating  
- Movies released after certain year  
- Movies with high average rating  
- …and many multi-table JOIN experiments

(see your query collection for the full list)

---

solid foundation
powered by ksovreli ))))
