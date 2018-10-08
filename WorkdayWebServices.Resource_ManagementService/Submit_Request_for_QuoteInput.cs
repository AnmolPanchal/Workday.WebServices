using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Request_for_QuoteInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Request_for_Quote_RequestType Submit_Request_for_Quote_Request;

		public Submit_Request_for_QuoteInput()
		{
		}

		public Submit_Request_for_QuoteInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Request_for_Quote_RequestType Submit_Request_for_Quote_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Request_for_Quote_Request = Submit_Request_for_Quote_Request;
		}
	}
}
