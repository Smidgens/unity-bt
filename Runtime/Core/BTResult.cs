// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Node execution result
	/// </summary>
	public enum BTResult
	{
		/// <summary>
		/// Finished with success
		/// </summary>
		Success = 0,
		/// <summary>
		/// Finished with failure
		/// </summary>
		Failure = 1,
		/// <summary>
		/// Still running
		/// </summary>
		Running = 2,
		/// <summary>
		/// Finished with abort failure
		/// Note: not used for anything yet, will be treated as failure
		/// </summary>
		Aborted = 3,
		
	}
}