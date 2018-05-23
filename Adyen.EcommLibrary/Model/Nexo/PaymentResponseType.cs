﻿namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PaymentResponseType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ResponseType Response;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleDataType SaleData;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public POIDataType POIData;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentResultType PaymentResult;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyResult", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoyaltyResultType[] LoyaltyResult;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentReceipt", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentReceiptType[] PaymentReceipt;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomerOrder", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomerOrderType[] CustomerOrder;
    }
}