using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Alternate_Customer_ContractsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Alternate_Customer_Contracts_ResponseType Get_Alternate_Customer_Contracts_Response;

		public Get_Alternate_Customer_ContractsOutput()
		{
		}

		public Get_Alternate_Customer_ContractsOutput(Get_Alternate_Customer_Contracts_ResponseType Get_Alternate_Customer_Contracts_Response)
		{
			this.Get_Alternate_Customer_Contracts_Response = Get_Alternate_Customer_Contracts_Response;
		}
	}
}