using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Loan_Referral_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Loan_Referral_Type_ResponseType Put_Loan_Referral_Type_Response;

		public Put_Loan_Referral_TypeOutput()
		{
		}

		public Put_Loan_Referral_TypeOutput(Put_Loan_Referral_Type_ResponseType Put_Loan_Referral_Type_Response)
		{
			this.Put_Loan_Referral_Type_Response = Put_Loan_Referral_Type_Response;
		}
	}
}
