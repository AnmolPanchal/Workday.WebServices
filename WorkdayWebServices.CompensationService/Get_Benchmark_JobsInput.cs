using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.CompensationService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Benchmark_JobsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Benchmark_Jobs_RequestType Get_Benchmark_Jobs_Request;

		public Get_Benchmark_JobsInput()
		{
		}

		public Get_Benchmark_JobsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Benchmark_Jobs_RequestType Get_Benchmark_Jobs_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Benchmark_Jobs_Request = Get_Benchmark_Jobs_Request;
		}
	}
}
