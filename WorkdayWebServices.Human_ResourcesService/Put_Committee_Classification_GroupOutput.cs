using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Committee_Classification_GroupOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Committee_Classification_Group_ResponseType Put_Committee_Classification_Group_Response;

		public Put_Committee_Classification_GroupOutput()
		{
		}

		public Put_Committee_Classification_GroupOutput(Put_Committee_Classification_Group_ResponseType Put_Committee_Classification_Group_Response)
		{
			this.Put_Committee_Classification_Group_Response = Put_Committee_Classification_Group_Response;
		}
	}
}
