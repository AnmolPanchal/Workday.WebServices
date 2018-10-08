using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Register_AssetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Register_Asset_RequestType Register_Asset_Request;

		public Register_AssetInput()
		{
		}

		public Register_AssetInput(Workday_Common_HeaderType Workday_Common_Header, Register_Asset_RequestType Register_Asset_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Register_Asset_Request = Register_Asset_Request;
		}
	}
}
