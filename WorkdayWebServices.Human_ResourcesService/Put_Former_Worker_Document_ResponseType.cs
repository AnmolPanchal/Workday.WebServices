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
	public class Put_Former_Worker_Document_ResponseType : INotifyPropertyChanged
	{
		private Former_Worker_AttachmentObjectType former_Worker_Attachment_ReferenceField;

		private Former_WorkerObjectType former_Worker_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Former_Worker_AttachmentObjectType Former_Worker_Attachment_Reference
		{
			get
			{
				return this.former_Worker_Attachment_ReferenceField;
			}
			set
			{
				this.former_Worker_Attachment_ReferenceField = value;
				this.RaisePropertyChanged("Former_Worker_Attachment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Former_WorkerObjectType Former_Worker_Reference
		{
			get
			{
				return this.former_Worker_ReferenceField;
			}
			set
			{
				this.former_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Former_Worker_Reference");
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
