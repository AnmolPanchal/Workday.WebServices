using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.StaffingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Edit_Notice_Periods_EventInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Edit_Notice_Periods_Event_RequestType Put_Edit_Notice_Periods_Event_Request;

		public Put_Edit_Notice_Periods_EventInput()
		{
		}

		public Put_Edit_Notice_Periods_EventInput(Workday_Common_HeaderType Workday_Common_Header, Put_Edit_Notice_Periods_Event_RequestType Put_Edit_Notice_Periods_Event_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Edit_Notice_Periods_Event_Request = Put_Edit_Notice_Periods_Event_Request;
		}
	}
}
