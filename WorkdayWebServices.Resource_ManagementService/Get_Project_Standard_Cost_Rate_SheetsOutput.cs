using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Project_Standard_Cost_Rate_SheetsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Project_Standard_Cost_Rate_Sheets_ResponseType Get_Project_Standard_Cost_Rate_Sheets_Response;

		public Get_Project_Standard_Cost_Rate_SheetsOutput()
		{
		}

		public Get_Project_Standard_Cost_Rate_SheetsOutput(Get_Project_Standard_Cost_Rate_Sheets_ResponseType Get_Project_Standard_Cost_Rate_Sheets_Response)
		{
			this.Get_Project_Standard_Cost_Rate_Sheets_Response = Get_Project_Standard_Cost_Rate_Sheets_Response;
		}
	}
}