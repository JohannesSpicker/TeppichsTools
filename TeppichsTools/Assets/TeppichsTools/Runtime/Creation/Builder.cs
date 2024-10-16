namespace TeppichsTools.Creation
{
	public abstract class Builder<T>
	{
		protected abstract T Build();

		public static implicit operator T(Builder<T> builder) => builder.Build();
	}
}