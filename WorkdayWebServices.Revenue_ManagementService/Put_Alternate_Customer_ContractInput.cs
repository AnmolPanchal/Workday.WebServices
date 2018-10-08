using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Alternate_Customer_ContractInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Alternate_Customer_Contract_RequestType Put_Alternate_Customer_Contract_Request;

		public Put_Alternate_Customer_ContractInput()
		{
		}

		public Put_Alternate_Customer_ContractInput(Workday_Common_HeaderType Workday_Common_Header, Put_Alternate_Customer_Contract_RequestType Put_Alternate_Customer_Contract_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Alternate_Customer_Contract_Request = Put_Alternate_Customer_Contract_Request;
		}
	}
}
