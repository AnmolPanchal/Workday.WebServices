using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Award_Personnel_ResponsibilitiesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Award_Personnel_Responsibilities_RequestType Get_Award_Personnel_Responsibilities_Request;

		public Get_Award_Personnel_ResponsibilitiesInput()
		{
		}

		public Get_Award_Personnel_ResponsibilitiesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Personnel_Responsibilities_RequestType Get_Award_Personnel_Responsibilities_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Award_Personnel_Responsibilities_Request = Get_Award_Personnel_Responsibilities_Request;
		}
	}
}