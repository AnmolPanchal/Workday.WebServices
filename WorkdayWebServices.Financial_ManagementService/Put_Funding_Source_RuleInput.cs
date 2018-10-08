using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Funding_Source_RuleInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Funding_Source_Rule_RequestType Put_Funding_Source_Rule_Request;

		public Put_Funding_Source_RuleInput()
		{
		}

		public Put_Funding_Source_RuleInput(Workday_Common_HeaderType Workday_Common_Header, Put_Funding_Source_Rule_RequestType Put_Funding_Source_Rule_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Funding_Source_Rule_Request = Put_Funding_Source_Rule_Request;
		}
	}
}
