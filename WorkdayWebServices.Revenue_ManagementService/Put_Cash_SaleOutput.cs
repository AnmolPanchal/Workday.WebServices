using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Cash_SaleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Cash_Sale_ResponseType Put_Cash_Sale_Response;

		public Put_Cash_SaleOutput()
		{
		}

		public Put_Cash_SaleOutput(Put_Cash_Sale_ResponseType Put_Cash_Sale_Response)
		{
			this.Put_Cash_Sale_Response = Put_Cash_Sale_Response;
		}
	}
}