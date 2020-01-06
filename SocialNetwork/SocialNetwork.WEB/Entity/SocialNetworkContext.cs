namespace SocialNetwork.WEB.Entity
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SocialNetworkContext : DbContext
    {
        // Your context has been configured to use a 'SocialNetworkContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SocialNetwork.WEB.Entity.SocialNetworkContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SocialNetworkContext' 
        // connection string in the application configuration file.
        public SocialNetworkContext()
            : base("name=SocialNetworkContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostLike> PostLikes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserFollower> UserFollowers { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    public class DBInitializer: DropCreateDatabaseIfModelChanges<SocialNetworkContext>
    {
        protected override void Seed(SocialNetworkContext context)
        {
            base.Seed(context);
        }
    }
}