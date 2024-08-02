namespace Mechabellum.Build
{
	using Unit;

	public class UnitRatingAnalyzerProvider
	{
		public void Add(UnitType type, IUnitRatingAnalyzer analyzer)
		{
			dic.Add(type, analyzer);
		}

		private readonly Dictionary<UnitType, IUnitRatingAnalyzer> dic = new Dictionary<UnitType, IUnitRatingAnalyzer>();

		public IUnitRatingAnalyzer GetAnalyzer(UnitType type)
		{
			return dic[type];
		}
	}
}
