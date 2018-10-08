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
	public class Bank_Account_Transfer_Request_ReferencesType : INotifyPropertyChanged
	{
		private Bank_Account_TransferObjectType[] bank_Account_Transfer_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Bank_Account_Transfer_Reference", Order = 0)]
		public Bank_Account_TransferObjectType[] Bank_Account_Transfer_Reference
		{
			get
			{
				return this.bank_Account_Transfer_ReferenceField;
			}
			set
			{
				this.bank_Account_Transfer_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Account_Transfer_Reference");
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
