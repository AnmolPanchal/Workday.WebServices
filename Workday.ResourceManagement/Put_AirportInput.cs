using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_AirportInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Airport_RequestType Put_Airport_Request;

		public Put_AirportInput()
		{
		}

		public Put_AirportInput(Workday_Common_HeaderType Workday_Common_Header, Put_Airport_RequestType Put_Airport_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Airport_Request = Put_Airport_Request;
		}
	}
}
