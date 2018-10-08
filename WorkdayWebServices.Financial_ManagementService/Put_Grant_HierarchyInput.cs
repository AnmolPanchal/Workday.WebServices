using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Grant_HierarchyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Grant_Hierarchy_RequestType Put_Grant_Hierarchy_Request;

		public Put_Grant_HierarchyInput()
		{
		}

		public Put_Grant_HierarchyInput(Workday_Common_HeaderType Workday_Common_Header, Put_Grant_Hierarchy_RequestType Put_Grant_Hierarchy_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Grant_Hierarchy_Request = Put_Grant_Hierarchy_Request;
		}
	}
}
