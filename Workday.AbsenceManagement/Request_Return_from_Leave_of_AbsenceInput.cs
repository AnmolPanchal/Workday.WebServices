using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Absence_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Request_Return_from_Leave_of_AbsenceInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Request_Return_from_Leave_of_Absence_RequestType Request_Return_from_Leave_of_Absence_Request;

		public Request_Return_from_Leave_of_AbsenceInput()
		{
		}

		public Request_Return_from_Leave_of_AbsenceInput(Workday_Common_HeaderType Workday_Common_Header, Request_Return_from_Leave_of_Absence_RequestType Request_Return_from_Leave_of_Absence_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Request_Return_from_Leave_of_Absence_Request = Request_Return_from_Leave_of_Absence_Request;
		}
	}
}
