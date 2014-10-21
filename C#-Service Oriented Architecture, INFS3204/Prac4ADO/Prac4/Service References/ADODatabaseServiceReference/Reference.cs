﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prac4.ADODatabaseServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/Prac4")]
    [System.SerializableAttribute()]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HealthInsuranceNOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhoneNumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HealthInsuranceNO {
            get {
                return this.HealthInsuranceNOField;
            }
            set {
                if ((object.ReferenceEquals(this.HealthInsuranceNOField, value) != true)) {
                    this.HealthInsuranceNOField = value;
                    this.RaisePropertyChanged("HealthInsuranceNO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((this.PhoneNumberField.Equals(value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor", Namespace="http://schemas.datacontract.org/2004/07/Prac4")]
    [System.SerializableAttribute()]
    public partial class Doctor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HealthProfessionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MedicalRegistrationNOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhoneNumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HealthProfession {
            get {
                return this.HealthProfessionField;
            }
            set {
                if ((object.ReferenceEquals(this.HealthProfessionField, value) != true)) {
                    this.HealthProfessionField = value;
                    this.RaisePropertyChanged("HealthProfession");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MedicalRegistrationNO {
            get {
                return this.MedicalRegistrationNOField;
            }
            set {
                if ((object.ReferenceEquals(this.MedicalRegistrationNOField, value) != true)) {
                    this.MedicalRegistrationNOField = value;
                    this.RaisePropertyChanged("MedicalRegistrationNO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((this.PhoneNumberField.Equals(value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Appointment", Namespace="http://schemas.datacontract.org/2004/07/Prac4")]
    [System.SerializableAttribute()]
    public partial class Appointment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime AppointmentDateAndTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClinicNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HealthInsuranceNOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MedicalRegistrationNOField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime AppointmentDateAndTime {
            get {
                return this.AppointmentDateAndTimeField;
            }
            set {
                if ((this.AppointmentDateAndTimeField.Equals(value) != true)) {
                    this.AppointmentDateAndTimeField = value;
                    this.RaisePropertyChanged("AppointmentDateAndTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClinicName {
            get {
                return this.ClinicNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ClinicNameField, value) != true)) {
                    this.ClinicNameField = value;
                    this.RaisePropertyChanged("ClinicName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HealthInsuranceNO {
            get {
                return this.HealthInsuranceNOField;
            }
            set {
                if ((object.ReferenceEquals(this.HealthInsuranceNOField, value) != true)) {
                    this.HealthInsuranceNOField = value;
                    this.RaisePropertyChanged("HealthInsuranceNO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MedicalRegistrationNO {
            get {
                return this.MedicalRegistrationNOField;
            }
            set {
                if ((object.ReferenceEquals(this.MedicalRegistrationNOField, value) != true)) {
                    this.MedicalRegistrationNOField = value;
                    this.RaisePropertyChanged("MedicalRegistrationNO");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ADODatabaseServiceReference.IADODatabaseService")]
    public interface IADODatabaseService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IADODatabaseService/PatientRegistration", ReplyAction="http://tempuri.org/IADODatabaseService/PatientRegistrationResponse")]
        bool PatientRegistration(Prac4.ADODatabaseServiceReference.Patient p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IADODatabaseService/DoctorRegistration", ReplyAction="http://tempuri.org/IADODatabaseService/DoctorRegistrationResponse")]
        bool DoctorRegistration(Prac4.ADODatabaseServiceReference.Doctor d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IADODatabaseService/GetPatientInfo", ReplyAction="http://tempuri.org/IADODatabaseService/GetPatientInfoResponse")]
        Prac4.ADODatabaseServiceReference.Patient GetPatientInfo(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IADODatabaseService/GetDoctorInfo", ReplyAction="http://tempuri.org/IADODatabaseService/GetDoctorInfoResponse")]
        Prac4.ADODatabaseServiceReference.Doctor GetDoctorInfo(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IADODatabaseService/AppointmentBooking", ReplyAction="http://tempuri.org/IADODatabaseService/AppointmentBookingResponse")]
        bool AppointmentBooking(string pfirstName, string plastName, string dfirstName, string dlastName, System.DateTime AppoitmentDateAndTime, string clinicName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IADODatabaseService/GetAppointment", ReplyAction="http://tempuri.org/IADODatabaseService/GetAppointmentResponse")]
        Prac4.ADODatabaseServiceReference.Appointment GetAppointment(string pfirstName, string plastName, string dfirstName, string dlastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IADODatabaseService/AppointmentReschedule", ReplyAction="http://tempuri.org/IADODatabaseService/AppointmentRescheduleResponse")]
        bool AppointmentReschedule(string pfirstName, string plastName, string dfirstName, string dlastName, System.DateTime newAppointmentTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IADODatabaseServiceChannel : Prac4.ADODatabaseServiceReference.IADODatabaseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ADODatabaseServiceClient : System.ServiceModel.ClientBase<Prac4.ADODatabaseServiceReference.IADODatabaseService>, Prac4.ADODatabaseServiceReference.IADODatabaseService {
        
        public ADODatabaseServiceClient() {
        }
        
        public ADODatabaseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ADODatabaseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ADODatabaseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ADODatabaseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool PatientRegistration(Prac4.ADODatabaseServiceReference.Patient p) {
            return base.Channel.PatientRegistration(p);
        }
        
        public bool DoctorRegistration(Prac4.ADODatabaseServiceReference.Doctor d) {
            return base.Channel.DoctorRegistration(d);
        }
        
        public Prac4.ADODatabaseServiceReference.Patient GetPatientInfo(string firstName, string lastName) {
            return base.Channel.GetPatientInfo(firstName, lastName);
        }
        
        public Prac4.ADODatabaseServiceReference.Doctor GetDoctorInfo(string firstName, string lastName) {
            return base.Channel.GetDoctorInfo(firstName, lastName);
        }
        
        public bool AppointmentBooking(string pfirstName, string plastName, string dfirstName, string dlastName, System.DateTime AppoitmentDateAndTime, string clinicName) {
            return base.Channel.AppointmentBooking(pfirstName, plastName, dfirstName, dlastName, AppoitmentDateAndTime, clinicName);
        }
        
        public Prac4.ADODatabaseServiceReference.Appointment GetAppointment(string pfirstName, string plastName, string dfirstName, string dlastName) {
            return base.Channel.GetAppointment(pfirstName, plastName, dfirstName, dlastName);
        }
        
        public bool AppointmentReschedule(string pfirstName, string plastName, string dfirstName, string dlastName, System.DateTime newAppointmentTime) {
            return base.Channel.AppointmentReschedule(pfirstName, plastName, dfirstName, dlastName, newAppointmentTime);
        }
    }
}
