using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Transaction_Tax_Item_GroupsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Transaction_Tax_Item_Groups_ResponseType Get_Transaction_Tax_Item_Groups_Response;

		public Get_Transaction_Tax_Item_GroupsOutput()
		{
		}

		public Get_Transaction_Tax_Item_GroupsOutput(Get_Transaction_Tax_Item_Groups_ResponseType Get_Transaction_Tax_Item_Groups_Response)
		{
			this.Get_Transaction_Tax_Item_Groups_Response = Get_Transaction_Tax_Item_Groups_Response;
		}
	}
}