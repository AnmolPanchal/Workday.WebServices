using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Loan_Request_CriteriaType : INotifyPropertyChanged
	{
		private string loan_NumberField;

		private CustomerObjectType[] customer_ReferenceField;

		private string property_IDField;

		private DateTime loan_Vintage_Start_DateField;

		private bool loan_Vintage_Start_DateFieldSpecified;

		private DateTime loan_Vintage_End_DateField;

		private bool loan_Vintage_End_DateFieldSpecified;

		private DateTime first_Referral_Start_DateField;

		private bool first_Referral_Start_DateFieldSpecified;

		private DateTime first_Referral_End_DateField;

		private bool first_Referral_End_DateFieldSpecified;

		private Loan_Referral_TypeObjectType[] referral_Type_ReferenceField;

		private Loan_Investor_TypeObjectType[] investor_Type_ReferenceField;

		private CountryObjectType[] country_ReferenceField;

		private Country_RegionObjectType[] country_Region_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Loan_Number
		{
			get
			{
				return this.loan_NumberField;
			}
			set
			{
				this.loan_NumberField = value;
				this.RaisePropertyChanged("Loan_Number");
			}
		}

		[XmlElement("Customer_Reference", Order = 1)]
		public CustomerObjectType[] Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Property_ID
		{
			get
			{
				return this.property_IDField;
			}
			set
			{
				this.property_IDField = value;
				this.RaisePropertyChanged("Property_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Loan_Vintage_Start_Date
		{
			get
			{
				return this.loan_Vintage_Start_DateField;
			}
			set
			{
				this.loan_Vintage_Start_DateField = value;
				this.RaisePropertyChanged("Loan_Vintage_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Loan_Vintage_Start_DateSpecified
		{
			get
			{
				return this.loan_Vintage_Start_DateFieldSpecified;
			}
			set
			{
				this.loan_Vintage_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Loan_Vintage_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Loan_Vintage_End_Date
		{
			get
			{
				return this.loan_Vintage_End_DateField;
			}
			set
			{
				this.loan_Vintage_End_DateField = value;
				this.RaisePropertyChanged("Loan_Vintage_End_Date");
			}
		}

		[XmlIgnore]
		public bool Loan_Vintage_End_DateSpecified
		{
			get
			{
				return this.loan_Vintage_End_DateFieldSpecified;
			}
			set
			{
				this.loan_Vintage_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Loan_Vintage_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime First_Referral_Start_Date
		{
			get
			{
				return this.first_Referral_Start_DateField;
			}
			set
			{
				this.first_Referral_Start_DateField = value;
				this.RaisePropertyChanged("First_Referral_Start_Date");
			}
		}

		[XmlIgnore]
		public bool First_Referral_Start_DateSpecified
		{
			get
			{
				return this.first_Referral_Start_DateFieldSpecified;
			}
			set
			{
				this.first_Referral_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("First_Referral_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime First_Referral_End_Date
		{
			get
			{
				return this.first_Referral_End_DateField;
			}
			set
			{
				this.first_Referral_End_DateField = value;
				this.RaisePropertyChanged("First_Referral_End_Date");
			}
		}

		[XmlIgnore]
		public bool First_Referral_End_DateSpecified
		{
			get
			{
				return this.first_Referral_End_DateFieldSpecified;
			}
			set
			{
				this.first_Referral_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("First_Referral_End_DateSpecified");
			}
		}

		[XmlElement("Referral_Type_Reference", Order = 7)]
		public Loan_Referral_TypeObjectType[] Referral_Type_Reference
		{
			get
			{
				return this.referral_Type_ReferenceField;
			}
			set
			{
				this.referral_Type_ReferenceField = value;
				this.RaisePropertyChanged("Referral_Type_Reference");
			}
		}

		[XmlElement("Investor_Type_Reference", Order = 8)]
		public Loan_Investor_TypeObjectType[] Investor_Type_Reference
		{
			get
			{
				return this.investor_Type_ReferenceField;
			}
			set
			{
				this.investor_Type_ReferenceField = value;
				this.RaisePropertyChanged("Investor_Type_Reference");
			}
		}

		[XmlElement("Country_Reference", Order = 9)]
		public CountryObjectType[] Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement("Country_Region_Reference", Order = 10)]
		public Country_RegionObjectType[] Country_Region_Reference
		{
			get
			{
				return this.country_Region_ReferenceField;
			}
			set
			{
				this.country_Region_ReferenceField = value;
				this.RaisePropertyChanged("Country_Region_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
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
