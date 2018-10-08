using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Student_FinanceService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Student_Historical_ChargesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Student_Historical_Charge_RequestType Import_Student_Historical_Charge_Request;

		public Import_Student_Historical_ChargesInput()
		{
		}

		public Import_Student_Historical_ChargesInput(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Historical_Charge_RequestType Import_Student_Historical_Charge_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Student_Historical_Charge_Request = Import_Student_Historical_Charge_Request;
		}
	}
}
