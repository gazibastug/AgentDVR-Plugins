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
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class configuration {
    
    private bool supportsAudioField;
    
    private bool supportsVideoField;
    
    private int band1Field;
    
    private int band2Field;
    
    private int band3Field;
    
    private int band4Field;
    
    private int band5Field;
    
    private int band6Field;
    
    private int band7Field;
    
    private int band8Field;
    
    private bool enabledField;
    
    public configuration() {
        this.supportsAudioField = true;
        this.supportsVideoField = false;
        this.band1Field = 0;
        this.band2Field = 0;
        this.band3Field = 0;
        this.band4Field = 0;
        this.band5Field = 0;
        this.band6Field = 0;
        this.band7Field = 0;
        this.band8Field = 0;
        this.enabledField = false;
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
    public int band1 {
        get {
            return this.band1Field;
        }
        set {
            this.band1Field = value;
        }
    }
    
    /// <remarks/>
    public int band2 {
        get {
            return this.band2Field;
        }
        set {
            this.band2Field = value;
        }
    }
    
    /// <remarks/>
    public int band3 {
        get {
            return this.band3Field;
        }
        set {
            this.band3Field = value;
        }
    }
    
    /// <remarks/>
    public int band4 {
        get {
            return this.band4Field;
        }
        set {
            this.band4Field = value;
        }
    }
    
    /// <remarks/>
    public int band5 {
        get {
            return this.band5Field;
        }
        set {
            this.band5Field = value;
        }
    }
    
    /// <remarks/>
    public int band6 {
        get {
            return this.band6Field;
        }
        set {
            this.band6Field = value;
        }
    }
    
    /// <remarks/>
    public int band7 {
        get {
            return this.band7Field;
        }
        set {
            this.band7Field = value;
        }
    }
    
    /// <remarks/>
    public int band8 {
        get {
            return this.band8Field;
        }
        set {
            this.band8Field = value;
        }
    }
    
    /// <remarks/>
    public bool enabled {
        get {
            return this.enabledField;
        }
        set {
            this.enabledField = value;
        }
    }
}
