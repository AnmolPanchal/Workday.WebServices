using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Payroll_GBRService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Payee_RTIInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_Payee_RTI_RequestType Put_Payroll_Payee_RTI_Request;

		public Put_Payroll_Payee_RTIInput()
		{
		}

		public Put_Payroll_Payee_RTIInput(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_RTI_RequestType Put_Payroll_Payee_RTI_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Payroll_Payee_RTI_Request = Put_Payroll_Payee_RTI_Request;
		}
	}
}
