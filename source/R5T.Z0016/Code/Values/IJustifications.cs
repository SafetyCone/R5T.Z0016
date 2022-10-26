using System;

using R5T.T0131;


namespace R5T.Z0016
{
	[ValuesMarker]
	public partial interface IJustifications : IValuesMarker
	{
		public const string ExtensionsCanBeWithoutNamespaces_Constant = "Extension methods can be in the global namespace.";
		public const string LoggingTemplatesCanBeDynamic_Constant = "Whatever. Logging string templates *can* vary between logging calls.";


		public string ExtensionsCanBeWithoutNamespaces => IJustifications.ExtensionsCanBeWithoutNamespaces_Constant;
		public string LoggingTemplatesCanBeDynamic => IJustifications.LoggingTemplatesCanBeDynamic_Constant;
	}
}