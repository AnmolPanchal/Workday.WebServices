using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Committee_Classification_GroupsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Committee_Classification_Groups_RequestType Get_Committee_Classification_Groups_Request;

		public Get_Committee_Classification_GroupsInput()
		{
		}

		public Get_Committee_Classification_GroupsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Classification_Groups_RequestType Get_Committee_Classification_Groups_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Committee_Classification_Groups_Request = Get_Committee_Classification_Groups_Request;
		}
	}
}