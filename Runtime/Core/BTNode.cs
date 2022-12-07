// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Base class for concrete tree nodes
	/// </summary>
	internal abstract class BTNode : IBTNode
	{
		public virtual BTResult Tick() => BTResult.Success;
	}
}