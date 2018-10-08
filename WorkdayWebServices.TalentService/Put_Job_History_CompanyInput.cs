using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.TalentService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Job_History_CompanyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Job_History_Company_RequestType Put_Job_History_Company_Request;

		public Put_Job_History_CompanyInput()
		{
		}

		public Put_Job_History_CompanyInput(Workday_Common_HeaderType Workday_Common_Header, Put_Job_History_Company_RequestType Put_Job_History_Company_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Job_History_Company_Request = Put_Job_History_Company_Request;
		}
	}
}
