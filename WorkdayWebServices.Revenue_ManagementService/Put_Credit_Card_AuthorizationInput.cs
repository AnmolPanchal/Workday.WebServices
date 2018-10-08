using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Credit_Card_AuthorizationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Credit_Card_Authorization_RequestType Put_Credit_Card_Authorization_Request;

		public Put_Credit_Card_AuthorizationInput()
		{
		}

		public Put_Credit_Card_AuthorizationInput(Workday_Common_HeaderType Workday_Common_Header, Put_Credit_Card_Authorization_RequestType Put_Credit_Card_Authorization_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Credit_Card_Authorization_Request = Put_Credit_Card_Authorization_Request;
		}
	}
}