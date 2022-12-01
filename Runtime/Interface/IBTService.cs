// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// "Background" process for active BT branch
	/// </summary>
	public interface IBTService
	{
		/// <summary>
		/// Interval between ticks
		/// </summary>
		float Interval { get; }
		void OnTick();
		void OnRelevant();
		void OnCeaseRelevant();
	}
}