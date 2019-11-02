namespace bos_desktop.src.Models
{
	struct User
	{
		public string Database { get; set; }
		public string Table { get; set; }
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Status { get; set; }

		static User() { }
	}
}