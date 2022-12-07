// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Execute nodes in sequence
	/// </summary>
	internal sealed class BTSequence : BTComposite
	{
		public BTSequence(IBTNode[] children) : base(children)
		{ }

		/// <summary>
		/// Update
		/// </summary>
		public override sealed BTResult Tick()
		{
			// get child at step
			IBTNode node = _children[_step];

			// evaluate current child node
			BTResult childResult = node.Tick();

			// child failed/still running
			if (childResult != BTResult.Success) { return childResult; }

			// move to next
			_step++;

			// reached end, yield success
			if (_step >= _children.Length)
			{
				_step = 0;
				return BTResult.Success;
			}

			// still busy...
			return BTResult.Running;
		}

		/// <summary>
		/// Child currently executing child
		/// </summary>
		private int _step = 0;
	}
}