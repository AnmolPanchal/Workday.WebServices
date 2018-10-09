using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_HotelsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Hotels_RequestType Get_Hotels_Request;

		public Get_HotelsInput()
		{
		}

		public Get_HotelsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Hotels_RequestType Get_Hotels_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Hotels_Request = Get_Hotels_Request;
		}
	}
}
