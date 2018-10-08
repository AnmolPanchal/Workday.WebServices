using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Intercompany_ProfilesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Intercompany_Profiles_ResponseType Get_Intercompany_Profiles_Response;

		public Get_Intercompany_ProfilesOutput()
		{
		}

		public Get_Intercompany_ProfilesOutput(Get_Intercompany_Profiles_ResponseType Get_Intercompany_Profiles_Response)
		{
			this.Get_Intercompany_Profiles_Response = Get_Intercompany_Profiles_Response;
		}
	}
}
