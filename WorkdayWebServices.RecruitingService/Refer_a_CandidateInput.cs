using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.RecruitingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Refer_a_CandidateInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Refer_a_Candidate_RequestType Refer_a_Candidate_Request;

		public Refer_a_CandidateInput()
		{
		}

		public Refer_a_CandidateInput(Workday_Common_HeaderType Workday_Common_Header, Refer_a_Candidate_RequestType Refer_a_Candidate_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Refer_a_Candidate_Request = Refer_a_Candidate_Request;
		}
	}
}
