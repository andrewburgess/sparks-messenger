using System;

namespace SparksMessenger.Model.Messages
{
	/// <summary>
	/// Base class that represents some sort of message to send to clients
	/// </summary>
	[Serializable]
	public abstract class Message
	{
		public MessageType MessageType { get; set; }
		public Guid UserId { get; set; }
	}
}
