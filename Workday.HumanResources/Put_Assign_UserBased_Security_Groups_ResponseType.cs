using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Put_Assign_User-Based_Security_Groups_ResponseType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Assign_UserBased_Security_Groups_ResponseType : INotifyPropertyChanged
	{
		private System_UserObjectType workday_Account_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public System_UserObjectType Workday_Account_Reference
		{
			get
			{
				return this.workday_Account_ReferenceField;
			}
			set
			{
				this.workday_Account_ReferenceField = value;
				this.RaisePropertyChanged("Workday_Account_Reference");
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
