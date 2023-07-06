namespace FootTeamTracker.Common
{
	public class EntityValidationConstants
	{
		public static class Coach
		{
			public  const int NameMaxLength = 50;
			public  const int NameMinLength = 3;
			public  const int ExperienceMaxLength = 200;
			public  const int ExperienceMinLength = 20;
			public  const int CoachingStyleMaxLength = 100;
			public  const int CoachingStyleMinLength = 10;
		

		}

		public static class Injury
		{
			public const int TypeMaxLength = 50;
			public const int TypeMinLength = 3;
		}
		public static class League
		{
			public const int NameMaxLength = 50;
			public const int NameMinLength = 3;

			public const int CountryMaxLength = 200;
			public const int CountryMinLength = 10;

			public const int SeasonMaxLength = 80;
			public const int SeasonMinLength = 5;
		}
	
		public static class News
		{
			public const int TitleMaxLength = 50;
			public const int TitleMinLength = 5;
			public const int ContentMaxLength = 1000;
			public const int ContentMinLength = 100;
			public const int ImageMaxLength = 200;
			public const int ImageMinLength = 10;
		}
		public static class Player
		{
			public const int NameMaxLength = 50;
			public const int NameMinLength = 3;
		}
		public static class Stadium
		{
			public const int NameMaxLength = 50;
			public const int NameMinLength = 3;
			public const int LocationMaxLength = 80;
			public const int LocationMinLength = 3;
		}

		public static class Team
		{
			public const int NameMaxLength = 50;
			public const int NameMinLength = 3;
			public const int LogoMaxLength = 100;
			public const int LogoMinLength = 3;
		}

		public static class TrainingSession
		{
			public const int ObjectivesMaxLength = 50;
			public const int ObjectivesMinLength = 3;
			public const int LocationMaxLength = 80;
			public const int LocationMinLength = 3;
		}

		public static class Trophy
		{
			public const int NameMaxLength = 50;
			public const int NameMinLength = 3;
			public const int DescriptionMaxLength = 180;
			public const int DescriptionMinLength = 3;
		}

		public static class User
		{
			public const int UserNameMaxLength = 50;
			public const int UserNameMinLength = 8;
			public const int EmailMaxLength = 35;
			public const int EmailMinLength = 6;
		}

	}
}