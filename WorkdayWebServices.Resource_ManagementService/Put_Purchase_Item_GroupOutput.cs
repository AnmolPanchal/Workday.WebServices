using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Purchase_Item_GroupOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Purchase_Item_Group_ResponseType Put_Purchase_Item_Group_Response;

		public Put_Purchase_Item_GroupOutput()
		{
		}

		public Put_Purchase_Item_GroupOutput(Put_Purchase_Item_Group_ResponseType Put_Purchase_Item_Group_Response)
		{
			this.Put_Purchase_Item_Group_Response = Put_Purchase_Item_Group_Response;
		}
	}
}
