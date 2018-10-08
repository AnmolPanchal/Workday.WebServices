using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Tax_CategoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Tax_Category_ResponseType Put_Tax_Category_Response;

		public Put_Tax_CategoryOutput()
		{
		}

		public Put_Tax_CategoryOutput(Put_Tax_Category_ResponseType Put_Tax_Category_Response)
		{
			this.Put_Tax_Category_Response = Put_Tax_Category_Response;
		}
	}
}
