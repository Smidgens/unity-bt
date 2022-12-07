// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Blackboard operations
	/// </summary>
	internal interface IBlackboard
	{
		/// <summary>
		/// Retrieve handle to property in BB
		/// </summary>
		/// <typeparam name="T">Property type</typeparam>
		/// <param name="key">Property key</param>
		/// <returns>Property</returns>
		IBlackboardProperty<T> GetProperty<T>(IBlackboardKey key);
	}
}