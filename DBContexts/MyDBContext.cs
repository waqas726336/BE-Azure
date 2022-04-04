using FieldforceCareersSolution.Model;
using Microsoft.EntityFrameworkCore;

namespace FieldforceCareersSolution.DBContexts
{
    public class MyDBContext : DbContext
    {
        public DbSet<UserGroup> AllUserGroups { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use Fluent API to configure  

            // Map entities to tables  
            modelBuilder.Entity<UserGroup>().ToTable("UserGroups");
            modelBuilder.Entity<blob>().ToTable("TestDB");


            // Configure Primary Keys  
            modelBuilder.Entity<UserGroup>().HasKey(ug => ug.Id).HasName("PK_UserGroups");
            modelBuilder.Entity<blob>().HasKey(ug => ug.FileName).HasName("PK_blob");




            // Configure indexes  
            modelBuilder.Entity<UserGroup>().HasIndex(p => p.FirstName).IsUnique().HasDatabaseName("Idx_Name");



            // Configure columns  
            //usergroup
            modelBuilder.Entity<UserGroup>().Property(ug => ug.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<UserGroup>().Property(ug => ug.FirstName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<UserGroup>().Property(ug => ug.CreationDateTime).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<UserGroup>().Property(ug => ug.LastUpdateDateTime).HasColumnType("datetime").IsRequired(false);


            modelBuilder.Entity<blob>().Property(ug => ug.FileName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<blob>().Property(ug => ug.FilePath).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<blob>().Property(ug => ug.createdOn).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<blob>().Property(ug => ug.Updated).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<blob>().Property(ug => ug.isDeleted).HasColumnType("int").IsRequired();









            //// Configure relationships  
            //modelBuilder.Entity<User>().HasOne<UserGroup>().WithMany().HasPrincipalKey(ug => ug.Id).HasForeignKey(u => u.UserGroupId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Users_UserGroups");


        }
    }
}