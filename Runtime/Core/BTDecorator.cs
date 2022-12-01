// smidgens @ github

#pragma warning disable 0414

namespace Smidgenomics.Unity.BT
{
	/// <summary>
	/// Single child node
	/// </summary>
	internal sealed class BTDecorator : BTAuxiliary
	{
		public BTDecorator(IBTNode child, IBTNodeFilter filter) : base(child)
		{
			_filter = filter;
		}

		public override void Activate()
		{
			_filter.OnRelevant();
		}

		public override BTResult Tick()
		{
			// run pre-condition
			BTResult preResult = _filter.OnBeforeTick();
			if(preResult != BTResult.Success)
			{
				return preResult;
			}

			BTResult childResult = _Child.Tick();

			return _filter.OnAfterTick(childResult);
		}

		public override void Deactivate()
		{
			_filter.OnCeaseRelevant();
		}

		private IBTNodeFilter _filter = null;

	}
}