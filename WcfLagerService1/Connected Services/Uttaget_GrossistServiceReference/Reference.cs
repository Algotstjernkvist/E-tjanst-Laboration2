﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfLagerService1.Uttaget_GrossistServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Uttaget_GrossistServiceReference.IGrossist")]
    public interface IGrossist {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrossist/Leverera", ReplyAction="http://tempuri.org/IGrossist/LevereraResponse")]
        int Leverera();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrossist/Leverera", ReplyAction="http://tempuri.org/IGrossist/LevereraResponse")]
        System.Threading.Tasks.Task<int> LevereraAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGrossistChannel : WcfLagerService1.Uttaget_GrossistServiceReference.IGrossist, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GrossistClient : System.ServiceModel.ClientBase<WcfLagerService1.Uttaget_GrossistServiceReference.IGrossist>, WcfLagerService1.Uttaget_GrossistServiceReference.IGrossist {
        
        public GrossistClient() {
        }
        
        public GrossistClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GrossistClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GrossistClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GrossistClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Leverera() {
            return base.Channel.Leverera();
        }
        
        public System.Threading.Tasks.Task<int> LevereraAsync() {
            return base.Channel.LevereraAsync();
        }
    }
}
