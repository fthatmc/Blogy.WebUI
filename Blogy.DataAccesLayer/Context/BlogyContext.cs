using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.Context
{
	public class BlogyContext : IdentityDbContext<AppUser,AppRole,int>
    { //IdentityDbContext 19.03.2024 14:30
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=ATMACA\\SQLEXPRESS; database=DbBlogy; Integrated security = true; TrustServerCertificate=True;");
		}

		public DbSet<Category> Categorys { get; set; }
		public DbSet<Article> Articles { get; set; }
		public DbSet<Comment> Comments { get; set; }		
		public DbSet<Tag> Tags { get; set; }
		public DbSet<Writer> Writers { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<SendMessage> SendMessages { get; set; }
		public DbSet<Notification> Notifications { get; set; }
		public DbSet<Contact> Contacts { get; set; }

	}
}
