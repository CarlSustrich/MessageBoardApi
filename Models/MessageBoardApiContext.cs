using Microsoft.EntityFrameworkCore;
namespace MessageBoard.Models;

public class MessageBoardApiContext : DbContext
{
  public DbSet<Group> Groups {get;set;}
  public DbSet<Post> Posts {get;set;}
  public DbSet<User> Users {get;set;}

  public MessageBoardApiContext(DbContextOptions<MessageBoardApiContext> options) : base(options) 
  {
  }

  protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Group>()
        .HasData(
          new Group { GroupId = 1, GroupName = "Gossip"}
        );
      builder.Entity<User>()
        .HasData(
          new User {UserId = 2, UserName = "jason_admin", EmailAddress = "jason.admin@email.com", Password = "MyPass_w0rd", GivenName = "Jason", Surname = "Bryant", Role = "Administrator" },
          new User() {UserId = 3, UserName = "elyse_seller", EmailAddress = "elyse.seller@email.com", Password = "MyPass_w0rd", GivenName = "Elyse", Surname = "Lambert", Role = "Seller" }
        );
    }
}
