// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Custom task logic
	/// </summary>
	public interface IBTTask
	{
		/// <summary>
		/// Tick handler
		/// </summary>
		BTResult Tick();
	}
}