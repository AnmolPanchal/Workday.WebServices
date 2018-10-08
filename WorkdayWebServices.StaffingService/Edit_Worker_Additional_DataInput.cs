using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.StaffingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Worker_Additional_DataInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Worker_Additional_Data_RequestType Edit_Worker_Additional_Data_Request;

		public Edit_Worker_Additional_DataInput()
		{
		}

		public Edit_Worker_Additional_DataInput(Workday_Common_HeaderType Workday_Common_Header, Edit_Worker_Additional_Data_RequestType Edit_Worker_Additional_Data_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Edit_Worker_Additional_Data_Request = Edit_Worker_Additional_Data_Request;
		}
	}
}
