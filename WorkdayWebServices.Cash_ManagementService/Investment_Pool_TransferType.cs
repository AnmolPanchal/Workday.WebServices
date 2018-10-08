using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Cash_ManagementService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Investment_Pool_TransferType : INotifyPropertyChanged
	{
		private Investment_Pool_TransferObjectType investment_Pool_Transfer_ReferenceField;

		private Investment_Pool_Transfer_DataType[] investment_Pool_Transfer_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Investment_Pool_TransferObjectType Investment_Pool_Transfer_Reference
		{
			get
			{
				return this.investment_Pool_Transfer_ReferenceField;
			}
			set
			{
				this.investment_Pool_Transfer_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Pool_Transfer_Reference");
			}
		}

		[XmlElement("Investment_Pool_Transfer_Data", Order = 1)]
		public Investment_Pool_Transfer_DataType[] Investment_Pool_Transfer_Data
		{
			get
			{
				return this.investment_Pool_Transfer_DataField;
			}
			set
			{
				this.investment_Pool_Transfer_DataField = value;
				this.RaisePropertyChanged("Investment_Pool_Transfer_Data");
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
