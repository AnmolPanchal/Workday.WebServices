using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Compensation_GradeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Compensation_Grade_RequestType Put_Compensation_Grade_Request;

		public Put_Compensation_GradeInput()
		{
		}

		public Put_Compensation_GradeInput(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Grade_RequestType Put_Compensation_Grade_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Compensation_Grade_Request = Put_Compensation_Grade_Request;
		}
	}
}
