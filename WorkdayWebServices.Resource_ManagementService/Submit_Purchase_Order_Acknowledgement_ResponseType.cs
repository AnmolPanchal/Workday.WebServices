using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Purchase_Order_Acknowledgement_ResponseType : INotifyPropertyChanged
	{
		private Purchase_Order_AcknowledgementObjectType purchase_Order_Acknowledgement_ReferenceField;

		private Exception_DataType[] exceptions_Response_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Purchase_Order_AcknowledgementObjectType Purchase_Order_Acknowledgement_Reference
		{
			get
			{
				return this.purchase_Order_Acknowledgement_ReferenceField;
			}
			set
			{
				this.purchase_Order_Acknowledgement_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Acknowledgement_Reference");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Exceptions_Data", IsNullable = false), XmlArrayItem("Exception_Data", IsNullable = false, NestingLevel = 1)]
		public Exception_DataType[] Exceptions_Response_Data
		{
			get
			{
				return this.exceptions_Response_DataField;
			}
			set
			{
				this.exceptions_Response_DataField = value;
				this.RaisePropertyChanged("Exceptions_Response_Data");
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