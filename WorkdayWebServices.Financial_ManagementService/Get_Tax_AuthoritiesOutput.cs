using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Tax_AuthoritiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Tax_Authorities_ResponseType Get_Tax_Authorities_Response;

		public Get_Tax_AuthoritiesOutput()
		{
		}

		public Get_Tax_AuthoritiesOutput(Get_Tax_Authorities_ResponseType Get_Tax_Authorities_Response)
		{
			this.Get_Tax_Authorities_Response = Get_Tax_Authorities_Response;
		}
	}
}
