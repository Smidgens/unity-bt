// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Leaf node, execute task
	/// </summary>
	public sealed class BTLeaf : BTNode
	{
		public BTLeaf(IBTTask task)
		{
			_task = task;
		}

		public override sealed void Activate()
		{
			_task.OnActivate();
		}

		public override sealed BTResult Tick()
		{
			return _task.OnTick();
		}

		public sealed override void Deactivate()
		{
			_task.OnDeactivate();
		}


		private IBTTask _task = null;
	}
}