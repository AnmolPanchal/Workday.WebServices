using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Customer_Contract_Renewal_TermsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Customer_Contract_Renewal_Terms_ResponseType Get_Customer_Contract_Renewal_Terms_Response;

		public Get_Customer_Contract_Renewal_TermsOutput()
		{
		}

		public Get_Customer_Contract_Renewal_TermsOutput(Get_Customer_Contract_Renewal_Terms_ResponseType Get_Customer_Contract_Renewal_Terms_Response)
		{
			this.Get_Customer_Contract_Renewal_Terms_Response = Get_Customer_Contract_Renewal_Terms_Response;
		}
	}
}
