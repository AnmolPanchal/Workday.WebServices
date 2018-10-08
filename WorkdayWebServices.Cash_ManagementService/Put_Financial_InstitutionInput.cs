using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Cash_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Financial_InstitutionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Financial_Institution_RequestType Put_Financial_Institution_Request;

		public Put_Financial_InstitutionInput()
		{
		}

		public Put_Financial_InstitutionInput(Workday_Common_HeaderType Workday_Common_Header, Put_Financial_Institution_RequestType Put_Financial_Institution_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Financial_Institution_Request = Put_Financial_Institution_Request;
		}
	}
}
