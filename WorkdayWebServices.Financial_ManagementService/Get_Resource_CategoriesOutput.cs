using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Resource_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Resource_Categories_ResponseType Get_Resource_Categories_Response;

		public Get_Resource_CategoriesOutput()
		{
		}

		public Get_Resource_CategoriesOutput(Get_Resource_Categories_ResponseType Get_Resource_Categories_Response)
		{
			this.Get_Resource_Categories_Response = Get_Resource_Categories_Response;
		}
	}
}
