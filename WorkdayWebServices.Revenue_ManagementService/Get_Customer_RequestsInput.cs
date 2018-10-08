using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Customer_RequestsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Customer_Requests_RequestType Get_Customer_Requests_Request;

		public Get_Customer_RequestsInput()
		{
		}

		public Get_Customer_RequestsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Requests_RequestType Get_Customer_Requests_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Customer_Requests_Request = Get_Customer_Requests_Request;
		}
	}
}