using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Withholding_Tax_Item_Group_RequestType : INotifyPropertyChanged
	{
		private Withholding_Tax_Items_GroupObjectType withholding_Tax_Item_Group_ReferenceField;

		private Tax_Items_Group_DataType withholding_Tax_Item_Group_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Withholding_Tax_Items_GroupObjectType Withholding_Tax_Item_Group_Reference
		{
			get
			{
				return this.withholding_Tax_Item_Group_ReferenceField;
			}
			set
			{
				this.withholding_Tax_Item_Group_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Tax_Item_Group_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Tax_Items_Group_DataType Withholding_Tax_Item_Group_Data
		{
			get
			{
				return this.withholding_Tax_Item_Group_DataField;
			}
			set
			{
				this.withholding_Tax_Item_Group_DataField = value;
				this.RaisePropertyChanged("Withholding_Tax_Item_Group_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
