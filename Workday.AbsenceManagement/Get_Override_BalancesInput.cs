using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Absence_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Override_BalancesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Override_Balances_RequestType Get_Override_Balances_Request;

		public Get_Override_BalancesInput()
		{
		}

		public Get_Override_BalancesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Override_Balances_RequestType Get_Override_Balances_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Override_Balances_Request = Get_Override_Balances_Request;
		}
	}
}