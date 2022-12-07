// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	using System;

	/// <summary>
	/// Utility for generating 
	/// </summary>
	public static class BTBuilder
	{
		public static IBTNode CreateSimpleLeaf(Func<bool> doneFn)
		{
			return new BTLeaf(new TickTask(() =>
			{
				if (doneFn.Invoke()) { return BTResult.Success; }
				return BTResult.Running;
			}));
		}

		public static IBTNode CreateLeaf(Func<BTResult> onTick)
		{
			return new BTLeaf(new TickTask(onTick));
		}

		public static IBTNode CreateTimer(float delay, IBTNode node)
		{
			return new BTDecorator(node, new TimerFilter(delay));
		}

		public static IBTFilter CreateTimer(float delay)
		{
			return new TimerFilter(delay);
		}

		public static IBTComposite CreateSequence(IBTNode[] nodes)
		{
			return new BTSequence(nodes);
		}

		public static IBTComposite CreateSelector(IBTNode[] nodes)
		{
			return new BTSelector(nodes);
		}

		public static IBT CreateTreeSequence(IBTNode[] nodes)
		{
			return new BT(CreateSequence(nodes));
		}

		public static IBT CreateSelectorBT(IBTNode[] nodes)
		{
			return new BT(CreateSelector(nodes));
		}


		private sealed class TimerFilter : BTFilter
		{
			public TimerFilter(float duration)
			{
				_timer = new Timer(duration);
			}

			public override BTResult PreTick()
			{
				if (_timer.Tick()) { return BTResult.Success; }
				return BTResult.Running;
			}
			private Timer _timer = null;
		}


		private sealed class Timer
		{
			public Timer(float duration) => _duration = duration;

			public bool Tick()
			{
				bool done = _timer >= _duration;
				_timer += UnityEngine.Time.deltaTime;
				if (done) { _timer = 0f; }
				return done;
			}
			private float _timer = 0f;
			private float _duration = 1f;
		}

		private sealed class TickTask : BTTask
		{
			public TickTask(Func<BTResult> tickFn) => _tickFn = tickFn;
			public override BTResult Tick() => _tickFn.Invoke();
			private Func<BTResult> _tickFn = null;
		}
	}

}