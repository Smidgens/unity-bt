// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Behaviour tree node
	/// </summary>
	public interface IBTNode
	{
		BTResult Tick();
	}
}