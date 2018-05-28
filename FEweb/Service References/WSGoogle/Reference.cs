﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FE.WSGoogle {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="AccesoGoogle", ConfigurationName="WSGoogle.WSGoogleSoap")]
    public interface WSGoogleSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento input del espacio de nombres AccesoGoogle no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="AccesoGoogle/TraducirTexto", ReplyAction="*")]
        FE.WSGoogle.TraducirTextoResponse TraducirTexto(FE.WSGoogle.TraducirTextoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="AccesoGoogle/TraducirTexto", ReplyAction="*")]
        System.Threading.Tasks.Task<FE.WSGoogle.TraducirTextoResponse> TraducirTextoAsync(FE.WSGoogle.TraducirTextoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento input del espacio de nombres AccesoGoogle no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="AccesoGoogle/ConvertirValor", ReplyAction="*")]
        FE.WSGoogle.ConvertirValorResponse ConvertirValor(FE.WSGoogle.ConvertirValorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="AccesoGoogle/ConvertirValor", ReplyAction="*")]
        System.Threading.Tasks.Task<FE.WSGoogle.ConvertirValorResponse> ConvertirValorAsync(FE.WSGoogle.ConvertirValorRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento moneda del espacio de nombres AccesoGoogle no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="AccesoGoogle/RecuperarValor", ReplyAction="*")]
        FE.WSGoogle.RecuperarValorResponse RecuperarValor(FE.WSGoogle.RecuperarValorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="AccesoGoogle/RecuperarValor", ReplyAction="*")]
        System.Threading.Tasks.Task<FE.WSGoogle.RecuperarValorResponse> RecuperarValorAsync(FE.WSGoogle.RecuperarValorRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TraducirTextoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TraducirTexto", Namespace="AccesoGoogle", Order=0)]
        public FE.WSGoogle.TraducirTextoRequestBody Body;
        
        public TraducirTextoRequest() {
        }
        
        public TraducirTextoRequest(FE.WSGoogle.TraducirTextoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="AccesoGoogle")]
    public partial class TraducirTextoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string input;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string languagePair;
        
        public TraducirTextoRequestBody() {
        }
        
        public TraducirTextoRequestBody(string input, string languagePair) {
            this.input = input;
            this.languagePair = languagePair;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TraducirTextoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TraducirTextoResponse", Namespace="AccesoGoogle", Order=0)]
        public FE.WSGoogle.TraducirTextoResponseBody Body;
        
        public TraducirTextoResponse() {
        }
        
        public TraducirTextoResponse(FE.WSGoogle.TraducirTextoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="AccesoGoogle")]
    public partial class TraducirTextoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TraducirTextoResult;
        
        public TraducirTextoResponseBody() {
        }
        
        public TraducirTextoResponseBody(string TraducirTextoResult) {
            this.TraducirTextoResult = TraducirTextoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertirValorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertirValor", Namespace="AccesoGoogle", Order=0)]
        public FE.WSGoogle.ConvertirValorRequestBody Body;
        
        public ConvertirValorRequest() {
        }
        
        public ConvertirValorRequest(FE.WSGoogle.ConvertirValorRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="AccesoGoogle")]
    public partial class ConvertirValorRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string input;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string languagePair;
        
        public ConvertirValorRequestBody() {
        }
        
        public ConvertirValorRequestBody(string input, string languagePair) {
            this.input = input;
            this.languagePair = languagePair;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertirValorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertirValorResponse", Namespace="AccesoGoogle", Order=0)]
        public FE.WSGoogle.ConvertirValorResponseBody Body;
        
        public ConvertirValorResponse() {
        }
        
        public ConvertirValorResponse(FE.WSGoogle.ConvertirValorResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="AccesoGoogle")]
    public partial class ConvertirValorResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConvertirValorResult;
        
        public ConvertirValorResponseBody() {
        }
        
        public ConvertirValorResponseBody(string ConvertirValorResult) {
            this.ConvertirValorResult = ConvertirValorResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RecuperarValorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RecuperarValor", Namespace="AccesoGoogle", Order=0)]
        public FE.WSGoogle.RecuperarValorRequestBody Body;
        
        public RecuperarValorRequest() {
        }
        
        public RecuperarValorRequest(FE.WSGoogle.RecuperarValorRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="AccesoGoogle")]
    public partial class RecuperarValorRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string moneda;
        
        public RecuperarValorRequestBody() {
        }
        
        public RecuperarValorRequestBody(string moneda) {
            this.moneda = moneda;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RecuperarValorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RecuperarValorResponse", Namespace="AccesoGoogle", Order=0)]
        public FE.WSGoogle.RecuperarValorResponseBody Body;
        
        public RecuperarValorResponse() {
        }
        
        public RecuperarValorResponse(FE.WSGoogle.RecuperarValorResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="AccesoGoogle")]
    public partial class RecuperarValorResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string RecuperarValorResult;
        
        public RecuperarValorResponseBody() {
        }
        
        public RecuperarValorResponseBody(string RecuperarValorResult) {
            this.RecuperarValorResult = RecuperarValorResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSGoogleSoapChannel : FE.WSGoogle.WSGoogleSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSGoogleSoapClient : System.ServiceModel.ClientBase<FE.WSGoogle.WSGoogleSoap>, FE.WSGoogle.WSGoogleSoap {
        
        public WSGoogleSoapClient() {
        }
        
        public WSGoogleSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSGoogleSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSGoogleSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSGoogleSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FE.WSGoogle.TraducirTextoResponse FE.WSGoogle.WSGoogleSoap.TraducirTexto(FE.WSGoogle.TraducirTextoRequest request) {
            return base.Channel.TraducirTexto(request);
        }
        
        public string TraducirTexto(string input, string languagePair) {
            FE.WSGoogle.TraducirTextoRequest inValue = new FE.WSGoogle.TraducirTextoRequest();
            inValue.Body = new FE.WSGoogle.TraducirTextoRequestBody();
            inValue.Body.input = input;
            inValue.Body.languagePair = languagePair;
            FE.WSGoogle.TraducirTextoResponse retVal = ((FE.WSGoogle.WSGoogleSoap)(this)).TraducirTexto(inValue);
            return retVal.Body.TraducirTextoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FE.WSGoogle.TraducirTextoResponse> FE.WSGoogle.WSGoogleSoap.TraducirTextoAsync(FE.WSGoogle.TraducirTextoRequest request) {
            return base.Channel.TraducirTextoAsync(request);
        }
        
        public System.Threading.Tasks.Task<FE.WSGoogle.TraducirTextoResponse> TraducirTextoAsync(string input, string languagePair) {
            FE.WSGoogle.TraducirTextoRequest inValue = new FE.WSGoogle.TraducirTextoRequest();
            inValue.Body = new FE.WSGoogle.TraducirTextoRequestBody();
            inValue.Body.input = input;
            inValue.Body.languagePair = languagePair;
            return ((FE.WSGoogle.WSGoogleSoap)(this)).TraducirTextoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FE.WSGoogle.ConvertirValorResponse FE.WSGoogle.WSGoogleSoap.ConvertirValor(FE.WSGoogle.ConvertirValorRequest request) {
            return base.Channel.ConvertirValor(request);
        }
        
        public string ConvertirValor(string input, string languagePair) {
            FE.WSGoogle.ConvertirValorRequest inValue = new FE.WSGoogle.ConvertirValorRequest();
            inValue.Body = new FE.WSGoogle.ConvertirValorRequestBody();
            inValue.Body.input = input;
            inValue.Body.languagePair = languagePair;
            FE.WSGoogle.ConvertirValorResponse retVal = ((FE.WSGoogle.WSGoogleSoap)(this)).ConvertirValor(inValue);
            return retVal.Body.ConvertirValorResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FE.WSGoogle.ConvertirValorResponse> FE.WSGoogle.WSGoogleSoap.ConvertirValorAsync(FE.WSGoogle.ConvertirValorRequest request) {
            return base.Channel.ConvertirValorAsync(request);
        }
        
        public System.Threading.Tasks.Task<FE.WSGoogle.ConvertirValorResponse> ConvertirValorAsync(string input, string languagePair) {
            FE.WSGoogle.ConvertirValorRequest inValue = new FE.WSGoogle.ConvertirValorRequest();
            inValue.Body = new FE.WSGoogle.ConvertirValorRequestBody();
            inValue.Body.input = input;
            inValue.Body.languagePair = languagePair;
            return ((FE.WSGoogle.WSGoogleSoap)(this)).ConvertirValorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FE.WSGoogle.RecuperarValorResponse FE.WSGoogle.WSGoogleSoap.RecuperarValor(FE.WSGoogle.RecuperarValorRequest request) {
            return base.Channel.RecuperarValor(request);
        }
        
        public string RecuperarValor(string moneda) {
            FE.WSGoogle.RecuperarValorRequest inValue = new FE.WSGoogle.RecuperarValorRequest();
            inValue.Body = new FE.WSGoogle.RecuperarValorRequestBody();
            inValue.Body.moneda = moneda;
            FE.WSGoogle.RecuperarValorResponse retVal = ((FE.WSGoogle.WSGoogleSoap)(this)).RecuperarValor(inValue);
            return retVal.Body.RecuperarValorResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FE.WSGoogle.RecuperarValorResponse> FE.WSGoogle.WSGoogleSoap.RecuperarValorAsync(FE.WSGoogle.RecuperarValorRequest request) {
            return base.Channel.RecuperarValorAsync(request);
        }
        
        public System.Threading.Tasks.Task<FE.WSGoogle.RecuperarValorResponse> RecuperarValorAsync(string moneda) {
            FE.WSGoogle.RecuperarValorRequest inValue = new FE.WSGoogle.RecuperarValorRequest();
            inValue.Body = new FE.WSGoogle.RecuperarValorRequestBody();
            inValue.Body.moneda = moneda;
            return ((FE.WSGoogle.WSGoogleSoap)(this)).RecuperarValorAsync(inValue);
        }
    }
}