using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Credit_CardsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Credit_Card_Header__HV__RequestType Credit_Card_Header__HV__Request;

		public Import_Credit_CardsInput()
		{
		}

		public Import_Credit_CardsInput(Workday_Common_HeaderType Workday_Common_Header, Credit_Card_Header__HV__RequestType Credit_Card_Header__HV__Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Credit_Card_Header__HV__Request = Credit_Card_Header__HV__Request;
		}
	}
}