using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Appointment_SpecialtyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Appointment_Specialty_ResponseType Put_Appointment_Specialty_Response;

		public Put_Appointment_SpecialtyOutput()
		{
		}

		public Put_Appointment_SpecialtyOutput(Put_Appointment_Specialty_ResponseType Put_Appointment_Specialty_Response)
		{
			this.Put_Appointment_Specialty_Response = Put_Appointment_Specialty_Response;
		}
	}
}
