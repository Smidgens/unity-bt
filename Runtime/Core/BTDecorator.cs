// smidgens @ github

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Concrete decorator, applies custom filter
	/// </summary>
	internal sealed class BTDecorator : BTNode, IBTDecorator
	{
		public BTDecorator(IBTNode child, IBTFilter filter)
		{
			_filter = filter;
			_child = child;
		}

		public override BTResult Tick()
		{
			// run pre-condition
			BTResult preResult = _filter.PreTick();

			// precondition failed or still busy
			if(preResult != BTResult.Success) { return preResult; }
			
			// pass result of child tick to filter
			return _filter.Tick(_child.Tick());
		}

		// custom precondition
		private IBTFilter _filter = null;

		// filtered child node
		private IBTNode _child = null;

	}
}