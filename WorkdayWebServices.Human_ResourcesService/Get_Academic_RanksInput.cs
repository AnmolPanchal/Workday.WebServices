using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Academic_RanksInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Academic_Ranks_RequestType Get_Academic_Ranks_Request;

		public Get_Academic_RanksInput()
		{
		}

		public Get_Academic_RanksInput(Workday_Common_HeaderType Workday_Common_Header, Get_Academic_Ranks_RequestType Get_Academic_Ranks_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Academic_Ranks_Request = Get_Academic_Ranks_Request;
		}
	}
}