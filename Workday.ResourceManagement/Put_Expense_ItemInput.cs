using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Expense_ItemInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Expense_Item_RequestType Put_Expense_Item_Request;

		public Put_Expense_ItemInput()
		{
		}

		public Put_Expense_ItemInput(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Item_RequestType Put_Expense_Item_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Expense_Item_Request = Put_Expense_Item_Request;
		}
	}
}
