// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Execution context
	/// </summary>
	internal interface IBTContext
	{
		/// <summary>
		/// Object the BT is bound to (scene object, asset, etc.)
		/// </summary>
		object Owner { get; }

		/// <summary>
		/// Blackboard attached to BT
		/// </summary>
		IBTBlackboard Blackboard { get; }
	}
}