using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Campus_EngagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Engagement_Conversation_TagsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Engagement_Conversation_Tags_RequestType Get_Engagement_Conversation_Tags_Request;

		public Get_Engagement_Conversation_TagsInput()
		{
		}

		public Get_Engagement_Conversation_TagsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Engagement_Conversation_Tags_RequestType Get_Engagement_Conversation_Tags_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Engagement_Conversation_Tags_Request = Get_Engagement_Conversation_Tags_Request;
		}
	}
}
