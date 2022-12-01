// smidgens @ github

#pragma warning disable 0414

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Composite-type node
	/// </summary>
	public abstract class BTComposite : BTNode, IBTComposite
	{
		protected BTComposite(IBTNode[] children)
		{
			_children = children;
		}

		/// <summary>
		/// Steps
		/// </summary>
		protected int _ChildCount => _children.Length;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		protected IBTNode GetChildAt(in int i)
		{
			return _children[i];
		}

		/// <summary>
		/// Steps
		/// </summary>
		private IBTNode[] _children = null;

	}
}