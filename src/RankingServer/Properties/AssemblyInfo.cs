﻿using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("NeoCity Ranking Server")]
[assembly: AssemblyDescription("NeoCity Ranking Server")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("DCNC")]
[assembly: AssemblyProduct("NeoCity Ranking Server")]
[assembly: AssemblyCopyright("Copyright © 2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b38bcc22-7671-4a73-8a4f-07fca96db5cf")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
#if DEBUG
[assembly: AssemblyInformationalVersion("0.2.{dmin:2015}.{chash:6}{!}-{branch}-debug")]
#else
[assembly: AssemblyInformationalVersion("0.2.{dmin:2015}.{chash:6}{!}-{branch}-release")]
#endif
[assembly: AssemblyVersion("0.2.0.0")]
[assembly: AssemblyFileVersion("0.2.0.0")]
/*[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]*/