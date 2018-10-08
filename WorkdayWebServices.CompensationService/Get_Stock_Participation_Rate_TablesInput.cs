using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.CompensationService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Stock_Participation_Rate_TablesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Stock_Participation_Rate_Tables_RequestType Get_Stock_Participation_Rate_Tables_Request;

		public Get_Stock_Participation_Rate_TablesInput()
		{
		}

		public Get_Stock_Participation_Rate_TablesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Stock_Participation_Rate_Tables_RequestType Get_Stock_Participation_Rate_Tables_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Stock_Participation_Rate_Tables_Request = Get_Stock_Participation_Rate_Tables_Request;
		}
	}
}
