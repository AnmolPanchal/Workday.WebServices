using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Employee_ImageInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Employee_Image_GetType Employee_Image_Get;

		public Get_Employee_ImageInput()
		{
		}

		public Get_Employee_ImageInput(Workday_Common_HeaderType Workday_Common_Header, Employee_Image_GetType Employee_Image_Get)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Employee_Image_Get = Employee_Image_Get;
		}
	}
}