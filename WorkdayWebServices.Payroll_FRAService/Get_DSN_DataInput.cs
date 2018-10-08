using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Payroll_FRAService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_DSN_DataInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_DSN_Data_RequestType Get_DSN_Data_Request;

		public Get_DSN_DataInput()
		{
		}

		public Get_DSN_DataInput(Workday_Common_HeaderType Workday_Common_Header, Get_DSN_Data_RequestType Get_DSN_Data_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_DSN_Data_Request = Get_DSN_Data_Request;
		}
	}
}
