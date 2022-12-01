// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Blackboard variable handle
	/// </summary>
	/// <typeparam name="T">Property type</typeparam>
	internal interface IBTBlackboardProperty<T>
	{
		T Get();
		void Set(in T v);
	}
}