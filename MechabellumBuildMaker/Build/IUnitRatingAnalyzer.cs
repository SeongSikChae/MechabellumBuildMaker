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

			public void Visit(IUnit.Crawler unit)
			{
				stack.Push(new UnitRating("E", unit));
			}

			public void Visit(IUnit.Fang unit)
			{
				stack.Push(new UnitRating("E", unit));
			}

			public void Visit(IUnit.Marksman unit)
			{
				stack.Push(new UnitRating("S", unit));
			}

			public void Visit(IUnit.Arclight unit)
			{
				stack.Push(new UnitRating("/", unit));
			}

			public void Visit(IUnit.Wasp unit)
			{
				stack.Push(new UnitRating("S", unit));
			}

			public void Visit(IUnit.Mustang unit)
			{
				stack.Push(new UnitRating("E", unit));
			}

			public void Visit(IUnit.Sledgehammer unit)
			{
				stack.Push(new UnitRating("A", unit));
			}

			public void Visit(IUnit.Steelball unit)
			{
				stack.Push(new UnitRating("A", unit));
			}

			public void Visit(IUnit.Stormcaller unit)
			{
				stack.Push(new UnitRating("S", unit));
			}

			public void Visit(IUnit.Phoenix unit)
			{
				stack.Push(new UnitRating("S", unit));
			}

			public void Visit(IUnit.Rhino unit)
			{
				stack.Push(new UnitRating("S", unit));
			}

			public void Visit(IUnit.Hacker unit)
			{
				stack.Push(new UnitRating("S", unit));
			}

			public void Visit(IUnit.Wraith unit)
			{
				stack.Push(new UnitRating("S", unit));
			}

			public void Visit(IUnit.Scorpion unit)
			{
				stack.Push(new UnitRating("A", unit));
			}

			public void Visit(IUnit.Vulcan unit)
			{
				stack.Push(new UnitRating("B", unit));
			}

			public void Visit(IUnit.Fortress unit)
			{
				stack.Push(new UnitRating("S", unit));
			}

			public void Visit(IUnit.MeltingPoint unit)
			{
				stack.Push(new UnitRating("A", unit));
			}

			public void Visit(IUnit.Overlord unit)
			{
				stack.Push(new UnitRating("S", unit));
			}

			public void Visit(IUnit.Sandworm unit)
			{
				stack.Push(new UnitRating("S", unit));
			}

			public void Visit(IUnit.WarFactory unit)
			{
				stack.Push(new UnitRating("S", unit));
			}

			public void Visit(IUnit.FireBadger unit)
			{
				stack.Push(new UnitRating("B", unit));
			}

			public void Visit(IUnit.Typhoon unit)
			{
				stack.Push(new UnitRating("C", unit));
			}

			public void Visit(IUnit.Sabertooth unit)
			{
				stack.Push(new UnitRating("A", unit));
			}

			public void Visit(IUnit.Tarantula unit)
			{
				throw new NotImplementedException();
			}
			
		}
	}
}
