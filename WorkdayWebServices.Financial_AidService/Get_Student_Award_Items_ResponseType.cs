using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WorkdayWebServices.Financial_AidService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Student_Award_Items_ResponseType : INotifyPropertyChanged
	{
		private Student_Award_Item_Request_ReferencesType request_ReferencesField;

		private Student_Award_Item_Request_CriteriaType request_CriteriaField;

		private Response_FilterType response_FilterField;

		private Response_ResultsType response_ResultsField;

		private Student_Award_ItemType[] response_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Award_Item_Request_ReferencesType Request_References
		{
			get
			{
				return this.request_ReferencesField;
			}
			set
			{
				this.request_ReferencesField = value;
				this.RaisePropertyChanged("Request_References");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Award_Item_Request_CriteriaType Request_Criteria
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlArray(Order = 4), XmlArrayItem("Student_Award_Item", IsNullable = false)]
		public Student_Award_ItemType[] Response_Data
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
