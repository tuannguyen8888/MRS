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
    
    public partial class XafModuleInfo
    {
        private int _iD;
    	public int ID 
    	{ 
    		get { return _iD; } 
    		protected set
    		{
    			if (value != _iD) {
    				_iD = value;
    				 OnIDChanged();
    			}
    		} 
    	}
    	partial void OnIDChanged(); 
    
        private string _name;
    	public string Name 
    	{ 
    		get { return _name; } 
    		set
    		{
    			if (value != _name) {
    				_name = value;
    				 OnNameChanged();
    			}
    		} 
    	}
    	partial void OnNameChanged(); 
    
        private string _version;
    	public string Version 
    	{ 
    		get { return _version; } 
    		set
    		{
    			if (value != _version) {
    				_version = value;
    				 OnVersionChanged();
    			}
    		} 
    	}
    	partial void OnVersionChanged(); 
    
        private string _assemblyFileName;
    	public string AssemblyFileName 
    	{ 
    		get { return _assemblyFileName; } 
    		set
    		{
    			if (value != _assemblyFileName) {
    				_assemblyFileName = value;
    				 OnAssemblyFileNameChanged();
    			}
    		} 
    	}
    	partial void OnAssemblyFileNameChanged(); 
    
        private bool _isMain;
    	public bool IsMain 
    	{ 
    		get { return _isMain; } 
    		set
    		{
    			if (value != _isMain) {
    				_isMain = value;
    				 OnIsMainChanged();
    			}
    		} 
    	}
    	partial void OnIsMainChanged(); 
    
    }
}
