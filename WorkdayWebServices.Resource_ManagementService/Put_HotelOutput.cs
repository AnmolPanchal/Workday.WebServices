using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_HotelOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Hotel_ResponseType Put_Hotel_Response;

		public Put_HotelOutput()
		{
		}

		public Put_HotelOutput(Put_Hotel_ResponseType Put_Hotel_Response)
		{
			this.Put_Hotel_Response = Put_Hotel_Response;
		}
	}
}
