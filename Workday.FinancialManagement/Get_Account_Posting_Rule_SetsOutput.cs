using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Account_Posting_Rule_SetsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Account_Posting_Rule_Sets_ResponseType Get_Account_Posting_Rule_Sets_Response;

		public Get_Account_Posting_Rule_SetsOutput()
		{
		}

		public Get_Account_Posting_Rule_SetsOutput(Get_Account_Posting_Rule_Sets_ResponseType Get_Account_Posting_Rule_Sets_Response)
		{
			this.Get_Account_Posting_Rule_Sets_Response = Get_Account_Posting_Rule_Sets_Response;
		}
	}
}