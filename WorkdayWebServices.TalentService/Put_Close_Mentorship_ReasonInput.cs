using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.TalentService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Close_Mentorship_ReasonInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Close_Mentorship_Reason_RequestType Put_Close_Mentorship_Reason_Request;

		public Put_Close_Mentorship_ReasonInput()
		{
		}

		public Put_Close_Mentorship_ReasonInput(Workday_Common_HeaderType Workday_Common_Header, Put_Close_Mentorship_Reason_RequestType Put_Close_Mentorship_Reason_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Close_Mentorship_Reason_Request = Put_Close_Mentorship_Reason_Request;
		}
	}
}
