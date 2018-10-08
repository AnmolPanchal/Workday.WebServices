using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Asset_SharesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Asset_Shares_RequestType Get_Asset_Shares_Request;

		public Get_Asset_SharesInput()
		{
		}

		public Get_Asset_SharesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Asset_Shares_RequestType Get_Asset_Shares_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Asset_Shares_Request = Get_Asset_Shares_Request;
		}
	}
}
