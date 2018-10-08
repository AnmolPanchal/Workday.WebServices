using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Service_Center_Representative_Workday_AccountInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Service_Center_Representative_Workday_Account_RequestType Put_Service_Center_Representative_Workday_Account_Request;

		public Put_Service_Center_Representative_Workday_AccountInput()
		{
		}

		public Put_Service_Center_Representative_Workday_AccountInput(Workday_Common_HeaderType Workday_Common_Header, Put_Service_Center_Representative_Workday_Account_RequestType Put_Service_Center_Representative_Workday_Account_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Service_Center_Representative_Workday_Account_Request = Put_Service_Center_Representative_Workday_Account_Request;
		}
	}
}