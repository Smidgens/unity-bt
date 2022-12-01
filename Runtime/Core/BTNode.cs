// smidgens @ github

#pragma warning disable 0414

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Node base class
	/// </summary>
	public abstract class BTNode : IBTNode
	{
		/// <summary>
		/// Node activated
		/// </summary>
		public virtual void Activate() { }

		/// <summary>
		/// Node ticked
		/// </summary>
		public virtual BTResult Tick() => BTResult.Success;

		/// <summary>
		/// Node deactivated
		/// </summary>
		public virtual void Deactivate() { }


		/* ==========================
		======== Internal API =======
		========================== */

		int IBTNodeInternals.Index => -1;
		bool IBTNodeInternals.Active => false;
		int IBTNodeInternals.Depth => -1;

	}
}