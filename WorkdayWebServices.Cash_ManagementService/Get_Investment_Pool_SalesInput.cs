using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Cash_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Investment_Pool_SalesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Investment_Pool_Sales_RequestType Get_Investment_Pool_Sales_Request;

		public Get_Investment_Pool_SalesInput()
		{
		}

		public Get_Investment_Pool_SalesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Investment_Pool_Sales_RequestType Get_Investment_Pool_Sales_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Investment_Pool_Sales_Request = Get_Investment_Pool_Sales_Request;
		}
	}
}
