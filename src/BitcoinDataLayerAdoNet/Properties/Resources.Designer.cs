﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BitcoinDataLayerAdoNet.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BitcoinDataLayerAdoNet.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -------------------------------------------------------------------------
        ///-- &lt;copyright file=&quot;SeedData.sql&quot;&gt;
        ///-- Copyright © Ladislau Molnar. All rights reserved.
        ///-- &lt;/copyright&gt;
        ///-------------------------------------------------------------------------
        ///
        ///-- START SECTION
        ///INSERT INTO BtcDbSettings(PropertyName, PropertyValue) VALUES(&apos;DB-VERSION&apos;, 1)
        ///.
        /// </summary>
        internal static string SeedData {
            get {
                return ResourceManager.GetString("SeedData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -------------------------------------------------------------------------
        ///-- &lt;copyright file=&quot;Tables.sql&quot;&gt;
        ///-- Copyright © Ladislau Molnar. All rights reserved.
        ///-- &lt;/copyright&gt;
        ///-------------------------------------------------------------------------
        ///
        ///-- START SECTION
        ///
        ///-- ==========================================================================
        ///-- Note about all hashes:
        ///-- The hashes are stored in reverse order from what is the normal result 
        ///-- of hashing. This is so to be consistent with sites  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Tables {
            get {
                return ResourceManager.GetString("Tables", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --=============================================================================
        ///-- &lt;copyright file=&quot;Views.sql&quot;&gt;
        ///-- Copyright © Ladislau Molnar. All rights reserved.
        ///-- &lt;/copyright&gt;
        ///--=============================================================================
        ///
        ///--=============================================================================
        ///-- This file contains SQL views that are added to the database in a 
        ///-- production environment when the database is created.
        ///--================================== [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Views {
            get {
                return ResourceManager.GetString("Views", resourceCulture);
            }
        }
    }
}
