// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Behaviour tree node
	/// </summary>
	public interface IBTNode : IBTNodeInternals
	{
		void Activate();
		void Deactivate();
		BTResult Tick();
	}
}

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// BTNode internal API
	/// </summary>
	public interface IBTNodeInternals
	{
		/// <summary>
		/// Toggle node
		/// </summary>
		internal bool Active { get; }

		/// <summary>
		/// Depth in tree
		/// </summary>
		internal int Depth { get; }

		/// <summary>
		/// Index in parent
		/// </summary>
		internal int Index { get; }
	}
}