using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_AidService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Sponsor_ContractsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Sponsor_Contracts_RequestType Get_Student_Sponsor_Contracts_Request;

		public Get_Student_Sponsor_ContractsInput()
		{
		}

		public Get_Student_Sponsor_ContractsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Sponsor_Contracts_RequestType Get_Student_Sponsor_Contracts_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Student_Sponsor_Contracts_Request = Get_Student_Sponsor_Contracts_Request;
		}
	}
}