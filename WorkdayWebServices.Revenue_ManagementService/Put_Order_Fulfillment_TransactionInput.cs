using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Order_Fulfillment_TransactionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Order_Fulfillment_Transaction_RequestType Put_Order_Fulfillment_Transaction_Request;

		public Put_Order_Fulfillment_TransactionInput()
		{
		}

		public Put_Order_Fulfillment_TransactionInput(Workday_Common_HeaderType Workday_Common_Header, Put_Order_Fulfillment_Transaction_RequestType Put_Order_Fulfillment_Transaction_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Order_Fulfillment_Transaction_Request = Put_Order_Fulfillment_Transaction_Request;
		}
	}
}
