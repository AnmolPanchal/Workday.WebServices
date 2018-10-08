using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Award_Personnel_ResponsibilityInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Award_Personnel_Responsibility_RequestType Put_Award_Personnel_Responsibility_Request;

		public Put_Award_Personnel_ResponsibilityInput()
		{
		}

		public Put_Award_Personnel_ResponsibilityInput(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Personnel_Responsibility_RequestType Put_Award_Personnel_Responsibility_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Award_Personnel_Responsibility_Request = Put_Award_Personnel_Responsibility_Request;
		}
	}
}