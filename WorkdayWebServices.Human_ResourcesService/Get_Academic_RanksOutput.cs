using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Academic_RanksOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Academic_Ranks_ResponseType Get_Academic_Ranks_Response;

		public Get_Academic_RanksOutput()
		{
		}

		public Get_Academic_RanksOutput(Get_Academic_Ranks_ResponseType Get_Academic_Ranks_Response)
		{
			this.Get_Academic_Ranks_Response = Get_Academic_Ranks_Response;
		}
	}
}
