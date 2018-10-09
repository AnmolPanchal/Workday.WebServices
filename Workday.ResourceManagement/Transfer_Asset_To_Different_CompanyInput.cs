using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Transfer_Asset_To_Different_CompanyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Transfer_Asset_To_Different_Company_RequestType Transfer_Asset_To_Different_Company_Request;

		public Transfer_Asset_To_Different_CompanyInput()
		{
		}

		public Transfer_Asset_To_Different_CompanyInput(Workday_Common_HeaderType Workday_Common_Header, Transfer_Asset_To_Different_Company_RequestType Transfer_Asset_To_Different_Company_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Transfer_Asset_To_Different_Company_Request = Transfer_Asset_To_Different_Company_Request;
		}
	}
}
