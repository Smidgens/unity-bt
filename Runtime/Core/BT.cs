// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Runtime engine for BT
	/// </summary>
	internal sealed class BT : IBT
	{
		public BT(IBTComposite root) => _root = root;
		public BTResult Tick() => _root.Tick();
		private IBTComposite _root = null;
	}
}