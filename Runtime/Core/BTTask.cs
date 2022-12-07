// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Custom task logic
	/// </summary>
	internal abstract class BTTask : IBTTask
	{
		public virtual BTResult Tick() => BTResult.Success;
	}
}