using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Credit_Card_Transaction_File_DataType : INotifyPropertyChanged
	{
		private string file_NumberField;

		private string file_NameField;

		private DateTime report_Create_DateField;

		private Credit_Card_TypeObjectType credit_Card_Type_ReferenceField;

		private DateTime report_Version_DateField;

		private bool report_Version_DateFieldSpecified;

		private string report_VersionField;

		private Data_Load_StatusObjectType data_Load_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string File_Number
		{
			get
			{
				return this.file_NumberField;
			}
			set
			{
				this.file_NumberField = value;
				this.RaisePropertyChanged("File_Number");
			}
		}

		[XmlElement(Order = 1)]
		public string File_Name
		{
			get
			{
				return this.file_NameField;
			}
			set
			{
				this.file_NameField = value;
				this.RaisePropertyChanged("File_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Report_Create_Date
		{
			get
			{
				return this.report_Create_DateField;
			}
			set
			{
				this.report_Create_DateField = value;
				this.RaisePropertyChanged("Report_Create_Date");
			}
		}

		[XmlElement(Order = 3)]
		public Credit_Card_TypeObjectType Credit_Card_Type_Reference
		{
			get
			{
				return this.credit_Card_Type_ReferenceField;
			}
			set
			{
				this.credit_Card_Type_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Report_Version_Date
		{
			get
			{
				return this.report_Version_DateField;
			}
			set
			{
				this.report_Version_DateField = value;
				this.RaisePropertyChanged("Report_Version_Date");
			}
		}

		[XmlIgnore]
		public bool Report_Version_DateSpecified
		{
			get
			{
				return this.report_Version_DateFieldSpecified;
			}
			set
			{
				this.report_Version_DateFieldSpecified = value;
				this.RaisePropertyChanged("Report_Version_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Report_Version
		{
			get
			{
				return this.report_VersionField;
			}
			set
			{
				this.report_VersionField = value;
				this.RaisePropertyChanged("Report_Version");
			}
		}

		[XmlElement(Order = 6)]
		public Data_Load_StatusObjectType Data_Load_Status_Reference
		{
			get
			{
				return this.data_Load_Status_ReferenceField;
			}
			set
			{
				this.data_Load_Status_ReferenceField = value;
				this.RaisePropertyChanged("Data_Load_Status_Reference");
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
