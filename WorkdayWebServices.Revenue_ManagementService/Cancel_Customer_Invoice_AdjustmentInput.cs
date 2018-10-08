using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Customer_Invoice_AdjustmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Customer_Invoice_Adjustment_RequestType Cancel_Customer_Invoice_Adjustment_Request;

		public Cancel_Customer_Invoice_AdjustmentInput()
		{
		}

		public Cancel_Customer_Invoice_AdjustmentInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Customer_Invoice_Adjustment_RequestType Cancel_Customer_Invoice_Adjustment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Customer_Invoice_Adjustment_Request = Cancel_Customer_Invoice_Adjustment_Request;
		}
	}
}
