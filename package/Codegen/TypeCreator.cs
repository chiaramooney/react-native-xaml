﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Codegen
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeCreator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class TypeCreator : Generator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"#include ""pch.h""
#include ""XamlMetadata.h""
#include ""Crc32Str.h""

/*************************************************************
THIS FILE WAS AUTOMATICALLY GENERATED, DO NOT MODIFY MANUALLY
**************************************************************/

");
            
            #line 14 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeCreator.tt"
 foreach (var ns in Types.Select(t => t.GetNamespace()).Distinct()) { 
            
            #line default
            #line hidden
            this.Write("#include <winrt/");
            
            #line 15 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeCreator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ns));
            
            #line default
            #line hidden
            this.Write(".h>\r\n");
            
            #line 16 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeCreator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\nwinrt::Windows::Foundation::IInspectable XamlMetadata::Create");
            
            #line 18 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeCreator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("(const std::string& typeName) const {\r\n  auto key = COMPILE_TIME_CRC32_STR(typeNa" +
                    "me.c_str());\r\n  switch (key) {\r\n");
            
            #line 21 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeCreator.tt"
 foreach (var t in Types.Where(x => !x.IsAbstract)) { 
            
            #line default
            #line hidden
            this.Write("    case COMPILE_TIME_CRC32_STR(\"");
            
            #line 22 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeCreator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.ToJsName(t.GetName())));
            
            #line default
            #line hidden
            this.Write("\"): { return ");
            
            #line 22 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeCreator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.GetCppWinRTType(t)));
            
            #line default
            #line hidden
            this.Write("(); }\r\n");
            
            #line 23 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeCreator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("  \r\n  }\r\n  return nullptr;\r\n}\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}