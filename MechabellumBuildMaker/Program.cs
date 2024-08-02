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
			provider.Add(Unit.UnitType.Crawler, new IUnitRatingAnalyzer.CrawlerRatingAnalyzer());

			BuildMaker maker = new BuildMaker(provider);
			Dictionary<string, HashSet<UnitType>> dic = maker.Make(
				new IUnit.Arclight(), 
				[
					new IUnit.Crawler(Skill.MechanicalRage, Skill.None, Skill.None, Skill.None),
					new IUnit.Phoenix(),
					new IUnit.Steelball(),
					new IUnit.Sandworm()
				]);

			foreach (KeyValuePair<string, HashSet<UnitType>> pair in dic)
			{
				Console.WriteLine($"Rating: {pair.Key}");
				Console.WriteLine($"[{string.Join(',', pair.Value.Select(t => Enum.GetName(t)))}]");
			}
		}
	}
}
