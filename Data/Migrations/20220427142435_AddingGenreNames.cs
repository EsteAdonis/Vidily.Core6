using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Core6.Data.Migrations
{
  public partial class AddingGenreNames : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(1, 'Action')");
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(2, 'Adventure')");      
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(3, 'Animation')");   
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(4, 'Biography')");   
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(5, 'Comedy')");      
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(6, 'Crime')");   
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(7, 'Documentary')");         
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(8, 'Drama')");      
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(9, 'Family')");      
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(10, 'Fantasy')");  
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(11, 'History')");          
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(12, 'Horror')");    
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(13, 'Musical')");        
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(14, 'Mystery')");      
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(15, 'Romance')");    
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(16, 'Sci-Fi')");      
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(17, 'Sport')");      
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(18, 'Thriller')");   
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(19, 'War')");         
      migrationBuilder.Sql("Insert Genres(Id, Name) Values(20, 'Western')");      
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {

    }
  }
}

