// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Leaf node, execute task
	/// </summary>
	internal sealed class BTLeaf : BTNode
	{
		public BTLeaf(IBTTask task) => _task = task;

		public override sealed BTResult Tick() => _task.Tick();

		private IBTTask _task = null;
	}
}