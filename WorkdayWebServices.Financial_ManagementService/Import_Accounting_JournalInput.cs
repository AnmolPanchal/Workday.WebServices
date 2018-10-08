using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Accounting_JournalInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Accounting_Journal_RequestType Import_Accounting_Journal_Request;

		public Import_Accounting_JournalInput()
		{
		}

		public Import_Accounting_JournalInput(Workday_Common_HeaderType Workday_Common_Header, Import_Accounting_Journal_RequestType Import_Accounting_Journal_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Accounting_Journal_Request = Import_Accounting_Journal_Request;
		}
	}
}
