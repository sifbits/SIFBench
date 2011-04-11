namespace org.sifassociation.swa.datamodel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class DataModelErrorType
    {
        
        /// <remarks/>
        public InfrastructureErrorCategoryType Category;
        
        /// <remarks/>
        public string Code;
        
        /// <remarks/>
        public string Desc;
        
        /// <remarks/>
        public string ExtendedDesc;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public enum InfrastructureErrorCategoryType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class StatusType
    {
        
        /// <remarks/>
        public InfrastructureStatusCodeType Code;
        
        /// <remarks/>
        public string Desc;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public enum InfrastructureStatusCodeType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.sifassociation.org/contract/DataModel/2.x", ConfigurationName="IptDataModel")]
    public interface IptDataModel
    {
        
        // CODEGEN: Generating message contract since the operation Event is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sifassociation.org/contract/DataModel-S11/2.x/Event", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(DataModelErrorType), Action="http://www.sifassociation.org/contract/DataModel/2.x/EventFault", Name="DataModelError", Namespace="http://www.sifassociation.org/message/soap/2.x")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        EventStatus Event(PostEvent request);
        
        // CODEGEN: Generating message contract since the operation Query is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sifassociation.org/contract/DataModel-S11/2.x/Query", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(DataModelErrorType), Action="http://www.sifassociation.org/contract/DataModel/2.x/QueryFault", Name="DataModelError", Namespace="http://www.sifassociation.org/message/soap/2.x")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        EventStatus Query(QueryRequest request);
        
        // CODEGEN: Generating message contract since the operation ExtendedQuery is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sifassociation.org/contract/DataModel-S11/2.x/ExtendedQuery", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(DataModelErrorType), Action="http://www.sifassociation.org/contract/DataModel/2.x/ExtendedQueryFault", Name="DataModelError", Namespace="http://www.sifassociation.org/message/soap/2.x")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        EventStatus ExtendedQuery(ExtendedQueryRequest request);
        
        // CODEGEN: Generating message contract since the operation QueryResults is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sifassociation.org/contract/DataModel-S11/2.x/QueryResults", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(DataModelErrorType), Action="http://www.sifassociation.org/contract/DataModel/2.x/QueryResultsFault", Name="DataModelError", Namespace="http://www.sifassociation.org/message/soap/2.x")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        EventStatus QueryResults(QueryResultsResponse request);
        
        // CODEGEN: Generating message contract since the operation ExtendedQueryResults is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sifassociation.org/contract/DataModel-S11/2.x/ExtendedQueryResults", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(DataModelErrorType), Action="http://www.sifassociation.org/contract/DataModel/2.x/ExtendedQueryResultsFault", Name="DataModelError", Namespace="http://www.sifassociation.org/message/soap/2.x")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        EventStatus ExtendedQueryResults(ExtendedQueryResultsResponse request);
        
        // CODEGEN: Generating message contract since the operation CancelRequests is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sifassociation.org/contract/DataModel-S11/2.x/CancelRequests", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(DataModelErrorType), Action="http://www.sifassociation.org/contract/DataModel/2.x/CancelRequestsFault", Name="DataModelError", Namespace="http://www.sifassociation.org/message/soap/2.x")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        EventStatus CancelRequests(CancelRequestsRequest request);
        
        // CODEGEN: Generating message contract since the operation DataModelError is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sifassociation.org/contract/DataModel-S11/2.x/DataModelError", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(DataModelErrorType), Action="http://www.sifassociation.org/contract/DataModel/2.x/ErrorRejectedFault", Name="DataModelError", Namespace="http://www.sifassociation.org/message/soap/2.x")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        EventStatus DataModelError(ErrorNotify request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
    public partial class SIFHeaderType
    {
        
        /// <remarks/>
        public System.DateTime Timestamp;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string ZoneId;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string InfrastructureVersion;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string DataModel;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string DataModelVersion;
        
        /// <remarks/>
        public SecurityType Security;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string SourceId;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string DestinationId;
        
        /// <remarks/>
        public PacketDataType PacketData;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Context", DataType="token", IsNullable=false)]
        public string[] Contexts;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string OriginalSourceId;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="NCName")]
        public string TopicName;
        
        /// <remarks/>
        public SIFHeaderTypeEventAction EventAction;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EventActionSpecified;
        
        /// <remarks/>
        public uint MaxBufferSize;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxBufferSizeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResponseVersion", DataType="token")]
        public string[] ResponseVersion;
        
        /// <remarks/>
        public ZoneServiceDataType ZoneServiceData;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
    public partial class SecurityType
    {
        
        /// <remarks/>
        public SecureChannelType SecureChannel;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
    public partial class SecureChannelType
    {
        
        /// <remarks/>
        public int AuthenticationLevel;
        
        /// <remarks/>
        public int EncryptionLevel;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
    public partial class PacketDataType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string PacketNumber;
        
        /// <remarks/>
        public YesNoType MorePackets;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
    public enum YesNoType
    {
        
        /// <remarks/>
        Yes,
        
        /// <remarks/>
        No,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/transport/soap/2.x")]
    public enum SIFHeaderTypeEventAction
    {
        
        /// <remarks/>
        Add,
        
        /// <remarks/>
        Delete,
        
        /// <remarks/>
        Change,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
    public partial class ZoneServiceDataType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="NCName")]
        public string Operation;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string ServiceMsgId;
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PostEvent
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
        public SIFHeaderType SIFHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x", Order=0)]
        public System.Xml.XmlElement Event;
        
        public PostEvent()
        {
        }
        
        public PostEvent(SIFHeaderType SIFHeader, System.Xml.XmlElement Event)
        {
            this.SIFHeader = SIFHeader;
            this.Event = Event;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EventStatus
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
        public SIFHeaderType SIFHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x", Order=0)]
        public StatusType Status;
        
        public EventStatus()
        {
        }
        
        public EventStatus(SIFHeaderType SIFHeader, StatusType Status)
        {
            this.SIFHeader = SIFHeader;
            this.Status = Status;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class QueryType
    {
        
        /// <remarks/>
        public QueryTypeQueryObject QueryObject;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConditionGroup", typeof(QueryTypeConditionGroup))]
        [System.Xml.Serialization.XmlElementAttribute("Example", typeof(System.Xml.XmlElement))]
        public object Item;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class QueryTypeQueryObject
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Element", DataType="normalizedString")]
        public string[] Element;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string ObjectName;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class QueryTypeConditionGroup
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Conditions")]
        public QueryTypeConditionGroupConditions[] Conditions;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public QueryTypeConditionGroupType Type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class QueryTypeConditionGroupConditions
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Condition")]
        public QueryTypeConditionGroupConditionsCondition[] Condition;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public QueryTypeConditionGroupConditionsType Type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class QueryTypeConditionGroupConditionsCondition
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Element;
        
        /// <remarks/>
        public QueryTypeConditionGroupConditionsConditionOperator Operator;
        
        /// <remarks/>
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public enum QueryTypeConditionGroupConditionsConditionOperator
    {
        
        /// <remarks/>
        EQ,
        
        /// <remarks/>
        LT,
        
        /// <remarks/>
        GT,
        
        /// <remarks/>
        LE,
        
        /// <remarks/>
        GE,
        
        /// <remarks/>
        NE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public enum QueryTypeConditionGroupConditionsType
    {
        
        /// <remarks/>
        And,
        
        /// <remarks/>
        Or,
        
        /// <remarks/>
        None,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public enum QueryTypeConditionGroupType
    {
        
        /// <remarks/>
        And,
        
        /// <remarks/>
        Or,
        
        /// <remarks/>
        None,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
        public SIFHeaderType SIFHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x", Order=0)]
        public QueryType Query;
        
        public QueryRequest()
        {
        }
        
        public QueryRequest(SIFHeaderType SIFHeader, QueryType Query)
        {
            this.SIFHeader = SIFHeader;
            this.Query = Query;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string DestinationProvider;
        
        /// <remarks/>
        public ExtendedQueryTypeSelect Select;
        
        /// <remarks/>
        public ExtendedQueryTypeFrom From;
        
        /// <remarks/>
        public ExtendedQueryTypeWhere Where;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Element", IsNullable=false)]
        public ExtendedQueryTypeElement[] OrderBy;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeSelect
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Element")]
        public ExtendedQueryTypeSelectElement[] Element;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Distinct;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RowCount;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeSelectElement
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string Alias;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string ObjectName;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeFrom
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Join")]
        public ExtendedQueryTypeFromJoin[] Join;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string ObjectName;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeFromJoin
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JoinOn")]
        public ExtendedQueryTypeFromJoinJoinOn[] JoinOn;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ExtendedQueryTypeFromJoinType Type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeFromJoinJoinOn
    {
        
        /// <remarks/>
        public ExtendedQueryTypeFromJoinJoinOnLeftElement LeftElement;
        
        /// <remarks/>
        public ExtendedQueryTypeFromJoinJoinOnRightElement RightElement;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeFromJoinJoinOnLeftElement
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string ObjectName;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeFromJoinJoinOnRightElement
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string ObjectName;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public enum ExtendedQueryTypeFromJoinType
    {
        
        /// <remarks/>
        Inner,
        
        /// <remarks/>
        LeftOuter,
        
        /// <remarks/>
        RightOuter,
        
        /// <remarks/>
        FullOuter,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeWhere
    {
        
        /// <remarks/>
        public ExtendedQueryTypeWhereConditionGroup ConditionGroup;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeWhereConditionGroup
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Conditions")]
        public ExtendedQueryTypeWhereConditionGroupConditions[] Conditions;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ExtendedQueryTypeWhereConditionGroupType Type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeWhereConditionGroupConditions
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Condition")]
        public ExtendedQueryTypeWhereConditionGroupConditionsCondition[] Condition;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ExtendedQueryTypeWhereConditionGroupConditionsType Type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeWhereConditionGroupConditionsCondition
    {
        
        /// <remarks/>
        public ExtendedQueryTypeWhereConditionGroupConditionsConditionElement Element;
        
        /// <remarks/>
        public ExtendedQueryTypeWhereConditionGroupConditionsConditionOperator Operator;
        
        /// <remarks/>
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeWhereConditionGroupConditionsConditionElement
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string ObjectName;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public enum ExtendedQueryTypeWhereConditionGroupConditionsConditionOperator
    {
        
        /// <remarks/>
        EQ,
        
        /// <remarks/>
        LT,
        
        /// <remarks/>
        GT,
        
        /// <remarks/>
        LE,
        
        /// <remarks/>
        GE,
        
        /// <remarks/>
        NE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public enum ExtendedQueryTypeWhereConditionGroupConditionsType
    {
        
        /// <remarks/>
        And,
        
        /// <remarks/>
        Or,
        
        /// <remarks/>
        None,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public enum ExtendedQueryTypeWhereConditionGroupType
    {
        
        /// <remarks/>
        And,
        
        /// <remarks/>
        Or,
        
        /// <remarks/>
        None,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryTypeElement
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string ObjectName;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ExtendedQueryTypeElementOrdering Ordering;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public enum ExtendedQueryTypeElementOrdering
    {
        
        /// <remarks/>
        Ascending,
        
        /// <remarks/>
        Descending,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExtendedQueryRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
        public SIFHeaderType SIFHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x", Order=0)]
        public ExtendedQueryType ExtendedQuery;
        
        public ExtendedQueryRequest()
        {
        }
        
        public ExtendedQueryRequest(SIFHeaderType SIFHeader, ExtendedQueryType ExtendedQuery)
        {
            this.SIFHeader = SIFHeader;
            this.ExtendedQuery = ExtendedQuery;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryResultsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
        public SIFHeaderType SIFHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x", Order=0)]
        public System.Xml.XmlElement QueryResults;
        
        public QueryResultsResponse()
        {
        }
        
        public QueryResultsResponse(SIFHeaderType SIFHeader, System.Xml.XmlElement QueryResults)
        {
            this.SIFHeader = SIFHeader;
            this.QueryResults = QueryResults;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryResultsType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Element", IsNullable=false)]
        public ExtendedQueryResultsTypeElement[] ColumnHeaders;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("R", IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("C", IsNullable=false, NestingLevel=1)]
        public SelectedContentType[][] Rows;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class ExtendedQueryResultsTypeElement
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string ObjectName;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string Alias;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class SelectedContentType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExtendedQueryResultsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
        public SIFHeaderType SIFHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x", Order=0)]
        public ExtendedQueryResultsType ExtendedQueryResults;
        
        public ExtendedQueryResultsResponse()
        {
        }
        
        public ExtendedQueryResultsResponse(SIFHeaderType SIFHeader, ExtendedQueryResultsType ExtendedQueryResults)
        {
            this.SIFHeader = SIFHeader;
            this.ExtendedQueryResults = ExtendedQueryResults;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class CancelRequestsType
    {
        
        /// <remarks/>
        public CancelRequestsTypeNotificationType NotificationType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RequestMsgId", DataType="token", IsNullable=false)]
        public string[] RequestMsgIds;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public enum CancelRequestsTypeNotificationType
    {
        
        /// <remarks/>
        Standard,
        
        /// <remarks/>
        None,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CancelRequestsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
        public SIFHeaderType SIFHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x", Order=0)]
        public CancelRequestsType CancelRequests;
        
        public CancelRequestsRequest()
        {
        }
        
        public CancelRequestsRequest(SIFHeaderType SIFHeader, CancelRequestsType CancelRequests)
        {
            this.SIFHeader = SIFHeader;
            this.CancelRequests = CancelRequests;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ErrorNotify
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
        public SIFHeaderType SIFHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x", Order=0)]
        public DataModelErrorType DataModelError;
        
        public ErrorNotify()
        {
        }
        
        public ErrorNotify(SIFHeaderType SIFHeader, DataModelErrorType DataModelError)
        {
            this.SIFHeader = SIFHeader;
            this.DataModelError = DataModelError;
        }
    }
    
    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=System.ServiceModel.InstanceContextMode.PerCall, ConcurrencyMode=System.ServiceModel.ConcurrencyMode.Single, UseSynchronizationContext=false)]
    public partial class ptDataModel : IptDataModel
    {
        
        public virtual EventStatus Event(PostEvent request)
        {
            return EventImplementation(request);
        }

     
        
        public virtual EventStatus Query(QueryRequest request)
        {
            return QueryImplementation(request);
        }

     
        public virtual EventStatus ExtendedQuery(ExtendedQueryRequest request)
        {
            return ExtendedQueryImplementation(request);
        }

       
        
        public virtual EventStatus QueryResults(QueryResultsResponse request)
        {
            return QueryResultsImplementation(request);
        }

      
        
        public virtual EventStatus ExtendedQueryResults(ExtendedQueryResultsResponse request)
        {
            return ExtendedQueryResultsImplementation(request);
        }

       
        
        public virtual EventStatus CancelRequests(CancelRequestsRequest request)
        {
            return CancelRequestsImplementation(request);
        }

        
        
        public virtual EventStatus DataModelError(ErrorNotify request)
        {
            return DataModelErrorImplementation(request);
        }

       
    }
}
