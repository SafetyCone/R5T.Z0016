using System;

using R5T.T0131;


namespace R5T.Z0016
{
	[ValuesMarker]
	public partial interface IJustifications : IValuesMarker
	{
		public const string ExtensionsCanBeWithoutNamespaces_Constant = "Extension methods can be in the global namespace.";


		public string ExtensionsCanBeWithoutNamespaces => IJustifications.ExtensionsCanBeWithoutNamespaces_Constant;
	}
}