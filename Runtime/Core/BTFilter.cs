// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Custom decorator logic
	/// </summary>
	internal abstract class BTFilter : IBTFilter
	{
		public virtual BTResult PreTick() => BTResult.Success;
		public virtual BTResult Tick(BTResult result) => result;
	}
}