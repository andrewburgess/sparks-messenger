using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using SparksMessenger.Model.Messages;

namespace SparksMessenger.Controller
{
	/// <summary>
	/// BroadcastController listens for broadcasted events (sign on/off, status change events primarily) 
	/// as well as send the initial user information for storage on local machine.
	/// </summary>
	public class BroadcastController
	{
		private bool Running { get; set; }
		private UdpClient UDPBroadcaster { get; set; }
		private Thread BroadcastThread { get; set; }

		private IPEndPoint _localIpEndPoint;

		#region Events
		public event SignOnEvent UserSignedOn;
		#endregion

		/// <summary>
		/// Initializes the Broadcast clients and networking components
		/// </summary>
		public BroadcastController()
		{
			_localIpEndPoint = new IPEndPoint(IPAddress.Any, 15698);
			UDPBroadcaster = new UdpClient(_localIpEndPoint) { EnableBroadcast = true };

			Running = true;
			BroadcastThread = new Thread(ListenForBroadcasts);
			BroadcastThread.Start();
		}

		public void SendSignOnMessage(Guid userId)
		{
			var msg = new SignOnMessage {MessageType = MessageType.SignOn, UserId = userId};
			var serializer = new BinaryFormatter();
			var ms = new MemoryStream();
			serializer.Serialize(ms, msg);
			ms.Position = 0;
			var reader = new BinaryReader(ms);
			var data = reader.ReadBytes((int) ms.Length);

			UDPBroadcaster.Send(data, data.Length, new IPEndPoint(IPAddress.Broadcast, 15698));
		}

		/// <summary>
		/// Listens for data sent via the broadcast information
		/// </summary>
		private void ListenForBroadcasts()
		{
			var deserializer = new BinaryFormatter();
			while (Running)
			{
				if (UDPBroadcaster.Available > 0)
				{
					var data = UDPBroadcaster.Receive(ref _localIpEndPoint);

					var message = (Message)deserializer.Deserialize(new MemoryStream(data));
					HandleMessage(message);
				}
			}
		}

		/// <summary>
		/// Handles received messages
		/// </summary>
		/// <param name="message">The message that was received</param>
		private void HandleMessage(Message message)
		{
			switch (message.MessageType)
			{
				case MessageType.SignOn:
					var signOn = (SignOnMessage) message;
					if (UserSignedOn != null)
					{
						UserSignedOn(this, signOn);
					}
					break;
			}
		}

		public void Close()
		{
			Running = false;
			UDPBroadcaster.Close();
		}
	}
}
