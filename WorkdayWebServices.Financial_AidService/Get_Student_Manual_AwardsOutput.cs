using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_AidService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Manual_AwardsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Manual_Awards_ResponseType Get_Student_Manual_Awards_Response;

		public Get_Student_Manual_AwardsOutput()
		{
		}

		public Get_Student_Manual_AwardsOutput(Get_Student_Manual_Awards_ResponseType Get_Student_Manual_Awards_Response)
		{
			this.Get_Student_Manual_Awards_Response = Get_Student_Manual_Awards_Response;
		}
	}
}
