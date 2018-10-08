using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Cash_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Donor_ContributionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Donor_Contributions_ResponseType Get_Donor_Contributions_Response;

		public Get_Donor_ContributionsOutput()
		{
		}

		public Get_Donor_ContributionsOutput(Get_Donor_Contributions_ResponseType Get_Donor_Contributions_Response)
		{
			this.Get_Donor_Contributions_Response = Get_Donor_Contributions_Response;
		}
	}
}
