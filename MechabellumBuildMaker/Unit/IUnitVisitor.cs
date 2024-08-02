namespace Mechabellum.Unit
{
	public interface IUnitVisitor
	{
		void Visit(IUnit.Crawler unit);
		void Visit(IUnit.Fang unit);
		void Visit(IUnit.Marksman unit);
		void Visit(IUnit.Arclight unit);
		void Visit(IUnit.Wasp unit);
		void Visit(IUnit.Mustang unit);
		void Visit(IUnit.Sledgehammer unit);
		void Visit(IUnit.Steelball unit);
		void Visit(IUnit.Stormcaller unit);
		void Visit(IUnit.Phoenix unit);
		void Visit(IUnit.Rhino unit);
		void Visit(IUnit.Hacker unit);
		void Visit(IUnit.Wraith unit);
		void Visit(IUnit.Scorpion unit);
		void Visit(IUnit.Vulcan unit);
		void Visit(IUnit.Fortress unit);
		void Visit(IUnit.MeltingPoint unit);
		void Visit(IUnit.Overlord unit);
		void Visit(IUnit.Sandworm unit);
		void Visit(IUnit.WarFactory unit);
		void Visit(IUnit.FireBadger unit);
		void Visit(IUnit.Typhoon unit);
		void Visit(IUnit.Sabertooth unit);
		void Visit(IUnit.Tarantula unit);
	}
}
