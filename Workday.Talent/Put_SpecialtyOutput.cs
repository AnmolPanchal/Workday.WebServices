using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SpecialtyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Specialty_ResponseType Put_Specialty_Response;

		public Put_SpecialtyOutput()
		{
		}

		public Put_SpecialtyOutput(Put_Specialty_ResponseType Put_Specialty_Response)
		{
			this.Put_Specialty_Response = Put_Specialty_Response;
		}
	}
}
