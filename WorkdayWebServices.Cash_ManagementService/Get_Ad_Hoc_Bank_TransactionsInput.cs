using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Cash_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Ad_Hoc_Bank_TransactionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Ad_hoc_Bank_Transactions_RequestType Get_Ad_hoc_Bank_Transactions_Request;

		public Get_Ad_Hoc_Bank_TransactionsInput()
		{
		}

		public Get_Ad_Hoc_Bank_TransactionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Ad_hoc_Bank_Transactions_RequestType Get_Ad_hoc_Bank_Transactions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Ad_hoc_Bank_Transactions_Request = Get_Ad_hoc_Bank_Transactions_Request;
		}
	}
}
