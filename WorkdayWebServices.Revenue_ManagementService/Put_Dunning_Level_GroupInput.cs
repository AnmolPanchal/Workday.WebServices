using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Dunning_Level_GroupInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Dunning_Level_Group_RequestType Put_Dunning_Level_Group_Request;

		public Put_Dunning_Level_GroupInput()
		{
		}

		public Put_Dunning_Level_GroupInput(Workday_Common_HeaderType Workday_Common_Header, Put_Dunning_Level_Group_RequestType Put_Dunning_Level_Group_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Dunning_Level_Group_Request = Put_Dunning_Level_Group_Request;
		}
	}
}
