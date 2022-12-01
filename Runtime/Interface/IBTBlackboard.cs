// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Blackboard operations
	/// </summary>
	internal interface IBTBlackboard
	{
		T Read<T>(in IBTBlackboardKey key);
		void Write<T>(in IBTBlackboardKey key, in T v);
	}
}