using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Settlement_ServicesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Escheatment_ItemsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Escheatment_Items_RequestType Submit_Escheatment_Items_Request;

		public Submit_Escheatment_ItemsInput()
		{
		}

		public Submit_Escheatment_ItemsInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Escheatment_Items_RequestType Submit_Escheatment_Items_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Escheatment_Items_Request = Submit_Escheatment_Items_Request;
		}
	}
}
