using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Request_for_Quote_AwardInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Request_for_Quote_Award_RequestType Submit_Request_for_Quote_Award_Request;

		public Submit_Request_for_Quote_AwardInput()
		{
		}

		public Submit_Request_for_Quote_AwardInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Request_for_Quote_Award_RequestType Submit_Request_for_Quote_Award_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Request_for_Quote_Award_Request = Submit_Request_for_Quote_Award_Request;
		}
	}
}
