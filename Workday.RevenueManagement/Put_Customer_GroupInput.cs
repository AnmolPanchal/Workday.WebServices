using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Customer_GroupInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Customer_Group_RequestType Put_Customer_Group_Request;

		public Put_Customer_GroupInput()
		{
		}

		public Put_Customer_GroupInput(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Group_RequestType Put_Customer_Group_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Customer_Group_Request = Put_Customer_Group_Request;
		}
	}
}