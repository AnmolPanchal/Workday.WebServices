using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Withholding_Tax_CodesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Withholding_Tax_Codes_ResponseType Get_Withholding_Tax_Codes_Response;

		public Get_Withholding_Tax_CodesOutput()
		{
		}

		public Get_Withholding_Tax_CodesOutput(Get_Withholding_Tax_Codes_ResponseType Get_Withholding_Tax_Codes_Response)
		{
			this.Get_Withholding_Tax_Codes_Response = Get_Withholding_Tax_Codes_Response;
		}
	}
}
