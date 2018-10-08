using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Location_Hierarchy_Organization_AssignmentsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Location_Hierarchy_Organization_Assignments_RequestType Get_Location_Hierarchy_Organization_Assignments_Request;

		public Get_Location_Hierarchy_Organization_AssignmentsInput()
		{
		}

		public Get_Location_Hierarchy_Organization_AssignmentsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Location_Hierarchy_Organization_Assignments_RequestType Get_Location_Hierarchy_Organization_Assignments_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Location_Hierarchy_Organization_Assignments_Request = Get_Location_Hierarchy_Organization_Assignments_Request;
		}
	}
}
