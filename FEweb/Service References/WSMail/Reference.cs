﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FE.WSMail {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="EnvioMail", ConfigurationName="WSMail.WSMailSoap")]
    public interface WSMailSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento mailTO del espacio de nombres EnvioMail no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="EnvioMail/EnvioMail", ReplyAction="*")]
        FE.WSMail.EnvioMailResponse EnvioMail(FE.WSMail.EnvioMailRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="EnvioMail/EnvioMail", ReplyAction="*")]
        System.Threading.Tasks.Task<FE.WSMail.EnvioMailResponse> EnvioMailAsync(FE.WSMail.EnvioMailRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EnvioMailRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EnvioMail", Namespace="EnvioMail", Order=0)]
        public FE.WSMail.EnvioMailRequestBody Body;
        
        public EnvioMailRequest() {
        }
        
        public EnvioMailRequest(FE.WSMail.EnvioMailRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="EnvioMail")]
    public partial class EnvioMailRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string mailTO;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string body;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string subject;
        
        public EnvioMailRequestBody() {
        }
        
        public EnvioMailRequestBody(string mailTO, string body, string subject) {
            this.mailTO = mailTO;
            this.body = body;
            this.subject = subject;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EnvioMailResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EnvioMailResponse", Namespace="EnvioMail", Order=0)]
        public FE.WSMail.EnvioMailResponseBody Body;
        
        public EnvioMailResponse() {
        }
        
        public EnvioMailResponse(FE.WSMail.EnvioMailResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="EnvioMail")]
    public partial class EnvioMailResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string EnvioMailResult;
        
        public EnvioMailResponseBody() {
        }
        
        public EnvioMailResponseBody(string EnvioMailResult) {
            this.EnvioMailResult = EnvioMailResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSMailSoapChannel : FE.WSMail.WSMailSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSMailSoapClient : System.ServiceModel.ClientBase<FE.WSMail.WSMailSoap>, FE.WSMail.WSMailSoap {
        
        public WSMailSoapClient() {
        }
        
        public WSMailSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSMailSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSMailSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSMailSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FE.WSMail.EnvioMailResponse FE.WSMail.WSMailSoap.EnvioMail(FE.WSMail.EnvioMailRequest request) {
            return base.Channel.EnvioMail(request);
        }
        
        public string EnvioMail(string mailTO, string body, string subject) {
            FE.WSMail.EnvioMailRequest inValue = new FE.WSMail.EnvioMailRequest();
            inValue.Body = new FE.WSMail.EnvioMailRequestBody();
            inValue.Body.mailTO = mailTO;
            inValue.Body.body = body;
            inValue.Body.subject = subject;
            FE.WSMail.EnvioMailResponse retVal = ((FE.WSMail.WSMailSoap)(this)).EnvioMail(inValue);
            return retVal.Body.EnvioMailResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FE.WSMail.EnvioMailResponse> FE.WSMail.WSMailSoap.EnvioMailAsync(FE.WSMail.EnvioMailRequest request) {
            return base.Channel.EnvioMailAsync(request);
        }
        
        public System.Threading.Tasks.Task<FE.WSMail.EnvioMailResponse> EnvioMailAsync(string mailTO, string body, string subject) {
            FE.WSMail.EnvioMailRequest inValue = new FE.WSMail.EnvioMailRequest();
            inValue.Body = new FE.WSMail.EnvioMailRequestBody();
            inValue.Body.mailTO = mailTO;
            inValue.Body.body = body;
            inValue.Body.subject = subject;
            return ((FE.WSMail.WSMailSoap)(this)).EnvioMailAsync(inValue);
        }
    }
}
