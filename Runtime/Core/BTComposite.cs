// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Composite-type node
	/// </summary>
	internal abstract class BTComposite : BTNode, IBTComposite
	{
		// required init
		protected BTComposite(IBTNode[] children) => _children = children;
		
		// steps
		protected IBTNode[] _children = null;
	}
}