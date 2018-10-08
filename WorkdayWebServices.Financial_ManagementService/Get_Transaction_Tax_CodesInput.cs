using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Transaction_Tax_CodesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Tax_Codes_RequestType Get_Tax_Codes_Request;

		public Get_Transaction_Tax_CodesInput()
		{
		}

		public Get_Transaction_Tax_CodesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Codes_RequestType Get_Tax_Codes_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Tax_Codes_Request = Get_Tax_Codes_Request;
		}
	}
}
