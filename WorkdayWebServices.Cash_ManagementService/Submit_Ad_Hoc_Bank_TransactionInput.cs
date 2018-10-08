using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Cash_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Ad_Hoc_Bank_TransactionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Ad_hoc_Bank_Transaction_RequestType Submit_Ad_hoc_Bank_Transaction_Request;

		public Submit_Ad_Hoc_Bank_TransactionInput()
		{
		}

		public Submit_Ad_Hoc_Bank_TransactionInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Ad_hoc_Bank_Transaction_RequestType Submit_Ad_hoc_Bank_Transaction_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Ad_hoc_Bank_Transaction_Request = Submit_Ad_hoc_Bank_Transaction_Request;
		}
	}
}
