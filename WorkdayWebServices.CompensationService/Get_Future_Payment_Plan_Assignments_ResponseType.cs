using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WorkdayWebServices.CompensationService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Future_Payment_Plan_Assignments_ResponseType : INotifyPropertyChanged
	{
		private Future_Payment_Plan_Assignment_Request_CriteriaType request_CriteriaField;

		private Response_FilterType response_FilterField;

		private Response_ResultsType response_ResultsField;

		private Position_Future_Payment_Plan_Assignment_DataType[] response_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Future_Payment_Plan_Assignment_Request_CriteriaType Request_Criteria
		{
			get
			{
				return this.request_CriteriaField;
			}
			set
			{
				this.request_CriteriaField = value;
				this.RaisePropertyChanged("Request_Criteria");
			}
		}

		[XmlElement(Order = 1)]
		public Response_FilterType Response_Filter
		{
			get
			{
				return this.response_FilterField;
			}
			set
			{
				this.response_FilterField = value;
				this.RaisePropertyChanged("Response_Filter");
			}
		}

		[XmlElement(Order = 2)]
		public Response_ResultsType Response_Results
		{
			get
			{
				return this.response_ResultsField;
			}
			set
			{
				this.response_ResultsField = value;
				this.RaisePropertyChanged("Response_Results");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Position_Future_Payment_Plan_Assignment", IsNullable = false), XmlArrayItem("Position_Future_Payment_Plan_Assignment_Data", IsNullable = false, NestingLevel = 1)]
		public Position_Future_Payment_Plan_Assignment_DataType[] Response_Data
		{
			get
			{
				return this.response_DataField;
			}
			set
			{
				this.response_DataField = value;
				this.RaisePropertyChanged("Response_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}