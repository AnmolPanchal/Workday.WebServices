using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Student_RecordsService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_AccomplishmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Accomplishment_RequestType Put_Student_Accomplishment_Request;

		public Put_Student_AccomplishmentInput()
		{
		}

		public Put_Student_AccomplishmentInput(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Accomplishment_RequestType Put_Student_Accomplishment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Student_Accomplishment_Request = Put_Student_Accomplishment_Request;
		}
	}
}
