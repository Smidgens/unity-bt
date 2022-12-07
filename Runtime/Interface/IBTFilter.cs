// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Pass through logic for node result
	/// used to implement decorator like logic
	/// </summary>
	public interface IBTFilter
	{
		/// <summary>
		/// Preprocessing before ticking child.
		/// Returning Fail will skip processing
		/// </summary>
		/// <returns></returns>
		BTResult PreTick();

		/// <summary>
		/// Evaluate result of child tick
		/// </summary>
		BTResult Tick(BTResult childResult);
	}
}