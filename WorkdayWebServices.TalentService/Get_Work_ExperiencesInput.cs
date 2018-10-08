using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.TalentService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Work_ExperiencesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Work_Experiences_RequestType Get_Work_Experiences_Request;

		public Get_Work_ExperiencesInput()
		{
		}

		public Get_Work_ExperiencesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Work_Experiences_RequestType Get_Work_Experiences_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Work_Experiences_Request = Get_Work_Experiences_Request;
		}
	}
}
