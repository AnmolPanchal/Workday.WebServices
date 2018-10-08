using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Location_Hierarchy_Organization_Assignments_DataType : INotifyPropertyChanged
	{
		private Location_HierarchyObjectType location_Hierarchy_ReferenceField;

		private Location_Hierarchy_Organization_Assignments_by_Type_DataType[] location_Hierarchy_Organization_Assignments_by_Type_DataField;

		private bool replace_AllField;

		private bool replace_AllFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Location_HierarchyObjectType Location_Hierarchy_Reference
		{
			get
			{
				return this.location_Hierarchy_ReferenceField;
			}
			set
			{
				this.location_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Location_Hierarchy_Reference");
			}
		}

		[XmlElement("Location_Hierarchy_Organization_Assignments_by_Type_Data", Order = 1)]
		public Location_Hierarchy_Organization_Assignments_by_Type_DataType[] Location_Hierarchy_Organization_Assignments_by_Type_Data
		{
			get
			{
				return this.location_Hierarchy_Organization_Assignments_by_Type_DataField;
			}
			set
			{
				this.location_Hierarchy_Organization_Assignments_by_Type_DataField = value;
				this.RaisePropertyChanged("Location_Hierarchy_Organization_Assignments_by_Type_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Replace_All
		{
			get
			{
				return this.replace_AllField;
			}
			set
			{
				this.replace_AllField = value;
				this.RaisePropertyChanged("Replace_All");
			}
		}

		[XmlIgnore]
		public bool Replace_AllSpecified
		{
			get
			{
				return this.replace_AllFieldSpecified;
			}
			set
			{
				this.replace_AllFieldSpecified = value;
				this.RaisePropertyChanged("Replace_AllSpecified");
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
