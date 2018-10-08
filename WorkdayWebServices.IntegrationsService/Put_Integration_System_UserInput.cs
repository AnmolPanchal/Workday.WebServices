using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.IntegrationsService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Integration_System_UserInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Integration_System_User_RequestType Put_Integration_System_User_Request;

		public Put_Integration_System_UserInput()
		{
		}

		public Put_Integration_System_UserInput(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_System_User_RequestType Put_Integration_System_User_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Integration_System_User_Request = Put_Integration_System_User_Request;
		}
	}
}
