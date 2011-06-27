﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Repository", "Sender", "Message", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(SparksMessenger.Model.Data.Message), "UserInfo", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(SparksMessenger.Model.Data.User))]
[assembly: EdmRelationshipAttribute("Repository", "Receiver", "Message", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(SparksMessenger.Model.Data.Message), "UserInfo", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(SparksMessenger.Model.Data.User))]

#endregion

namespace SparksMessenger.Model.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class RepositoryContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new RepositoryContainer object using the connection string found in the 'RepositoryContainer' section of the application configuration file.
        /// </summary>
        public RepositoryContainer() : base("name=RepositoryContainer", "RepositoryContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new RepositoryContainer object.
        /// </summary>
        public RepositoryContainer(string connectionString) : base(connectionString, "RepositoryContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new RepositoryContainer object.
        /// </summary>
        public RepositoryContainer(EntityConnection connection) : base(connection, "RepositoryContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Message> Messages
        {
            get
            {
                if ((_Messages == null))
                {
                    _Messages = base.CreateObjectSet<Message>("Messages");
                }
                return _Messages;
            }
        }
        private ObjectSet<Message> _Messages;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Messages EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMessages(Message message)
        {
            base.AddObject("Messages", message);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Repository", Name="Message")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Message : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Message object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="body">Initial value of the Body property.</param>
        /// <param name="dateSent">Initial value of the DateSent property.</param>
        public static Message CreateMessage(global::System.Guid id, global::System.String body, global::System.DateTime dateSent)
        {
            Message message = new Message();
            message.Id = id;
            message.Body = body;
            message.DateSent = dateSent;
            return message;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Body
        {
            get
            {
                return _Body;
            }
            set
            {
                OnBodyChanging(value);
                ReportPropertyChanging("Body");
                _Body = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Body");
                OnBodyChanged();
            }
        }
        private global::System.String _Body;
        partial void OnBodyChanging(global::System.String value);
        partial void OnBodyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateSent
        {
            get
            {
                return _DateSent;
            }
            set
            {
                OnDateSentChanging(value);
                ReportPropertyChanging("DateSent");
                _DateSent = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateSent");
                OnDateSentChanged();
            }
        }
        private global::System.DateTime _DateSent;
        partial void OnDateSentChanging(global::System.DateTime value);
        partial void OnDateSentChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Repository", "Sender", "UserInfo")]
        public User Sender
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("Repository.Sender", "UserInfo").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("Repository.Sender", "UserInfo").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> SenderReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("Repository.Sender", "UserInfo");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("Repository.Sender", "UserInfo", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Repository", "Receiver", "UserInfo")]
        public User Receiver
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("Repository.Receiver", "UserInfo").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("Repository.Receiver", "UserInfo").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> ReceiverReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("Repository.Receiver", "UserInfo");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("Repository.Receiver", "UserInfo", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Repository", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static User CreateUser(global::System.Guid id, global::System.String name)
        {
            User user = new User();
            user.Id = id;
            user.Name = name;
            return user;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Repository", "Sender", "Message")]
        public EntityCollection<Message> SentMessages
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Message>("Repository.Sender", "Message");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Message>("Repository.Sender", "Message", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Repository", "Receiver", "Message")]
        public EntityCollection<Message> ReceivedMessages
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Message>("Repository.Receiver", "Message");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Message>("Repository.Receiver", "Message", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}