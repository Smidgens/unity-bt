// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Behaviour tree definition
	/// </summary>
	public sealed class BT : IBT
	{
		public BT(IBTComposite root)
		{
			_root = root;
		}

		public void Start()
		{
			_root.Activate();
		}

		public void Tick()
		{
			if (!_started)
			{
				_root.Activate();
				_started = false;
			}

			BTResult result = _root.Tick();

			if(result != BTResult.Running)
			{
				_root.Deactivate();
				_started = false;
			}
		}

		private bool _started = false;
		private IBTComposite _root = null;


	}
}