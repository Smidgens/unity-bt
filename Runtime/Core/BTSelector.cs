// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Selects first child that does not return error
	/// </summary>
	internal sealed class BTSelector : BTComposite
	{
		public BTSelector(IBTNode[] children) : base(children) {}
	
		public override sealed BTResult Tick()
		{
			// evaluate current child node
			IBTNode child = _children[_step];

			// process child
			BTResult _lastResult = child.Tick();

			// child completed or is busy
			if(_lastResult != BTResult.Failure) { return _lastResult; }

			// next child
			_step++;

			// end of list -> reset and fail
			if(_step >= _children.Length)
			{
				_step = 0;
				return BTResult.Failure;
			}

			// still processing
			return BTResult.Running;
		}

		// current child
		private int _step = 0;
	}
}