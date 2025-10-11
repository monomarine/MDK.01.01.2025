namespace POl
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			List<Alien> aliens = new List<Alien>();

			aliens.Add(new GreenAlien());
			aliens.Add(new GrayAlien());
			aliens.Add(new InsectAlien());

			InsectAlien alien = new();
			foreach (var item in aliens)
			{
				item.Communication(alien);
				alien.Communication(item);
			}
		}
	}
}