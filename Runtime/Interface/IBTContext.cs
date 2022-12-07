// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Context attached to BT
	/// </summary>
	internal interface IBTContext
	{
		/// <summary>
		/// Blackboard bound to tree
		/// </summary>
		IBlackboard Blackboard { get; }
	}
}