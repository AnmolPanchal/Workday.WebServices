using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_RegionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Regions_ResponseType Get_Regions_Response;

		public Get_RegionsOutput()
		{
		}

		public Get_RegionsOutput(Get_Regions_ResponseType Get_Regions_Response)
		{
			this.Get_Regions_Response = Get_Regions_Response;
		}
	}
}
