using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Customer_CategoryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Customer_Category_RequestType Put_Customer_Category_Request;

		public Put_Customer_CategoryInput()
		{
		}

		public Put_Customer_CategoryInput(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Category_RequestType Put_Customer_Category_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Customer_Category_Request = Put_Customer_Category_Request;
		}
	}
}
