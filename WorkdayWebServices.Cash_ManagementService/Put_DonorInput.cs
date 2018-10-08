using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Cash_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_DonorInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Donor_RequestType Put_Donor_Request;

		public Put_DonorInput()
		{
		}

		public Put_DonorInput(Workday_Common_HeaderType Workday_Common_Header, Put_Donor_RequestType Put_Donor_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Donor_Request = Put_Donor_Request;
		}
	}
}
