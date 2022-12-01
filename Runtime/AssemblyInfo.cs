// smidgens @ github

using System.Runtime.CompilerServices;

// expose internals to dev assemblies
#if UNITY_EDITOR
[assembly:InternalsVisibleTo("Smidgenomics.Unity.BT.Editor")]
#endif