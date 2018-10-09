using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Company_Insider_TypeType : INotifyPropertyChanged
	{
		private Company_Insider_TypeObjectType company_Insider_Type_ReferenceField;

		private Company_Insider_Type_DataType[] company_Insider_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Company_Insider_TypeObjectType Company_Insider_Type_Reference
		{
			get
			{
				return this.company_Insider_Type_ReferenceField;
			}
			set
			{
				this.company_Insider_Type_ReferenceField = value;
				this.RaisePropertyChanged("Company_Insider_Type_Reference");
			}
		}

		[XmlElement("Company_Insider_Type_Data", Order = 1)]
		public Company_Insider_Type_DataType[] Company_Insider_Type_Data
		{
			get
			{
				return this.company_Insider_Type_DataField;
			}
			set
			{
				this.company_Insider_Type_DataField = value;
				this.RaisePropertyChanged("Company_Insider_Type_Data");
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
