﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class configuration {
    
    private bool supportsAudioField;
    
    private bool supportsVideoField;
    
    private int delayField;
    
    public configuration() {
        this.supportsAudioField = true;
        this.supportsVideoField = true;
        this.delayField = 0;
    }
    
    /// <remarks/>
    public bool SupportsAudio {
        get {
            return this.supportsAudioField;
        }
        set {
            this.supportsAudioField = value;
        }
    }
    
    /// <remarks/>
    public bool SupportsVideo {
        get {
            return this.supportsVideoField;
        }
        set {
            this.supportsVideoField = value;
        }
    }
    
    /// <remarks/>
    public int Delay {
        get {
            return this.delayField;
        }
        set {
            this.delayField = value;
        }
    }
}