﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Main.Strings {
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
    internal class FhOptions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FhOptions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Main.Strings.FhOptions", typeof(FhOptions).Assembly);
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
        ///   Looks up a localized string similar to A fragment of memory is used to reduce database lookups. You should not change this value unless you get warnings in the log..
        /// </summary>
        internal static string FhblockhashlookupsizeLong {
            get {
                return ResourceManager.GetString("FhblockhashlookupsizeLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Memory used by the block hash.
        /// </summary>
        internal static string FhblockhashlookupsizeShort {
            get {
                return ResourceManager.GetString("FhblockhashlookupsizeShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The blocksize determines how files are fragmented. Choosing a large value will cause a larger overhead on file changes, choosing a small value will cause a large overhead on storage of file lists. Note that the value cannot be changed after remote files are created..
        /// </summary>
        internal static string FhblocksizeLong {
            get {
                return ResourceManager.GetString("FhblocksizeLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Blocksize used in hashing.
        /// </summary>
        internal static string FhblocksizeShort {
            get {
                return ResourceManager.GetString("FhblocksizeShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option can be used to limit the scan to only files that are known to have changed. This is usually only activated in combination with a filesystem watcher that keeps track of file changes..
        /// </summary>
        internal static string FhchangedfilesetLong {
            get {
                return ResourceManager.GetString("FhchangedfilesetLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List of files to examine for changes.
        /// </summary>
        internal static string FhchangedfilesetShort {
            get {
                return ResourceManager.GetString("FhchangedfilesetShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to the file containing the local cache of the remote file database.
        /// </summary>
        internal static string FhdbpathLong {
            get {
                return ResourceManager.GetString("FhdbpathLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to the local state database.
        /// </summary>
        internal static string FhdbpathShort {
            get {
                return ResourceManager.GetString("FhdbpathShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option can be used to supply a list of deleted files. This option will be ignored unless the option {0} is also set..
        /// </summary>
        internal static string FhdeletedfilesetLong {
            get {
                return ResourceManager.GetString("FhdeletedfilesetLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List of deleted files.
        /// </summary>
        internal static string FhdeletedfilesetShort {
            get {
                return ResourceManager.GetString("FhdeletedfilesetShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A fragment of memory is used to reduce database lookups. You should not change this value unless you get warnings in the log..
        /// </summary>
        internal static string FhfilehashlookupsizeLong {
            get {
                return ResourceManager.GetString("FhfilehashlookupsizeLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Memory used by the file hash.
        /// </summary>
        internal static string FhfilehashlookupsizeShort {
            get {
                return ResourceManager.GetString("FhfilehashlookupsizeShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option can be used to speed up backup operations by keeping scantimes and other path related data in memory.
        /// </summary>
        internal static string FhfilepathlookupsizeLong {
            get {
                return ResourceManager.GetString("FhfilepathlookupsizeLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Memory used to keep paths cached.
        /// </summary>
        internal static string FhfilepathlookupsizeShort {
            get {
                return ResourceManager.GetString("FhfilepathlookupsizeShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stores empty metadata, such as file timestamps and attributes. This decreases the required storage space as well as the processing time..
        /// </summary>
        internal static string FhnometadataLong {
            get {
                return ResourceManager.GetString("FhnometadataLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disable storing file metadata.
        /// </summary>
        internal static string FhnometadataShort {
            get {
                return ResourceManager.GetString("FhnometadataShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A fragment of memory is used to reduce database lookups. You should not change this value unless you get warnings in the log..
        /// </summary>
        internal static string FhmetadatahashlookupsizeLong {
            get {
                return ResourceManager.GetString("FhmetadatahashlookupsizeLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Memory used by the metadata hash.
        /// </summary>
        internal static string FhmetadatahashlookupsizeShort {
            get {
                return ResourceManager.GetString("FhmetadatahashlookupsizeShort", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to If this flag is set, the local database is not compared to the remote filelist on startup. The intended usage for this option is to work correctly in cases where the filelisting is broken or unavailable..
        /// </summary>
        internal static string FhnobackendverificationLong {
            get {
                return ResourceManager.GetString("FhnobackendverificationLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not query backend at startup.
        /// </summary>
        internal static string FhnobackendverificationShort {
            get {
                return ResourceManager.GetString("FhnobackendverificationShort", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to If this flag is set, no shadow files are uploaded to the remote destination. This reduces the required storage as well as the required transfer, but makes restoring slower as more volumes must be downloaded..
        /// </summary>
        internal static string FhnoshadowfilesLong {
            get {
                return ResourceManager.GetString("FhnoshadowfilesLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not upload shadow files.
        /// </summary>
        internal static string FhnoshadowfilesShort {
            get {
                return ResourceManager.GetString("FhnoshadowfilesShort", resourceCulture);
            }
        }
    }
}
