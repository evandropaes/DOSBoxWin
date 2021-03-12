using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

[assembly: ObfuscateAssembly(true, StripAfterObfuscation = true)]
[assembly: Obfuscation(Feature = "all", ApplyToMembers = true, StripAfterObfuscation = true, Exclude = false)]
[assembly: Obfuscation(Feature = "code control flow obfuscation", StripAfterObfuscation = true, Exclude = false)]
[assembly: Obfuscation(Feature = "PEVerify", StripAfterObfuscation = true, Exclude = false)]

[assembly: Obfuscation(Feature = "merge with FreeZip.dll", Exclude = false)]


//[assembly: Obfuscation(Feature = "ilmerge custom parameters: /keyfile:DosBlaster.snk", Exclude = false)]
//[assembly: Obfuscation(Feature = "encrypt symbol names with password XXXXXX", Exclude = false)]
// BUG: encrypt resources [compress] cannot
//[assembly: Obfuscation(Feature = "encrypt resources", Exclude = false)]
