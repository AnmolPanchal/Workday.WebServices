using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Expense_Item_Attribute_GroupsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Expense_Item_Attribute_Groups_ResponseType Get_Expense_Item_Attribute_Groups_Response;

		public Get_Expense_Item_Attribute_GroupsOutput()
		{
		}

		public Get_Expense_Item_Attribute_GroupsOutput(Get_Expense_Item_Attribute_Groups_ResponseType Get_Expense_Item_Attribute_Groups_Response)
		{
			this.Get_Expense_Item_Attribute_Groups_Response = Get_Expense_Item_Attribute_Groups_Response;
		}
	}
}
