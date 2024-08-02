namespace Mechabellum.Unit
{
	public interface IUnitVisitor
	{
		void Visit(IUnit.Arclight arclight);
		void Visit(IUnit.Crawler crawler);
		void Visit(IUnit.Fang fang);
		void Visit(IUnit.FireBadger badger);
		void Visit(IUnit.Fortress fortress);
		void Visit(IUnit.Hacker hacker);
		void Visit(IUnit.Marksman marksman);
		void Visit(IUnit.MeltingPoint meltingPoint);
		void Visit(IUnit.Mustang mustang);
		void Visit(IUnit.Overlord overlord);
		void Visit(IUnit.Phoenix phoenix);
		void Visit(IUnit.Rhino rhino);
		void Visit(IUnit.Sandworm sandworm);
		void Visit(IUnit.Scorpion scorpion);
		void Visit(IUnit.Sabertooth sabertooth);
		void Visit(IUnit.Sledgehammer sledgehammer);
		void Visit(IUnit.Steelball steelball);
		void Visit(IUnit.Stormcaller stormcaller);
		void Visit(IUnit.Tarantula tarantula);
		void Visit(IUnit.Typhoon typhoon);
		void Visit(IUnit.Vulcan vulcan);
		void Visit(IUnit.WarFactory warFactory);
		void Visit(IUnit.Wasp wasp);
		void Visit(IUnit.Wraith wraith);
	}
}
