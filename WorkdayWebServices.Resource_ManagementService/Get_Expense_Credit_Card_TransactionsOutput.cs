using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Expense_Credit_Card_TransactionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Expense_Credit_Card_Transactions_ResponseType Get_Expense_Credit_Card_Transactions_Response;

		public Get_Expense_Credit_Card_TransactionsOutput()
		{
		}

		public Get_Expense_Credit_Card_TransactionsOutput(Get_Expense_Credit_Card_Transactions_ResponseType Get_Expense_Credit_Card_Transactions_Response)
		{
			this.Get_Expense_Credit_Card_Transactions_Response = Get_Expense_Credit_Card_Transactions_Response;
		}
	}
}
