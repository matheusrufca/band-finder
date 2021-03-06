﻿using System;

namespace BandFinder.Domain.Models
{
	// You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.



	public class UserProfileInformation : BaseEntity
	{
		public string Bio { get; set; }
		public string Cover { get; set; }
		public DateTime? Birthdate { get; set; }

		//public virtual Musician MusicianProfile { get; set; }
	}

	//public class ApplicationUser : IdentityUser
	//{

	//	public virtual UserProfileInformation UserProfileInformation { get; set; }


	//	public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
	//	{
	//		// Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
	//		var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
	//		// Add custom user claims here
	//		return userIdentity;
	//	}
	//}

	//public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	//{
	//	public ApplicationDbContext()
	//		: base("DefaultConnection", throwIfV1Schema: false)
	//	{
	//	}

	//	public static ApplicationDbContext Create()
	//	{
	//		return new ApplicationDbContext();
	//	}

	//	public DbSet<UserProfileInformation> UserProfileInformation { get; set; }
	//}
}