using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Asset_Pooling_RulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Asset_Pooling_Rules_ResponseType Get_Asset_Pooling_Rules_Response;

		public Get_Asset_Pooling_RulesOutput()
		{
		}

		public Get_Asset_Pooling_RulesOutput(Get_Asset_Pooling_Rules_ResponseType Get_Asset_Pooling_Rules_Response)
		{
			this.Get_Asset_Pooling_Rules_Response = Get_Asset_Pooling_Rules_Response;
		}
	}
}
