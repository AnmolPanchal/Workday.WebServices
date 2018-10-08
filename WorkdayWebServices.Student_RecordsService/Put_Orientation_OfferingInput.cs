using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Student_RecordsService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Orientation_OfferingInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Orientation_Offering_RequestType Put_Orientation_Offering_Request;

		public Put_Orientation_OfferingInput()
		{
		}

		public Put_Orientation_OfferingInput(Workday_Common_HeaderType Workday_Common_Header, Put_Orientation_Offering_RequestType Put_Orientation_Offering_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Orientation_Offering_Request = Put_Orientation_Offering_Request;
		}
	}
}
