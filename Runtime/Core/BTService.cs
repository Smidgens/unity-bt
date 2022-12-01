// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Node "background" process. Activates on branch becoming active.
	/// </summary>
	internal abstract class BTService : IBTService
	{
		public float Interval => 0.5f;

		/// <summary>
		/// Branch enabled
		/// </summary>
		public virtual void OnRelevant() { }

		/// <summary>
		/// Ticked
		/// </summary>
		public virtual void OnTick() { }

		/// <summary>
		/// Branch disabled
		/// </summary>
		public virtual void OnCeaseRelevant() { }
	}
}