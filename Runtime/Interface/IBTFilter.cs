// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Pass through logic for node result
	/// used to implement decorator like logic
	/// </summary>
	public interface IBTNodeFilter
	{
		void OnRelevant();
		void OnCeaseRelevant();

		/// <summary>
		/// Run evaluation before ticking node
		/// </summary>
		/// <returns></returns>
		BTResult OnBeforeTick();

		BTResult OnAfterTick(BTResult result);
	}
}


namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Internal API
	/// </summary>
	public interface IBTNodeFilterInternals : IBTContextBound
	{
		
	}
}