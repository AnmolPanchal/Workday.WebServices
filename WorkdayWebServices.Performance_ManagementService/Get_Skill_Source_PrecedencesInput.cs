using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Performance_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Skill_Source_PrecedencesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Skill_Source_Precedences_RequestType Get_Skill_Source_Precedences_Request;

		public Get_Skill_Source_PrecedencesInput()
		{
		}

		public Get_Skill_Source_PrecedencesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Skill_Source_Precedences_RequestType Get_Skill_Source_Precedences_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Skill_Source_Precedences_Request = Get_Skill_Source_Precedences_Request;
		}
	}
}
