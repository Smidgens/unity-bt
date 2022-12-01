// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Custom decorator logic
	/// </summary>
	public abstract class BTNodeFilter : IBTNodeFilter
	{
		public virtual BTResult OnBeforeTick() => BTResult.Success;
		public virtual BTResult OnAfterTick(BTResult result) => result;
		public virtual void OnCeaseRelevant() { }
		public virtual void OnRelevant() { }
	}
}