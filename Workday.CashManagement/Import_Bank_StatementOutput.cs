using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Bank_StatementOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Import_Process_ResponseType Put_Import_Process_Response;

		public Import_Bank_StatementOutput()
		{
		}

		public Import_Bank_StatementOutput(Put_Import_Process_ResponseType Put_Import_Process_Response)
		{
			this.Put_Import_Process_Response = Put_Import_Process_Response;
		}
	}
}
