using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Payroll_CANService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_CAN_Year_End_FormsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_CAN_Year_End_Forms_ResponseType Get_Payroll_CAN_Year_End_Forms_Response;

		public Get_Payroll_CAN_Year_End_FormsOutput()
		{
		}

		public Get_Payroll_CAN_Year_End_FormsOutput(Get_Payroll_CAN_Year_End_Forms_ResponseType Get_Payroll_CAN_Year_End_Forms_Response)
		{
			this.Get_Payroll_CAN_Year_End_Forms_Response = Get_Payroll_CAN_Year_End_Forms_Response;
		}
	}
}
