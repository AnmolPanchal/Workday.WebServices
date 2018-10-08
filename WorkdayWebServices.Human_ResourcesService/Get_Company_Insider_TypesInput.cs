using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Company_Insider_TypesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Company_Insider_Types_RequestType Get_Company_Insider_Types_Request;

		public Get_Company_Insider_TypesInput()
		{
		}

		public Get_Company_Insider_TypesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Company_Insider_Types_RequestType Get_Company_Insider_Types_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Company_Insider_Types_Request = Get_Company_Insider_Types_Request;
		}
	}
}
