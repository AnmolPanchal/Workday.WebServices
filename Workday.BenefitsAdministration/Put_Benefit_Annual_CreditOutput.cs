using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Benefits_AdministrationService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Benefit_Annual_CreditOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Benefit_Annual_Credit_ResponseType Put_Benefit_Annual_Credit_Response;

		public Put_Benefit_Annual_CreditOutput()
		{
		}

		public Put_Benefit_Annual_CreditOutput(Put_Benefit_Annual_Credit_ResponseType Put_Benefit_Annual_Credit_Response)
		{
			this.Put_Benefit_Annual_Credit_Response = Put_Benefit_Annual_Credit_Response;
		}
	}
}
