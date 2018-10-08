using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_External_Disability_Self_Identification_RecordInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_External_Disability_Self_Identification_Record_RequestType Put_External_Disability_Self_Identification_Record_Request;

		public Put_External_Disability_Self_Identification_RecordInput()
		{
		}

		public Put_External_Disability_Self_Identification_RecordInput(Workday_Common_HeaderType Workday_Common_Header, Put_External_Disability_Self_Identification_Record_RequestType Put_External_Disability_Self_Identification_Record_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_External_Disability_Self_Identification_Record_Request = Put_External_Disability_Self_Identification_Record_Request;
		}
	}
}
