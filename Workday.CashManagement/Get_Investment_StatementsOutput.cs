using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Cash_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Investment_StatementsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Investment_Statements_ResponseType Get_Investment_Statements_Response;

		public Get_Investment_StatementsOutput()
		{
		}

		public Get_Investment_StatementsOutput(Get_Investment_Statements_ResponseType Get_Investment_Statements_Response)
		{
			this.Get_Investment_Statements_Response = Get_Investment_Statements_Response;
		}
	}
}
