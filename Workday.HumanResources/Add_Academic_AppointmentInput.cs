using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Add_Academic_AppointmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Add_Academic_Appointment_RequestType Add_Academic_Appointment_Request;

		public Add_Academic_AppointmentInput()
		{
		}

		public Add_Academic_AppointmentInput(Workday_Common_HeaderType Workday_Common_Header, Add_Academic_Appointment_RequestType Add_Academic_Appointment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Add_Academic_Appointment_Request = Add_Academic_Appointment_Request;
		}
	}
}