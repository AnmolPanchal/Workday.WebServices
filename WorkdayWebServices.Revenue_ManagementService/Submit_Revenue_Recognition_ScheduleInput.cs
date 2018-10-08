using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Revenue_Recognition_ScheduleInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Revenue_Recognition_Schedule_RequestType Submit_Revenue_Recognition_Schedule_Request;

		public Submit_Revenue_Recognition_ScheduleInput()
		{
		}

		public Submit_Revenue_Recognition_ScheduleInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Revenue_Recognition_Schedule_RequestType Submit_Revenue_Recognition_Schedule_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Revenue_Recognition_Schedule_Request = Submit_Revenue_Recognition_Schedule_Request;
		}
	}
}
