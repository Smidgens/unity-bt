// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Custom task logic
	/// </summary>
	public abstract class BTTask : IBTTask
	{
		public virtual void OnActivate() { }
		public virtual BTResult OnTick() => BTResult.Success;
		public virtual void OnDeactivate() { }
	}
}