using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Prepaid_Spend_Amortization_SchedulesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Prepaid_Spend_Amortization_Schedules_RequestType Get_Prepaid_Spend_Amortization_Schedules_Request;

		public Get_Prepaid_Spend_Amortization_SchedulesInput()
		{
		}

		public Get_Prepaid_Spend_Amortization_SchedulesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Prepaid_Spend_Amortization_Schedules_RequestType Get_Prepaid_Spend_Amortization_Schedules_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Prepaid_Spend_Amortization_Schedules_Request = Get_Prepaid_Spend_Amortization_Schedules_Request;
		}
	}
}
