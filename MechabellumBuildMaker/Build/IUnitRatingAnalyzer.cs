namespace Mechabellum.Build
{
	using Unit;

	public sealed class UnitRating(string rating, IUnit unit)
	{
		public string Rating { get; } = rating;
		public IUnit Unit { get; } = unit;

	}

	public interface IUnitRatingAnalyzer : IUnitVisitor
	{
		UnitRating Analyze(IUnit unit);

		public sealed class ArclightRatingAnalyzer : IUnitRatingAnalyzer
		{
			public UnitRating Analyze(IUnit unit)
			{
				unit.Accept(this);
				return stack.Pop();
			}

			private readonly Stack<UnitRating> stack = new Stack<UnitRating>();

			public void Visit(IUnit.Arclight arclight)
			{
				stack.Push(new UnitRating("/", arclight));
			}

			public void Visit(IUnit.Crawler crawler)
			{
				stack.Push(new UnitRating("E", crawler));
			}

			public void Visit(IUnit.Fang fang)
			{
				stack.Push(new UnitRating("E", fang));
			}

			public void Visit(IUnit.FireBadger badger)
			{
				stack.Push(new UnitRating("B", badger));
			}

			public void Visit(IUnit.Fortress fortress)
			{
				stack.Push(new UnitRating("S", fortress));
			}

			public void Visit(IUnit.Hacker hacker)
			{
				stack.Push(new UnitRating("S", hacker));
			}

			public void Visit(IUnit.Marksman marksman)
			{
				stack.Push(new UnitRating("S", marksman));
			}

			public void Visit(IUnit.MeltingPoint meltingPoint)
			{
				stack.Push(new UnitRating("A", meltingPoint));
			}

			public void Visit(IUnit.Mustang mustang)
			{
				stack.Push(new UnitRating("E", mustang));
			}

			public void Visit(IUnit.Overlord overlord)
			{
				stack.Push(new UnitRating("S", overlord));
			}

			public void Visit(IUnit.Phoenix phoenix)
			{
				stack.Push(new UnitRating("S", phoenix));
			}

			public void Visit(IUnit.Rhino rhino)
			{

				stack.Push(new UnitRating("S", rhino));
			}

			public void Visit(IUnit.Sandworm sandworm)
			{
				stack.Push(new UnitRating("S", sandworm));
			}

			public void Visit(IUnit.Scorpion scorpion)
			{
				stack.Push(new UnitRating("A", scorpion));
			}

			public void Visit(IUnit.Sabertooth sabertooth)
			{
				stack.Push(new UnitRating("A", sabertooth));
			}

			public void Visit(IUnit.Sledgehammer sledgehammer)
			{
				stack.Push(new UnitRating("A", sledgehammer));
			}

			public void Visit(IUnit.Steelball steelball)
			{
				stack.Push(new UnitRating("A", steelball));
			}

			public void Visit(IUnit.Stormcaller stormcaller)
			{
				stack.Push(new UnitRating("S", stormcaller));
			}

			public void Visit(IUnit.Tarantula tarantula)
			{
				throw new NotImplementedException();
			}

			public void Visit(IUnit.Typhoon typhoon)
			{
				stack.Push(new UnitRating("C", typhoon));
			}

			public void Visit(IUnit.Vulcan vulcan)
			{
				stack.Push(new UnitRating("B", vulcan));
			}

			public void Visit(IUnit.WarFactory warFactory)
			{
				stack.Push(new UnitRating("S", warFactory));
			}

			public void Visit(IUnit.Wasp wasp)
			{
				stack.Push(new UnitRating("S", wasp));
			}

			public void Visit(IUnit.Wraith wraith)
			{
				stack.Push(new UnitRating("S", wraith));
			}
		}
	}
}
