using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Payroll_GBRService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_IDOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_ID_ResponseType Put_Payroll_ID_Response;

		public Put_Payroll_IDOutput()
		{
		}

		public Put_Payroll_IDOutput(Put_Payroll_ID_ResponseType Put_Payroll_ID_Response)
		{
			this.Put_Payroll_ID_Response = Put_Payroll_ID_Response;
		}
	}
}