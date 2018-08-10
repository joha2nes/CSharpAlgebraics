using System;

namespace Algebraics
{
	public struct Maybe<T>
	{
		public Maybe(T value)
		{
			this.value = value;
			this.hasValue = true;
		}

		private T value;
		private bool hasValue;

		public bool HasValue { get { return hasValue; } }

		public T FromMaybe(T defaultValue)
		{
			return hasValue ? value : defaultValue;
		}

		public Maybe<TResult> Select<TResult>(Func<T, TResult> selector)
		{
			return hasValue ? Maybe.Just(selector(value)) : Maybe.Nothing<TResult>();
		}

		public Maybe<TResult> SelectMaybe<TResult>(Func<T, Maybe<TResult>> selector)
		{
			return hasValue ? selector(value) : Maybe.Nothing<TResult>();
		}

		public Maybe<T> Where(Func<T, bool> predicate)
		{
			return hasValue && predicate(value) ? Maybe.Just(value) : Maybe.Nothing<T>();
		}

		public Maybe<TResult> CombineWith<TOther, TResult>(Maybe<TOther> other, Func<T, TOther, TResult> combiner)
		{
			return hasValue && other.hasValue ?
				Maybe.Just(combiner(value, other.value)) :
				Maybe.Nothing<TResult>();
		}

		public override string ToString()
		{
			return hasValue ? string.Format("Just({0})", value) : "Nothing";
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static bool operator ==(Maybe<T> left, Maybe<T> right)
		{
			return left.Equals(right);
		}
		
		public static bool operator !=(Maybe<T> left, Maybe<T> right)
		{
			return !left.Equals(right);
		}
	}

	public static class Maybe
	{
		public static Maybe<T> Nothing<T>()
		{
			return new Maybe<T>();
		}

		public static Maybe<T> Just<T>(T value)
		{
			return new Maybe<T>(value);
		}
	}
}