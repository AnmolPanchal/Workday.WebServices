using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Award_TaskOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Award_Task_ResponseType Put_Award_Task_Response;

		public Put_Award_TaskOutput()
		{
		}

		public Put_Award_TaskOutput(Put_Award_Task_ResponseType Put_Award_Task_Response)
		{
			this.Put_Award_Task_Response = Put_Award_Task_Response;
		}
	}
}
