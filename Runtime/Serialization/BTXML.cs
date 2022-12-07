// smidgens @ github

namespace Smidgenomics.Unity.BT.Serialization
{
	/// <summary>
	/// Optional utilities extracting BT definition from XML
	/// </summary>
	internal static class BTXML
	{
		

		public struct DefinitionParseOptions
		{
			public string xml;
		}

		/// <summary>
		/// Parse XML definition of tree
		/// </summary>
		public static bool TryParseDefinition(in DefinitionParseOptions options, out IBTDefinition r)
		{
			throw new System.NotImplementedException();
		}
	}
}

namespace Smidgenomics.Unity.BT.Serialization
{
	using System.Collections.Generic;

	// 
	public interface IBTDefinition
	{

	}

	public enum NodeType
	{
		Sequence,
		Selector,
		Decorator,
		Leaf,
	}

	/// <summary>
	/// Deserialized BT structure
	/// </summary>
	internal class BTDefinition : IBTDefinition
	{
		public Dictionary<string, Node> nodes = new Dictionary<string, Node>();

		public class Node
		{
			public string id;
			public NodeType type;
		}
	}
}