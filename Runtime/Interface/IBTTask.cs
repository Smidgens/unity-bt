// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Internal API
	/// </summary>
	public interface IBTTaskInternals
	{

	}
	
	/// <summary>
	/// Custom task logic
	/// </summary>
	public interface IBTTask : IBTTaskInternals
	{
		BTResult OnTick();
		void OnActivate();
		void OnDeactivate();
	}
}