using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace WorkdayWebServices.Cash_ManagementService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType2
	{
		Distribution_Amount,
		Distribution_Balance,
		Distribution_Percentage
	}
}