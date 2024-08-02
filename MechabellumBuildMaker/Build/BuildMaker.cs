namespace Mechabellum.Build
{
	using Unit;

	public sealed class BuildMaker(UnitRatingAnalyzerProvider provider)
	{
		public Dictionary<string, HashSet<UnitType>> Make(IUnit unit, List<IUnit> unitList)
		{
			Dictionary<string, HashSet<UnitType>> dic = new Dictionary<string, HashSet<UnitType>>();
			IUnitRatingAnalyzer analyzer = provider.GetAnalyzer(unit.Type);
			foreach (IUnit myUnit in unitList)
			{
				UnitRating unitRating = analyzer.Analyze(myUnit);
				if (!dic.TryGetValue(unitRating.Rating, out HashSet<UnitType>? hashSet))
				{
					hashSet = new HashSet<UnitType>();
					dic.Add(unitRating.Rating, hashSet);
				}
				hashSet.Add(myUnit.Type);
			}
			return dic;
		}
	}
}
