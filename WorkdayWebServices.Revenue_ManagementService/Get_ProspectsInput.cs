using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ProspectsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Prospects_RequestType Get_Prospects_Request;

		public Get_ProspectsInput()
		{
		}

		public Get_ProspectsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Prospects_RequestType Get_Prospects_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Prospects_Request = Get_Prospects_Request;
		}
	}
}
