// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Single-child node
	/// </summary>
	internal abstract class BTAuxiliary : BTNode
	{
		protected BTAuxiliary(IBTNode child)
		{
			_Child = child;
		}

		protected IBTNode _Child { get; private set; }
	}

}