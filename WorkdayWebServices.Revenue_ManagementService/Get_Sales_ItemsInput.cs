using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Sales_ItemsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Sales_Items_RequestType Get_Sales_Items_Request;

		public Get_Sales_ItemsInput()
		{
		}

		public Get_Sales_ItemsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Sales_Items_RequestType Get_Sales_Items_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Sales_Items_Request = Get_Sales_Items_Request;
		}
	}
}
