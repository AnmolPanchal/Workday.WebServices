using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Customer_GroupsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Customer_Groups_ResponseType Get_Customer_Groups_Response;

		public Get_Customer_GroupsOutput()
		{
		}

		public Get_Customer_GroupsOutput(Get_Customer_Groups_ResponseType Get_Customer_Groups_Response)
		{
			this.Get_Customer_Groups_Response = Get_Customer_Groups_Response;
		}
	}
}
