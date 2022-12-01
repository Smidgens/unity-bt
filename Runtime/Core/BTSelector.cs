// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Selects first child that does not return error
	/// </summary>
	internal sealed class BTSelector : BTComposite
	{
		public BTSelector(IBTNode[] children) : base(children)
		{

		}

		public override sealed void Activate()
		{
			_step = 0;
			_lastResult = BTResult.Running;
		}

		public override sealed BTResult Tick()
		{
			if (_step >= _ChildCount) { return _lastResult; }

			// evaluate current child node
			IBTNode child = GetChildAt(_step);

			_lastResult = child.Tick();

			// child still active
			if (_lastResult == BTResult.Running) { return BTResult.Running; }
			
			// break on non-success
			_step = _lastResult != BTResult.Success
			? _ChildCount // break
			: _step + 1; // continue to next
			
			// continue to next node
			return _lastResult;
		}

		/// <summary>
		/// Step
		/// </summary>
		private int _step = 0;

		/// <summary>
		/// Cached result
		/// </summary>
		private BTResult _lastResult = BTResult.Running;
	}
}