namespace org.sifassociation.swa.flowcontrol
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class PingType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.sifassociation.org/contract/FlowControl/2.x", ConfigurationName="IptFlowControl")]
    public interface IptFlowControl
    {
        
        // CODEGEN: Generating message contract since the operation Ping is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sifassociation.org/contract/FlowControl-S11/2.x/Ping", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(DataModelErrorType), Action="http://www.sifassociation.org/contract/FlowControl/2.x/PingFault", Name="DataModelError", Namespace="http://www.sifassociation.org/message/soap/2.x")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        PongResponse Ping(PingRequest request);
        
        // CODEGEN: Generating message contract since the operation Sleep is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sifassociation.org/contract/FlowControl-S11/2.x/Sleep", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(DataModelErrorType), Action="http://www.sifassociation.org/contract/FlowControl/2.x/SleepFault", Name="DataModelError", Namespace="http://www.sifassociation.org/message/soap/2.x")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        PongResponse Sleep(SleepRequest request);
        
        // CODEGEN: Generating message contract since the operation Wakeup is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sifassociation.org/contract/FlowControl-S11/2.x/Wakeup", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(DataModelErrorType), Action="http://www.sifassociation.org/contract/FlowControl/2.x/WakeupFault", Name="DataModelError", Namespace="http://www.sifassociation.org/message/soap/2.x")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        PongResponse Wakeup(WakeupRequest request);
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
    public partial class PingRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
        public SIFHeaderType SIFHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x", Order=0)]
        public PingType Ping;
        
        public PingRequest()
        {
        }
        
        public PingRequest(SIFHeaderType SIFHeader, PingType Ping)
        {
            this.SIFHeader = SIFHeader;
            this.Ping = Ping;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PongResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
        public SIFHeaderType SIFHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x", Order=0)]
        public StatusType Status;
        
        public PongResponse()
        {
        }
        
        public PongResponse(SIFHeaderType SIFHeader, StatusType Status)
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
    public partial class SleepType
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SleepRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
        public SIFHeaderType SIFHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x", Order=0)]
        public SleepType Sleep;
        
        public SleepRequest()
        {
        }
        
        public SleepRequest(SIFHeaderType SIFHeader, SleepType Sleep)
        {
            this.SIFHeader = SIFHeader;
            this.Sleep = Sleep;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x")]
    public partial class WakeupType
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WakeupRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.sifassociation.org/transport/soap/2.x")]
        public SIFHeaderType SIFHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.sifassociation.org/message/soap/2.x", Order=0)]
        public WakeupType Wakeup;
        
        public WakeupRequest()
        {
        }
        
        public WakeupRequest(SIFHeaderType SIFHeader, WakeupType Wakeup)
        {
            this.SIFHeader = SIFHeader;
            this.Wakeup = Wakeup;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IptFlowControlChannel : IptFlowControl, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class IptFlowControlClient : System.ServiceModel.ClientBase<IptFlowControl>, IptFlowControl
    {
        
        public IptFlowControlClient()
        {
        }
        
        public IptFlowControlClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public IptFlowControlClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public IptFlowControlClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public IptFlowControlClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PongResponse IptFlowControl.Ping(PingRequest request)
        {
            return base.Channel.Ping(request);
        }
        
        public StatusType Ping(ref SIFHeaderType SIFHeader, PingType Ping1)
        {
            PingRequest inValue = new PingRequest();
            inValue.SIFHeader = SIFHeader;
            inValue.Ping = Ping1;
            PongResponse retVal = ((IptFlowControl)(this)).Ping(inValue);
            SIFHeader = retVal.SIFHeader;
            return retVal.Status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PongResponse IptFlowControl.Sleep(SleepRequest request)
        {
            return base.Channel.Sleep(request);
        }
        
        public StatusType Sleep(ref SIFHeaderType SIFHeader, SleepType Sleep1)
        {
            SleepRequest inValue = new SleepRequest();
            inValue.SIFHeader = SIFHeader;
            inValue.Sleep = Sleep1;
            PongResponse retVal = ((IptFlowControl)(this)).Sleep(inValue);
            SIFHeader = retVal.SIFHeader;
            return retVal.Status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PongResponse IptFlowControl.Wakeup(WakeupRequest request)
        {
            return base.Channel.Wakeup(request);
        }
        
        public StatusType Wakeup(ref SIFHeaderType SIFHeader, WakeupType Wakeup1)
        {
            WakeupRequest inValue = new WakeupRequest();
            inValue.SIFHeader = SIFHeader;
            inValue.Wakeup = Wakeup1;
            PongResponse retVal = ((IptFlowControl)(this)).Wakeup(inValue);
            SIFHeader = retVal.SIFHeader;
            return retVal.Status;
        }
    }
}
