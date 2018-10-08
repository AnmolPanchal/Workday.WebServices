using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Business_Plan_DetailsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Business_Plan_Details_RequestType Get_Business_Plan_Details_Request;

		public Get_Business_Plan_DetailsInput()
		{
		}

		public Get_Business_Plan_DetailsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Plan_Details_RequestType Get_Business_Plan_Details_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Business_Plan_Details_Request = Get_Business_Plan_Details_Request;
		}
	}
}
