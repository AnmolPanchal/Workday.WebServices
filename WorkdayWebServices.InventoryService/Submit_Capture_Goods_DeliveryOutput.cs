using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.InventoryService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Capture_Goods_DeliveryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Capture_Goods_Delivery_ResponseType Submit_Capture_Goods_Delivery_Response;

		public Submit_Capture_Goods_DeliveryOutput()
		{
		}

		public Submit_Capture_Goods_DeliveryOutput(Submit_Capture_Goods_Delivery_ResponseType Submit_Capture_Goods_Delivery_Response)
		{
			this.Submit_Capture_Goods_Delivery_Response = Submit_Capture_Goods_Delivery_Response;
		}
	}
}
