using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Goal_Target_And_Actual_Track_By__Tenanted_ObjectType : INotifyPropertyChanged
	{
		private Goal_Target_And_Actual_Track_By__Tenanted_ObjectIDType[] idField;

		private string descriptorField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("ID", Order = 0)]
		public Goal_Target_And_Actual_Track_By__Tenanted_ObjectIDType[] ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Descriptor
		{
			get
			{
				return this.descriptorField;
			}
			set
			{
				this.descriptorField = value;
				this.RaisePropertyChanged("Descriptor");
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
