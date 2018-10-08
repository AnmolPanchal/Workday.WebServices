using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace WorkdayWebServices.NotificationService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Notification", ConfigurationName = "NotificationService.NotificationPort")]
	public interface NotificationPort
	{
		[OperationContract(IsOneWay = true, Action = ""), ServiceKnownType(typeof(Notification_DataType)), XmlSerializerFormat(SupportFaults = true)]
		void Receive_Notification(Receive_NotificationInput request);

		[OperationContract(IsOneWay = true, Action = "")]
		Task Receive_NotificationAsync(Receive_NotificationInput request);
	}
}
