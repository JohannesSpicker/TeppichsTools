namespace TeppichsTools.Creation.Pools
{
	public interface IObjectPool<T>
	{
		/// <summary>
		///     Provides an object.
		/// </summary>
		T Next();

		/// <summary>
		///     Returns an object to the pool.
		/// </summary>
		void Release(T released);

		/// <summary>
		///     Culls all currently unused objects.
		/// </summary>
		void Cull();
	}
}