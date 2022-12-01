// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	using TickFn = System.Func<BTResult>;

	/// <summary>
	/// Execute nodes in sequence
	/// </summary>
	public sealed class BTSequence : BTComposite
	{
		public BTSequence(IBTNode[] children) : base(children)
		{ }

		/// <summary>
		/// Initialize
		/// </summary>
		public override sealed void Activate()
		{
			_step = 0;
			_result = BTResult.Running;
			_stepActivated = false;
			_onTick = ProcessTick;
		}

		/// <summary>
		/// Update
		/// </summary>
		public override sealed BTResult Tick()
		{
			return _onTick.Invoke();
		}

		public override sealed void Deactivate()
		{
			// todo: disable active step
		}

		/// <summary>
		/// Child currently executing
		/// </summary>
		private int _step = 0;

		/// <summary>
		/// Has current node been activated 
		/// </summary>
		private bool _stepActivated = false;

		/// <summary>
		/// Result
		/// </summary>
		private BTResult _result = BTResult.Running;

		/// <summary>
		/// Lazy init
		/// </summary>
		private TickFn _onTick = null;

		/// <summary>
		/// Return cached tick result
		/// </summary>
		/// <returns></returns>
		private BTResult GetCachedResult() => _result;

		/// <summary>
		/// Active tick
		/// </summary>
		/// <returns></returns>
		private BTResult ProcessTick()
		{
			IBTNode node = GetChildAt(_step);

			if (!_stepActivated)
			{
				_stepActivated = true;
				node.Activate();
			}

			// evaluate current child node
			BTResult childResult = node.Tick();

			// child still active
			if (childResult == BTResult.Running) { return BTResult.Running; }
			else { node.Deactivate(); } // done finished, exit current node

			// non-success, or last node
			if (childResult != BTResult.Success || _step >= _ChildCount - 1)
			{
				_result = childResult;
				_onTick = GetCachedResult;
				return _result;
			}

			// move to next node
			_step++;

			_stepActivated = false;

			return BTResult.Running;
		}
	}
}