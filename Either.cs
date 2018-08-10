using System;

namespace Algebraics
{
	public struct Either<TLeft, TRight>
	{
		public Either(TLeft leftValue)
		{
			isRight = false;
			left = leftValue;
			right = default(TRight);
		}

		public Either(TRight rightValue)
		{
			isRight = true;
			left = default(TLeft);
			right = rightValue;
		}

		bool isRight;
		TLeft left;
		TRight right;

		public bool IsLeft { get { return !isRight; } }
		public bool IsRight { get { return isRight; } }
	
		public TLeft FromLeft(TLeft defaultValue)
		{
			return !isRight ? left : defaultValue;
		}

		public TRight FromRight(TRight defaultValue)
		{
			return isRight ? right : defaultValue;
		}

		public TResult Switch<TResult>(Func<TLeft, TResult> caseLeft, Func<TRight, TResult> caseRight)
		{
			return isRight ?
				caseRight(right) :
				caseLeft(left);
		}

		public Either<TLeft, TResult> Select<TResult>(Func<TRight, TResult> selector)
		{
			return isRight ?
				new Either<TLeft, TResult>(selector(right)) :
				new Either<TLeft, TResult>(left);
		}

		public Either<TLeft, TResult> SelectEither<TResult>(Func<TRight, Either<TLeft, TResult>> selector)
		{
			return isRight ?
				selector(right) :
				new Either<TLeft, TResult>(left);
		}

		public override string ToString()
		{
			return isRight ?
				string.Format("Right({0})", right) :
				string.Format("Left({0})", left);
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static bool operator ==(Either<TLeft, TRight> left, Either<TLeft, TRight> right)
		{
			return left.Equals(right);
		}
		
		public static bool operator !=(Either<TLeft, TRight> left, Either<TLeft, TRight> right)
		{
			return !left.Equals(right);
		}
	}

	public static class Either
	{
		public static Either<TLeft, TRight> Left<TLeft, TRight>(TLeft value)
		{
			return new Either<TLeft, TRight>(value);
		}
		
		public static Either<TLeft, TRight> Right<TLeft, TRight>(TRight value)
		{
			return new Either<TLeft, TRight>(value);
		}
	}
}