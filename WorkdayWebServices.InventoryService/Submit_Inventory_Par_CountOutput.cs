using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.InventoryService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Inventory_Par_CountOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Inventory_Par_Count_ResponseType Submit_Inventory_Par_Count_Response;

		public Submit_Inventory_Par_CountOutput()
		{
		}

		public Submit_Inventory_Par_CountOutput(Submit_Inventory_Par_Count_ResponseType Submit_Inventory_Par_Count_Response)
		{
			this.Submit_Inventory_Par_Count_Response = Submit_Inventory_Par_Count_Response;
		}
	}
}
