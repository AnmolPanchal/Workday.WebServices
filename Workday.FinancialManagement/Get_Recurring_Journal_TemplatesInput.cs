using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Recurring_Journal_TemplatesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Recurring_Journal_Templates_RequestType Get_Recurring_Journal_Templates_Request;

		public Get_Recurring_Journal_TemplatesInput()
		{
		}

		public Get_Recurring_Journal_TemplatesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Recurring_Journal_Templates_RequestType Get_Recurring_Journal_Templates_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Recurring_Journal_Templates_Request = Get_Recurring_Journal_Templates_Request;
		}
	}
}
