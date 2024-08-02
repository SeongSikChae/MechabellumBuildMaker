namespace Mechabellum.Unit
{
	public interface IUnit
	{
		UnitType Type { get; }
		Skill FirstSkill { get; }
		Skill SecondSkill { get; }
		Skill ThirdSkill { get; }
		Skill FourthSkill { get; }

		void Accept(IUnitVisitor visitor);

		public sealed class Arclight(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Arclight() : this (Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Arclight;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Crawler(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Crawler() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Crawler;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Fang(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Fang() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Fang;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class FireBadger(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public FireBadger() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.FireBadger;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Fortress(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Fortress() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Fortress;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Hacker(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Hacker() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Hacker;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Marksman(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Marksman() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Marksman;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class MeltingPoint(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public MeltingPoint() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.MeltingPoint;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Mustang(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Mustang() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Mustang;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Overlord(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Overlord() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Overlord;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Phoenix(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Phoenix() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Phoenix;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Rhino(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Rhino() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Rhino;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Sandworm(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Sandworm() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Sandworm;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Scorpion(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Scorpion() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Scorpion;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Sabertooth(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Sabertooth() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Sabertooth;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Sledgehammer(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Sledgehammer() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Sledgehammer;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Steelball(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Steelball() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Steelball;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Stormcaller(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Stormcaller() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Stormcaller;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Tarantula(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Tarantula() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Tarantula;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Typhoon(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Typhoon() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Typhoon;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Vulcan(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Vulcan() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Vulcan;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class WarFactory(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public WarFactory() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.WarFactory;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Wasp(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Wasp() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Wasp;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}

		public sealed class Wraith(Skill firstSkill, Skill secondSkill, Skill thirdSkill, Skill fourthSkill) : IUnit
		{
			public Wraith() : this(Skill.None, Skill.None, Skill.None, Skill.None) { }

			public UnitType Type => UnitType.Wraith;
			public Skill FirstSkill => firstSkill;
			public Skill SecondSkill => secondSkill;
			public Skill ThirdSkill => thirdSkill;
			public Skill FourthSkill => fourthSkill;

			public void Accept(IUnitVisitor visitor)
			{
				visitor.Visit(this);
			}
		}
	}
}
