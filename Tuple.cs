
using System;

namespace Algebraics
{
	public struct Tuple<T1, T2>
	{
		public Tuple(T1 item1, T2 item2)
		{
			Item1 = item1;
			Item2 = item2;
		}

		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
	
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static bool operator ==(Tuple<T1, T2> left, Tuple<T1, T2> right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(Tuple<T1, T2> left, Tuple<T1, T2> right)
		{
			return !left.Equals(right);
		}
	}

	public struct Tuple<T1, T2, T3>
	{
		public Tuple(T1 item1, T2 item2,  T3 item3)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
		}

		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
	
		
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static bool operator ==(Tuple<T1, T2, T3> left, Tuple<T1, T2, T3> right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(Tuple<T1, T2, T3> left, Tuple<T1, T2, T3> right)
		{
			return !left.Equals(right);
		}
	}

	public struct Tuple<T1, T2, T3, T4>
	{
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
		}

		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static bool operator ==(Tuple<T1, T2, T3, T4> left, Tuple<T1, T2, T3, T4> right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(Tuple<T1, T2, T3, T4> left, Tuple<T1, T2, T3, T4> right)
		{
			return !left.Equals(right);
		}
	}

	public struct Tuple<T1, T2, T3, T4, T5>
	{
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			Item1 = item1; 
			Item2 = item2; 
			Item3 = item3; 
			Item4 = item4; 
			Item5 = item5; 
		}

		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }

		
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static bool operator ==(Tuple<T1, T2, T3, T4, T5> left, Tuple<T1, T2, T3, T4, T5> right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(Tuple<T1, T2, T3, T4, T5> left, Tuple<T1, T2, T3, T4, T5> right)
		{
			return !left.Equals(right);
		}
	}

	public struct Tuple<T1, T2, T3, T4, T5, T6>
	{
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
			Item5 = item5;
			Item6 = item6;
		}

		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
	
		
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static bool operator ==(Tuple<T1, T2, T3, T4, T5, T6> left, Tuple<T1, T2, T3, T4, T5, T6> right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(Tuple<T1, T2, T3, T4, T5, T6> left, Tuple<T1, T2, T3, T4, T5, T6> right)
		{
			return !left.Equals(right);
		}
	}

	public static class Tuple
	{
		public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
		{
			return new Tuple<T1, T2>(item1, item2);
		}

		public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
		{
			return new Tuple<T1, T2, T3>(item1, item2, item3);
		}

		public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
		}

		public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			return new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
		}

		public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			return new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
		}
	}
}