SELECT TOP (1000)
  [Id]
      , [Name]
      , [DateAdded]
      , [GenreId]
      , [NumberAvailable]
      , [NumberInStock]
      , [ReleaseDate]
FROM [Vidly].[dbo].[Movies]

Begin Tran
Insert Movies
  (name, DateAdded, GenreId, NumberAvailable, NumberInStock, ReleaseDate)
Values('Hangover', DateAdd(d, -Floor(Rand()*20000), GetDate()), 5, Floor(Rand()*20), Floor(Rand()*15), DateAdd(d, -Floor(Rand()*20000), GetDate()) );

Insert Movies
  (name, DateAdded, GenreId, NumberAvailable, NumberInStock, ReleaseDate)
Values('Die hard', DateAdd(d, -Floor(Rand()*20000), GetDate()), 1, Floor(Rand()*20), Floor(Rand()*15), DateAdd(d, -Floor(Rand()*20000), GetDate()) );

Insert Movies
  (name, DateAdded, GenreId, NumberAvailable, NumberInStock, ReleaseDate)
Values('The Terminator', DateAdd(d, -Floor(Rand()*20000), GetDate()), 1, Floor(Rand()*20), Floor(Rand()*15), DateAdd(d, -Floor(Rand()*20000), GetDate()) );

Insert Movies
  (name, DateAdded, GenreId, NumberAvailable, NumberInStock, ReleaseDate)
Values('Toy Story', DateAdd(d, -Floor(Rand()*20000), GetDate()), 9, Floor(Rand()*20), Floor(Rand()*15), DateAdd(d, -Floor(Rand()*20000), GetDate()) );

Insert Movies
  (name, DateAdded, GenreId, NumberAvailable, NumberInStock, ReleaseDate)
Values('Titanic', DateAdd(d, -Floor(Rand()*20000), GetDate()), 15, Floor(Rand()*20), Floor(Rand()*15), DateAdd(d, -Floor(Rand()*20000), GetDate()) );


Select *
From Movies
Rollback tran


Select GetDate()
Select DateAdd(d, -Floor(Rand()*20000), GetDate() )
Select Floor(Rand()*20)