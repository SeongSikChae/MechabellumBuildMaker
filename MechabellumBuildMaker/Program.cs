namespace Mechabellum
{
	using Build;
	using Unit;

	internal class Program
	{
		static void Main(string[] args)
		{
			UnitRatingAnalyzerProvider provider = new UnitRatingAnalyzerProvider();
			provider.Add(Unit.UnitType.Arclight, new IUnitRatingAnalyzer.ArclightRatingAnalyzer());

			BuildMaker maker = new BuildMaker(provider);
			Dictionary<string, HashSet<UnitType>> dic = maker.Make(
				new IUnit.Arclight(Skill.IncreasedRange, Skill.ElectromagneticShot, Skill.ChargedShot, Skill.StrengthenDefense), 
				[
					new IUnit.Crawler(Skill.None, Skill.None, Skill.None, Skill.None),
				]);

			foreach (KeyValuePair<string, HashSet<UnitType>> pair in dic)
			{
				Console.WriteLine($"Rating: {pair.Key}");
				Console.WriteLine($"[{string.Join(',', pair.Value.Select(t => Enum.GetName(t)))}]");
			}
		}
	}
}
