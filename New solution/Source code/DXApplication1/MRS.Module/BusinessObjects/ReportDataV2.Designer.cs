//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MRS.Module.BusinessObjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReportDataV2
    {
        private int _id;
    	public int Id 
    	{ 
    		get { return _id; } 
    		protected set
    		{
    			if (value != _id) {
    				_id = value;
    				 OnIdChanged();
    			}
    		} 
    	}
    	partial void OnIdChanged(); 
    
        private bool _isInplaceReport;
    	public bool IsInplaceReport 
    	{ 
    		get { return _isInplaceReport; } 
    		set
    		{
    			if (value != _isInplaceReport) {
    				_isInplaceReport = value;
    				 OnIsInplaceReportChanged();
    			}
    		} 
    	}
    	partial void OnIsInplaceReportChanged(); 
    
        private string _displayName;
    	public string DisplayName 
    	{ 
    		get { return _displayName; } 
    		set
    		{
    			if (value != _displayName) {
    				_displayName = value;
    				 OnDisplayNameChanged();
    			}
    		} 
    	}
    	partial void OnDisplayNameChanged(); 
    
        private string _dataTypeName;
    	public string DataTypeName 
    	{ 
    		get { return _dataTypeName; } 
    		set
    		{
    			if (value != _dataTypeName) {
    				_dataTypeName = value;
    				 OnDataTypeNameChanged();
    			}
    		} 
    	}
    	partial void OnDataTypeNameChanged(); 
    
        private string _predefinedReportTypeName;
    	public string PredefinedReportTypeName 
    	{ 
    		get { return _predefinedReportTypeName; } 
    		set
    		{
    			if (value != _predefinedReportTypeName) {
    				_predefinedReportTypeName = value;
    				 OnPredefinedReportTypeNameChanged();
    			}
    		} 
    	}
    	partial void OnPredefinedReportTypeNameChanged(); 
    
        private byte[] _content;
    	public byte[] Content 
    	{ 
    		get { return _content; } 
    		set
    		{
    			if (value != _content) {
    				_content = value;
    				 OnContentChanged();
    			}
    		} 
    	}
    	partial void OnContentChanged(); 
    
        private string _parametersObjectTypeName;
    	public string ParametersObjectTypeName 
    	{ 
    		get { return _parametersObjectTypeName; } 
    		set
    		{
    			if (value != _parametersObjectTypeName) {
    				_parametersObjectTypeName = value;
    				 OnParametersObjectTypeNameChanged();
    			}
    		} 
    	}
    	partial void OnParametersObjectTypeNameChanged(); 
    
    }
}
