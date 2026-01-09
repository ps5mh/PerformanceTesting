using Puerts.TypeMapping;
using Puerts;

namespace PuertsStaticWrap
{
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class PuerRegisterInfo_Gen
    {
        
        public static RegisterInfo GetRegisterInfo_Example01_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example01_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example01_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example01_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example01_Wrap.M_RunLua
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example01_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example01_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example01_Wrap.G_Target
#endif
                    }},
                    {"Payload_static", new MemberRegisterInfo { Name = "Payload", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example01_Wrap.F_Payload
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example02_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example02_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example02_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example02_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example02_Wrap.M_RunLua
#endif
                    }},
                    {"Payload", new MemberRegisterInfo { Name = "Payload", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example02_Wrap.M_Payload
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example02_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example02_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example02_Wrap.G_Target
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example10_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example10_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example10_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example10_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example10_Wrap.M_RunLua
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example10_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example10_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example10_Wrap.G_Target
#endif
                    }},
                    {"Payload_static", new MemberRegisterInfo { Name = "Payload", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example10_Wrap.F_Payload
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example11_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example11_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example11_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example11_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example11_Wrap.M_RunLua
#endif
                    }},
                    {"Payload", new MemberRegisterInfo { Name = "Payload", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example11_Wrap.M_Payload
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example11_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example11_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example11_Wrap.G_Target
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example12_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example12_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example12_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example12_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example12_Wrap.M_RunLua
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example12_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example12_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example12_Wrap.G_Target
#endif
                    }},
                    {"Payload_static", new MemberRegisterInfo { Name = "Payload", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example12_Wrap.F_Payload
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example13_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example13_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example13_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example13_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example13_Wrap.M_RunLua
#endif
                    }},
                    {"Payload", new MemberRegisterInfo { Name = "Payload", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example13_Wrap.M_Payload
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example13_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example13_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example13_Wrap.G_Target
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example20_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example20_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example20_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example20_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example20_Wrap.M_RunLua
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example20_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example20_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example20_Wrap.G_Target
#endif
                    }},
                    {"Payload_static", new MemberRegisterInfo { Name = "Payload", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example20_Wrap.F_Payload
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example21_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example21_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example21_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example21_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example21_Wrap.M_RunLua
#endif
                    }},
                    {"Payload", new MemberRegisterInfo { Name = "Payload", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example21_Wrap.M_Payload
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example21_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example21_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example21_Wrap.G_Target
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example22_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example22_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example22_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example22_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example22_Wrap.M_RunLua
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example22_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example22_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example22_Wrap.G_Target
#endif
                    }},
                    {"Payload_static", new MemberRegisterInfo { Name = "Payload", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example22_Wrap.F_Payload
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example23_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example23_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example23_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example23_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example23_Wrap.M_RunLua
#endif
                    }},
                    {"Payload", new MemberRegisterInfo { Name = "Payload", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example23_Wrap.M_Payload
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example23_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example23_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example23_Wrap.G_Target
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example30_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example30_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example30_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example30_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example30_Wrap.M_RunLua
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example30_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example30_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example30_Wrap.G_Target
#endif
                    }},
                    {"Payload_static", new MemberRegisterInfo { Name = "Payload", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example30_Wrap.F_Payload
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example31_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example31_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example31_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example31_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example31_Wrap.M_RunLua
#endif
                    }},
                    {"Payload", new MemberRegisterInfo { Name = "Payload", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example31_Wrap.M_Payload
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example31_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example31_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example31_Wrap.G_Target
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example32_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example32_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example32_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example32_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example32_Wrap.M_RunLua
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example32_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example32_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example32_Wrap.G_Target
#endif
                    }},
                    {"Payload_static", new MemberRegisterInfo { Name = "Payload", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example32_Wrap.F_Payload
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example33_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example33_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example33_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example33_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example33_Wrap.M_RunLua
#endif
                    }},
                    {"Payload", new MemberRegisterInfo { Name = "Payload", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example33_Wrap.M_Payload
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example33_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example33_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example33_Wrap.G_Target
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example34_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example34_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example34_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example34_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example34_Wrap.M_RunLua
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example34_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example34_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example34_Wrap.G_Target
#endif
                    }},
                    {"Payload_static", new MemberRegisterInfo { Name = "Payload", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example34_Wrap.F_Payload
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example35_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example35_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example35_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example35_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example35_Wrap.M_RunLua
#endif
                    }},
                    {"Payload", new MemberRegisterInfo { Name = "Payload", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example35_Wrap.M_Payload
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example35_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example35_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example35_Wrap.G_Target
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example91_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example91_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example91_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example91_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example91_Wrap.M_RunLua
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example91_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example91_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example91_Wrap.G_Target
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Example92_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Example92_Wrap.Constructor
#endif
                    }},
                    {"RunCS", new MemberRegisterInfo { Name = "RunCS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example92_Wrap.M_RunCS
#endif
                    }},
                    {"RunJS", new MemberRegisterInfo { Name = "RunJS", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example92_Wrap.M_RunJS
#endif
                    }},
                    {"RunLua", new MemberRegisterInfo { Name = "RunLua", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example92_Wrap.M_RunLua
#endif
                    }},
                    {"Static", new MemberRegisterInfo { Name = "Static", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example92_Wrap.G_Static
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example92_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Example92_Wrap.G_Target
#endif
                    }},
                    {"Payload_static", new MemberRegisterInfo { Name = "Payload", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Example92_Wrap.F_Payload
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Application_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Application_Wrap.Constructor
#endif
                    }},
                    {"add_lowMemory_static", new MemberRegisterInfo { Name = "add_lowMemory", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_lowMemory
#endif
                    }},
                    {"remove_lowMemory_static", new MemberRegisterInfo { Name = "remove_lowMemory", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_lowMemory
#endif
                    }},
                    {"add_memoryUsageChanged_static", new MemberRegisterInfo { Name = "add_memoryUsageChanged", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_memoryUsageChanged
#endif
                    }},
                    {"remove_memoryUsageChanged_static", new MemberRegisterInfo { Name = "remove_memoryUsageChanged", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_memoryUsageChanged
#endif
                    }},
                    {"add_logMessageReceived_static", new MemberRegisterInfo { Name = "add_logMessageReceived", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_logMessageReceived
#endif
                    }},
                    {"remove_logMessageReceived_static", new MemberRegisterInfo { Name = "remove_logMessageReceived", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_logMessageReceived
#endif
                    }},
                    {"add_logMessageReceivedThreaded_static", new MemberRegisterInfo { Name = "add_logMessageReceivedThreaded", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_logMessageReceivedThreaded
#endif
                    }},
                    {"remove_logMessageReceivedThreaded_static", new MemberRegisterInfo { Name = "remove_logMessageReceivedThreaded", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_logMessageReceivedThreaded
#endif
                    }},
                    {"add_onBeforeRender_static", new MemberRegisterInfo { Name = "add_onBeforeRender", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_onBeforeRender
#endif
                    }},
                    {"remove_onBeforeRender_static", new MemberRegisterInfo { Name = "remove_onBeforeRender", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_onBeforeRender
#endif
                    }},
                    {"add_focusChanged_static", new MemberRegisterInfo { Name = "add_focusChanged", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_focusChanged
#endif
                    }},
                    {"remove_focusChanged_static", new MemberRegisterInfo { Name = "remove_focusChanged", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_focusChanged
#endif
                    }},
                    {"add_deepLinkActivated_static", new MemberRegisterInfo { Name = "add_deepLinkActivated", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_deepLinkActivated
#endif
                    }},
                    {"remove_deepLinkActivated_static", new MemberRegisterInfo { Name = "remove_deepLinkActivated", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_deepLinkActivated
#endif
                    }},
                    {"add_wantsToQuit_static", new MemberRegisterInfo { Name = "add_wantsToQuit", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_wantsToQuit
#endif
                    }},
                    {"remove_wantsToQuit_static", new MemberRegisterInfo { Name = "remove_wantsToQuit", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_wantsToQuit
#endif
                    }},
                    {"add_quitting_static", new MemberRegisterInfo { Name = "add_quitting", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_quitting
#endif
                    }},
                    {"remove_quitting_static", new MemberRegisterInfo { Name = "remove_quitting", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_quitting
#endif
                    }},
                    {"add_unloading_static", new MemberRegisterInfo { Name = "add_unloading", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.A_unloading
#endif
                    }},
                    {"remove_unloading_static", new MemberRegisterInfo { Name = "remove_unloading", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.R_unloading
#endif
                    }},
                    {"Quit_static", new MemberRegisterInfo { Name = "Quit", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_Quit
#endif
                    }},
                    {"Unload_static", new MemberRegisterInfo { Name = "Unload", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_Unload
#endif
                    }},
                    {"CanStreamedLevelBeLoaded_static", new MemberRegisterInfo { Name = "CanStreamedLevelBeLoaded", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_CanStreamedLevelBeLoaded
#endif
                    }},
                    {"IsPlaying_static", new MemberRegisterInfo { Name = "IsPlaying", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_IsPlaying
#endif
                    }},
                    {"HasProLicense_static", new MemberRegisterInfo { Name = "HasProLicense", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_HasProLicense
#endif
                    }},
                    {"RequestAdvertisingIdentifierAsync_static", new MemberRegisterInfo { Name = "RequestAdvertisingIdentifierAsync", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_RequestAdvertisingIdentifierAsync
#endif
                    }},
                    {"OpenURL_static", new MemberRegisterInfo { Name = "OpenURL", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_OpenURL
#endif
                    }},
                    {"GetStackTraceLogType_static", new MemberRegisterInfo { Name = "GetStackTraceLogType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_GetStackTraceLogType
#endif
                    }},
                    {"SetStackTraceLogType_static", new MemberRegisterInfo { Name = "SetStackTraceLogType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_SetStackTraceLogType
#endif
                    }},
                    {"RequestUserAuthorization_static", new MemberRegisterInfo { Name = "RequestUserAuthorization", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_RequestUserAuthorization
#endif
                    }},
                    {"HasUserAuthorization_static", new MemberRegisterInfo { Name = "HasUserAuthorization", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Application_Wrap.F_HasUserAuthorization
#endif
                    }},
                    {"isPlaying_static", new MemberRegisterInfo { Name = "isPlaying", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_isPlaying
#endif
                    }},
                    {"isFocused_static", new MemberRegisterInfo { Name = "isFocused", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_isFocused
#endif
                    }},
                    {"buildGUID_static", new MemberRegisterInfo { Name = "buildGUID", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_buildGUID
#endif
                    }},
                    {"runInBackground_static", new MemberRegisterInfo { Name = "runInBackground", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_runInBackground, PropertySetter = UnityEngine_Application_Wrap.S_runInBackground
#endif
                    }},
                    {"isBatchMode_static", new MemberRegisterInfo { Name = "isBatchMode", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_isBatchMode
#endif
                    }},
                    {"dataPath_static", new MemberRegisterInfo { Name = "dataPath", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_dataPath
#endif
                    }},
                    {"streamingAssetsPath_static", new MemberRegisterInfo { Name = "streamingAssetsPath", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_streamingAssetsPath
#endif
                    }},
                    {"persistentDataPath_static", new MemberRegisterInfo { Name = "persistentDataPath", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_persistentDataPath
#endif
                    }},
                    {"temporaryCachePath_static", new MemberRegisterInfo { Name = "temporaryCachePath", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_temporaryCachePath
#endif
                    }},
                    {"absoluteURL_static", new MemberRegisterInfo { Name = "absoluteURL", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_absoluteURL
#endif
                    }},
                    {"unityVersion_static", new MemberRegisterInfo { Name = "unityVersion", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_unityVersion
#endif
                    }},
                    {"version_static", new MemberRegisterInfo { Name = "version", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_version
#endif
                    }},
                    {"installerName_static", new MemberRegisterInfo { Name = "installerName", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_installerName
#endif
                    }},
                    {"identifier_static", new MemberRegisterInfo { Name = "identifier", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_identifier
#endif
                    }},
                    {"installMode_static", new MemberRegisterInfo { Name = "installMode", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_installMode
#endif
                    }},
                    {"sandboxType_static", new MemberRegisterInfo { Name = "sandboxType", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_sandboxType
#endif
                    }},
                    {"productName_static", new MemberRegisterInfo { Name = "productName", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_productName
#endif
                    }},
                    {"companyName_static", new MemberRegisterInfo { Name = "companyName", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_companyName
#endif
                    }},
                    {"cloudProjectId_static", new MemberRegisterInfo { Name = "cloudProjectId", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_cloudProjectId
#endif
                    }},
                    {"targetFrameRate_static", new MemberRegisterInfo { Name = "targetFrameRate", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_targetFrameRate, PropertySetter = UnityEngine_Application_Wrap.S_targetFrameRate
#endif
                    }},
                    {"consoleLogPath_static", new MemberRegisterInfo { Name = "consoleLogPath", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_consoleLogPath
#endif
                    }},
                    {"backgroundLoadingPriority_static", new MemberRegisterInfo { Name = "backgroundLoadingPriority", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_backgroundLoadingPriority, PropertySetter = UnityEngine_Application_Wrap.S_backgroundLoadingPriority
#endif
                    }},
                    {"genuine_static", new MemberRegisterInfo { Name = "genuine", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_genuine
#endif
                    }},
                    {"genuineCheckAvailable_static", new MemberRegisterInfo { Name = "genuineCheckAvailable", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_genuineCheckAvailable
#endif
                    }},
                    {"platform_static", new MemberRegisterInfo { Name = "platform", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_platform
#endif
                    }},
                    {"isMobilePlatform_static", new MemberRegisterInfo { Name = "isMobilePlatform", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_isMobilePlatform
#endif
                    }},
                    {"isConsolePlatform_static", new MemberRegisterInfo { Name = "isConsolePlatform", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_isConsolePlatform
#endif
                    }},
                    {"systemLanguage_static", new MemberRegisterInfo { Name = "systemLanguage", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_systemLanguage
#endif
                    }},
                    {"internetReachability_static", new MemberRegisterInfo { Name = "internetReachability", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_internetReachability
#endif
                    }},
                    {"exitCancellationToken_static", new MemberRegisterInfo { Name = "exitCancellationToken", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_exitCancellationToken
#endif
                    }},
                    {"isEditor_static", new MemberRegisterInfo { Name = "isEditor", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Application_Wrap.G_isEditor
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Debug_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Debug_Wrap.Constructor
#endif
                    }},
                    {"DrawLine_static", new MemberRegisterInfo { Name = "DrawLine", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_DrawLine
#endif
                    }},
                    {"DrawRay_static", new MemberRegisterInfo { Name = "DrawRay", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_DrawRay
#endif
                    }},
                    {"Break_static", new MemberRegisterInfo { Name = "Break", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_Break
#endif
                    }},
                    {"DebugBreak_static", new MemberRegisterInfo { Name = "DebugBreak", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_DebugBreak
#endif
                    }},
                    {"Log_static", new MemberRegisterInfo { Name = "Log", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_Log
#endif
                    }},
                    {"LogFormat_static", new MemberRegisterInfo { Name = "LogFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogFormat
#endif
                    }},
                    {"LogError_static", new MemberRegisterInfo { Name = "LogError", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogError
#endif
                    }},
                    {"LogErrorFormat_static", new MemberRegisterInfo { Name = "LogErrorFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogErrorFormat
#endif
                    }},
                    {"ClearDeveloperConsole_static", new MemberRegisterInfo { Name = "ClearDeveloperConsole", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_ClearDeveloperConsole
#endif
                    }},
                    {"LogException_static", new MemberRegisterInfo { Name = "LogException", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogException
#endif
                    }},
                    {"LogWarning_static", new MemberRegisterInfo { Name = "LogWarning", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogWarning
#endif
                    }},
                    {"LogWarningFormat_static", new MemberRegisterInfo { Name = "LogWarningFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogWarningFormat
#endif
                    }},
                    {"Assert_static", new MemberRegisterInfo { Name = "Assert", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_Assert
#endif
                    }},
                    {"AssertFormat_static", new MemberRegisterInfo { Name = "AssertFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_AssertFormat
#endif
                    }},
                    {"LogAssertion_static", new MemberRegisterInfo { Name = "LogAssertion", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogAssertion
#endif
                    }},
                    {"LogAssertionFormat_static", new MemberRegisterInfo { Name = "LogAssertionFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Debug_Wrap.F_LogAssertionFormat
#endif
                    }},
                    {"unityLogger_static", new MemberRegisterInfo { Name = "unityLogger", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Debug_Wrap.G_unityLogger
#endif
                    }},
                    {"developerConsoleEnabled_static", new MemberRegisterInfo { Name = "developerConsoleEnabled", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Debug_Wrap.G_developerConsoleEnabled, PropertySetter = UnityEngine_Debug_Wrap.S_developerConsoleEnabled
#endif
                    }},
                    {"developerConsoleVisible_static", new MemberRegisterInfo { Name = "developerConsoleVisible", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Debug_Wrap.G_developerConsoleVisible, PropertySetter = UnityEngine_Debug_Wrap.S_developerConsoleVisible
#endif
                    }},
                    {"isDebugBuild_static", new MemberRegisterInfo { Name = "isDebugBuild", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Debug_Wrap.G_isDebugBuild
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Vector3_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Vector3_Wrap.Constructor
#endif
                    }},
                    {"Set", new MemberRegisterInfo { Name = "Set", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.M_Set
#endif
                    }},
                    {"Scale", new MemberRegisterInfo { Name = "Scale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.M_Scale
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.M_GetHashCode
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.M_Equals
#endif
                    }},
                    {"Normalize", new MemberRegisterInfo { Name = "Normalize", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.M_Normalize
#endif
                    }},
                    {"op_Addition_static", new MemberRegisterInfo { Name = "op_Addition", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_Addition
#endif
                    }},
                    {"op_Subtraction_static", new MemberRegisterInfo { Name = "op_Subtraction", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_Subtraction
#endif
                    }},
                    {"op_UnaryNegation_static", new MemberRegisterInfo { Name = "op_UnaryNegation", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_UnaryNegation
#endif
                    }},
                    {"op_Multiply_static", new MemberRegisterInfo { Name = "op_Multiply", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_Multiply
#endif
                    }},
                    {"op_Division_static", new MemberRegisterInfo { Name = "op_Division", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_Division
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.O_op_Inequality
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.M_ToString
#endif
                    }},
                    {"get_Item", new MemberRegisterInfo { Name = "get_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.GetItem
#endif
                    }},
                    {"set_Item", new MemberRegisterInfo { Name = "set_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.SetItem
#endif
                    }},
                    {"normalized", new MemberRegisterInfo { Name = "normalized", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_normalized
#endif
                    }},
                    {"magnitude", new MemberRegisterInfo { Name = "magnitude", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_magnitude
#endif
                    }},
                    {"sqrMagnitude", new MemberRegisterInfo { Name = "sqrMagnitude", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_sqrMagnitude
#endif
                    }},
                    {"x", new MemberRegisterInfo { Name = "x", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_x, PropertySetter = UnityEngine_Vector3_Wrap.S_x
#endif
                    }},
                    {"y", new MemberRegisterInfo { Name = "y", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_y, PropertySetter = UnityEngine_Vector3_Wrap.S_y
#endif
                    }},
                    {"z", new MemberRegisterInfo { Name = "z", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_z, PropertySetter = UnityEngine_Vector3_Wrap.S_z
#endif
                    }},
                    {"Slerp_static", new MemberRegisterInfo { Name = "Slerp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Slerp
#endif
                    }},
                    {"SlerpUnclamped_static", new MemberRegisterInfo { Name = "SlerpUnclamped", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_SlerpUnclamped
#endif
                    }},
                    {"OrthoNormalize_static", new MemberRegisterInfo { Name = "OrthoNormalize", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_OrthoNormalize
#endif
                    }},
                    {"RotateTowards_static", new MemberRegisterInfo { Name = "RotateTowards", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_RotateTowards
#endif
                    }},
                    {"Lerp_static", new MemberRegisterInfo { Name = "Lerp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Lerp
#endif
                    }},
                    {"LerpUnclamped_static", new MemberRegisterInfo { Name = "LerpUnclamped", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_LerpUnclamped
#endif
                    }},
                    {"MoveTowards_static", new MemberRegisterInfo { Name = "MoveTowards", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_MoveTowards
#endif
                    }},
                    {"SmoothDamp_static", new MemberRegisterInfo { Name = "SmoothDamp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_SmoothDamp
#endif
                    }},
                    {"Scale_static", new MemberRegisterInfo { Name = "Scale", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Scale
#endif
                    }},
                    {"Cross_static", new MemberRegisterInfo { Name = "Cross", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Cross
#endif
                    }},
                    {"Reflect_static", new MemberRegisterInfo { Name = "Reflect", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Reflect
#endif
                    }},
                    {"Normalize_static", new MemberRegisterInfo { Name = "Normalize", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Normalize
#endif
                    }},
                    {"Dot_static", new MemberRegisterInfo { Name = "Dot", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Dot
#endif
                    }},
                    {"Project_static", new MemberRegisterInfo { Name = "Project", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Project
#endif
                    }},
                    {"ProjectOnPlane_static", new MemberRegisterInfo { Name = "ProjectOnPlane", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_ProjectOnPlane
#endif
                    }},
                    {"Angle_static", new MemberRegisterInfo { Name = "Angle", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Angle
#endif
                    }},
                    {"SignedAngle_static", new MemberRegisterInfo { Name = "SignedAngle", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_SignedAngle
#endif
                    }},
                    {"Distance_static", new MemberRegisterInfo { Name = "Distance", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Distance
#endif
                    }},
                    {"ClampMagnitude_static", new MemberRegisterInfo { Name = "ClampMagnitude", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_ClampMagnitude
#endif
                    }},
                    {"Magnitude_static", new MemberRegisterInfo { Name = "Magnitude", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Magnitude
#endif
                    }},
                    {"SqrMagnitude_static", new MemberRegisterInfo { Name = "SqrMagnitude", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_SqrMagnitude
#endif
                    }},
                    {"Min_static", new MemberRegisterInfo { Name = "Min", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Min
#endif
                    }},
                    {"Max_static", new MemberRegisterInfo { Name = "Max", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Vector3_Wrap.F_Max
#endif
                    }},
                    {"zero_static", new MemberRegisterInfo { Name = "zero", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_zero
#endif
                    }},
                    {"one_static", new MemberRegisterInfo { Name = "one", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_one
#endif
                    }},
                    {"forward_static", new MemberRegisterInfo { Name = "forward", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_forward
#endif
                    }},
                    {"back_static", new MemberRegisterInfo { Name = "back", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_back
#endif
                    }},
                    {"up_static", new MemberRegisterInfo { Name = "up", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_up
#endif
                    }},
                    {"down_static", new MemberRegisterInfo { Name = "down", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_down
#endif
                    }},
                    {"left_static", new MemberRegisterInfo { Name = "left", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_left
#endif
                    }},
                    {"right_static", new MemberRegisterInfo { Name = "right", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_right
#endif
                    }},
                    {"positiveInfinity_static", new MemberRegisterInfo { Name = "positiveInfinity", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_positiveInfinity
#endif
                    }},
                    {"negativeInfinity_static", new MemberRegisterInfo { Name = "negativeInfinity", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_negativeInfinity
#endif
                    }},
                    {"kEpsilon_static", new MemberRegisterInfo { Name = "kEpsilon", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_kEpsilon
#endif
                    }},
                    {"kEpsilonNormalSqrt_static", new MemberRegisterInfo { Name = "kEpsilonNormalSqrt", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_kEpsilonNormalSqrt
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Quaternion_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Quaternion_Wrap.Constructor
#endif
                    }},
                    {"Set", new MemberRegisterInfo { Name = "Set", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.M_Set
#endif
                    }},
                    {"op_Multiply_static", new MemberRegisterInfo { Name = "op_Multiply", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.O_op_Multiply
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.O_op_Inequality
#endif
                    }},
                    {"SetLookRotation", new MemberRegisterInfo { Name = "SetLookRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.M_SetLookRotation
#endif
                    }},
                    {"ToAngleAxis", new MemberRegisterInfo { Name = "ToAngleAxis", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.M_ToAngleAxis
#endif
                    }},
                    {"SetFromToRotation", new MemberRegisterInfo { Name = "SetFromToRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.M_SetFromToRotation
#endif
                    }},
                    {"Normalize", new MemberRegisterInfo { Name = "Normalize", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.M_Normalize
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.M_GetHashCode
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.M_Equals
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.M_ToString
#endif
                    }},
                    {"get_Item", new MemberRegisterInfo { Name = "get_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.GetItem
#endif
                    }},
                    {"set_Item", new MemberRegisterInfo { Name = "set_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.SetItem
#endif
                    }},
                    {"eulerAngles", new MemberRegisterInfo { Name = "eulerAngles", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Quaternion_Wrap.G_eulerAngles, PropertySetter = UnityEngine_Quaternion_Wrap.S_eulerAngles
#endif
                    }},
                    {"normalized", new MemberRegisterInfo { Name = "normalized", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Quaternion_Wrap.G_normalized
#endif
                    }},
                    {"x", new MemberRegisterInfo { Name = "x", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Quaternion_Wrap.G_x, PropertySetter = UnityEngine_Quaternion_Wrap.S_x
#endif
                    }},
                    {"y", new MemberRegisterInfo { Name = "y", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Quaternion_Wrap.G_y, PropertySetter = UnityEngine_Quaternion_Wrap.S_y
#endif
                    }},
                    {"z", new MemberRegisterInfo { Name = "z", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Quaternion_Wrap.G_z, PropertySetter = UnityEngine_Quaternion_Wrap.S_z
#endif
                    }},
                    {"w", new MemberRegisterInfo { Name = "w", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Quaternion_Wrap.G_w, PropertySetter = UnityEngine_Quaternion_Wrap.S_w
#endif
                    }},
                    {"FromToRotation_static", new MemberRegisterInfo { Name = "FromToRotation", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_FromToRotation
#endif
                    }},
                    {"Inverse_static", new MemberRegisterInfo { Name = "Inverse", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_Inverse
#endif
                    }},
                    {"Slerp_static", new MemberRegisterInfo { Name = "Slerp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_Slerp
#endif
                    }},
                    {"SlerpUnclamped_static", new MemberRegisterInfo { Name = "SlerpUnclamped", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_SlerpUnclamped
#endif
                    }},
                    {"Lerp_static", new MemberRegisterInfo { Name = "Lerp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_Lerp
#endif
                    }},
                    {"LerpUnclamped_static", new MemberRegisterInfo { Name = "LerpUnclamped", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_LerpUnclamped
#endif
                    }},
                    {"AngleAxis_static", new MemberRegisterInfo { Name = "AngleAxis", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_AngleAxis
#endif
                    }},
                    {"LookRotation_static", new MemberRegisterInfo { Name = "LookRotation", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_LookRotation
#endif
                    }},
                    {"Dot_static", new MemberRegisterInfo { Name = "Dot", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_Dot
#endif
                    }},
                    {"Angle_static", new MemberRegisterInfo { Name = "Angle", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_Angle
#endif
                    }},
                    {"Euler_static", new MemberRegisterInfo { Name = "Euler", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_Euler
#endif
                    }},
                    {"RotateTowards_static", new MemberRegisterInfo { Name = "RotateTowards", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_RotateTowards
#endif
                    }},
                    {"Normalize_static", new MemberRegisterInfo { Name = "Normalize", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Quaternion_Wrap.F_Normalize
#endif
                    }},
                    {"identity_static", new MemberRegisterInfo { Name = "identity", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Quaternion_Wrap.G_identity
#endif
                    }},
                    {"kEpsilon_static", new MemberRegisterInfo { Name = "kEpsilon", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Quaternion_Wrap.G_kEpsilon
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Bounds_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Bounds_Wrap.Constructor
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.M_GetHashCode
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.M_Equals
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.O_op_Inequality
#endif
                    }},
                    {"SetMinMax", new MemberRegisterInfo { Name = "SetMinMax", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.M_SetMinMax
#endif
                    }},
                    {"Encapsulate", new MemberRegisterInfo { Name = "Encapsulate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.M_Encapsulate
#endif
                    }},
                    {"Expand", new MemberRegisterInfo { Name = "Expand", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.M_Expand
#endif
                    }},
                    {"Intersects", new MemberRegisterInfo { Name = "Intersects", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.M_Intersects
#endif
                    }},
                    {"IntersectRay", new MemberRegisterInfo { Name = "IntersectRay", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.M_IntersectRay
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.M_ToString
#endif
                    }},
                    {"Contains", new MemberRegisterInfo { Name = "Contains", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.M_Contains
#endif
                    }},
                    {"SqrDistance", new MemberRegisterInfo { Name = "SqrDistance", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.M_SqrDistance
#endif
                    }},
                    {"ClosestPoint", new MemberRegisterInfo { Name = "ClosestPoint", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Bounds_Wrap.M_ClosestPoint
#endif
                    }},
                    {"center", new MemberRegisterInfo { Name = "center", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Bounds_Wrap.G_center, PropertySetter = UnityEngine_Bounds_Wrap.S_center
#endif
                    }},
                    {"size", new MemberRegisterInfo { Name = "size", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Bounds_Wrap.G_size, PropertySetter = UnityEngine_Bounds_Wrap.S_size
#endif
                    }},
                    {"extents", new MemberRegisterInfo { Name = "extents", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Bounds_Wrap.G_extents, PropertySetter = UnityEngine_Bounds_Wrap.S_extents
#endif
                    }},
                    {"min", new MemberRegisterInfo { Name = "min", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Bounds_Wrap.G_min, PropertySetter = UnityEngine_Bounds_Wrap.S_min
#endif
                    }},
                    {"max", new MemberRegisterInfo { Name = "max", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Bounds_Wrap.G_max, PropertySetter = UnityEngine_Bounds_Wrap.S_max
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Time_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Time_Wrap.Constructor
#endif
                    }},
                    {"time_static", new MemberRegisterInfo { Name = "time", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_time
#endif
                    }},
                    {"timeAsDouble_static", new MemberRegisterInfo { Name = "timeAsDouble", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_timeAsDouble
#endif
                    }},
                    {"timeSinceLevelLoad_static", new MemberRegisterInfo { Name = "timeSinceLevelLoad", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_timeSinceLevelLoad
#endif
                    }},
                    {"timeSinceLevelLoadAsDouble_static", new MemberRegisterInfo { Name = "timeSinceLevelLoadAsDouble", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_timeSinceLevelLoadAsDouble
#endif
                    }},
                    {"deltaTime_static", new MemberRegisterInfo { Name = "deltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_deltaTime
#endif
                    }},
                    {"fixedTime_static", new MemberRegisterInfo { Name = "fixedTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_fixedTime
#endif
                    }},
                    {"fixedTimeAsDouble_static", new MemberRegisterInfo { Name = "fixedTimeAsDouble", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_fixedTimeAsDouble
#endif
                    }},
                    {"unscaledTime_static", new MemberRegisterInfo { Name = "unscaledTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_unscaledTime
#endif
                    }},
                    {"unscaledTimeAsDouble_static", new MemberRegisterInfo { Name = "unscaledTimeAsDouble", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_unscaledTimeAsDouble
#endif
                    }},
                    {"fixedUnscaledTime_static", new MemberRegisterInfo { Name = "fixedUnscaledTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_fixedUnscaledTime
#endif
                    }},
                    {"fixedUnscaledTimeAsDouble_static", new MemberRegisterInfo { Name = "fixedUnscaledTimeAsDouble", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_fixedUnscaledTimeAsDouble
#endif
                    }},
                    {"unscaledDeltaTime_static", new MemberRegisterInfo { Name = "unscaledDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_unscaledDeltaTime
#endif
                    }},
                    {"fixedUnscaledDeltaTime_static", new MemberRegisterInfo { Name = "fixedUnscaledDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_fixedUnscaledDeltaTime
#endif
                    }},
                    {"fixedDeltaTime_static", new MemberRegisterInfo { Name = "fixedDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_fixedDeltaTime, PropertySetter = UnityEngine_Time_Wrap.S_fixedDeltaTime
#endif
                    }},
                    {"maximumDeltaTime_static", new MemberRegisterInfo { Name = "maximumDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_maximumDeltaTime, PropertySetter = UnityEngine_Time_Wrap.S_maximumDeltaTime
#endif
                    }},
                    {"smoothDeltaTime_static", new MemberRegisterInfo { Name = "smoothDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_smoothDeltaTime
#endif
                    }},
                    {"maximumParticleDeltaTime_static", new MemberRegisterInfo { Name = "maximumParticleDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_maximumParticleDeltaTime, PropertySetter = UnityEngine_Time_Wrap.S_maximumParticleDeltaTime
#endif
                    }},
                    {"timeScale_static", new MemberRegisterInfo { Name = "timeScale", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_timeScale, PropertySetter = UnityEngine_Time_Wrap.S_timeScale
#endif
                    }},
                    {"frameCount_static", new MemberRegisterInfo { Name = "frameCount", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_frameCount
#endif
                    }},
                    {"renderedFrameCount_static", new MemberRegisterInfo { Name = "renderedFrameCount", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_renderedFrameCount
#endif
                    }},
                    {"realtimeSinceStartup_static", new MemberRegisterInfo { Name = "realtimeSinceStartup", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_realtimeSinceStartup
#endif
                    }},
                    {"realtimeSinceStartupAsDouble_static", new MemberRegisterInfo { Name = "realtimeSinceStartupAsDouble", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_realtimeSinceStartupAsDouble
#endif
                    }},
                    {"captureDeltaTime_static", new MemberRegisterInfo { Name = "captureDeltaTime", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_captureDeltaTime, PropertySetter = UnityEngine_Time_Wrap.S_captureDeltaTime
#endif
                    }},
                    {"captureFramerate_static", new MemberRegisterInfo { Name = "captureFramerate", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_captureFramerate, PropertySetter = UnityEngine_Time_Wrap.S_captureFramerate
#endif
                    }},
                    {"inFixedTimeStep_static", new MemberRegisterInfo { Name = "inFixedTimeStep", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Time_Wrap.G_inFixedTimeStep
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Transform_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"SetParent", new MemberRegisterInfo { Name = "SetParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_SetParent
#endif
                    }},
                    {"SetPositionAndRotation", new MemberRegisterInfo { Name = "SetPositionAndRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_SetPositionAndRotation
#endif
                    }},
                    {"SetLocalPositionAndRotation", new MemberRegisterInfo { Name = "SetLocalPositionAndRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_SetLocalPositionAndRotation
#endif
                    }},
                    {"GetPositionAndRotation", new MemberRegisterInfo { Name = "GetPositionAndRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_GetPositionAndRotation
#endif
                    }},
                    {"GetLocalPositionAndRotation", new MemberRegisterInfo { Name = "GetLocalPositionAndRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_GetLocalPositionAndRotation
#endif
                    }},
                    {"Translate", new MemberRegisterInfo { Name = "Translate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_Translate
#endif
                    }},
                    {"Rotate", new MemberRegisterInfo { Name = "Rotate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_Rotate
#endif
                    }},
                    {"RotateAround", new MemberRegisterInfo { Name = "RotateAround", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_RotateAround
#endif
                    }},
                    {"LookAt", new MemberRegisterInfo { Name = "LookAt", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_LookAt
#endif
                    }},
                    {"TransformDirection", new MemberRegisterInfo { Name = "TransformDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_TransformDirection
#endif
                    }},
                    {"InverseTransformDirection", new MemberRegisterInfo { Name = "InverseTransformDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_InverseTransformDirection
#endif
                    }},
                    {"TransformVector", new MemberRegisterInfo { Name = "TransformVector", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_TransformVector
#endif
                    }},
                    {"InverseTransformVector", new MemberRegisterInfo { Name = "InverseTransformVector", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_InverseTransformVector
#endif
                    }},
                    {"TransformPoint", new MemberRegisterInfo { Name = "TransformPoint", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_TransformPoint
#endif
                    }},
                    {"InverseTransformPoint", new MemberRegisterInfo { Name = "InverseTransformPoint", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_InverseTransformPoint
#endif
                    }},
                    {"DetachChildren", new MemberRegisterInfo { Name = "DetachChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_DetachChildren
#endif
                    }},
                    {"SetAsFirstSibling", new MemberRegisterInfo { Name = "SetAsFirstSibling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_SetAsFirstSibling
#endif
                    }},
                    {"SetAsLastSibling", new MemberRegisterInfo { Name = "SetAsLastSibling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_SetAsLastSibling
#endif
                    }},
                    {"SetSiblingIndex", new MemberRegisterInfo { Name = "SetSiblingIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_SetSiblingIndex
#endif
                    }},
                    {"GetSiblingIndex", new MemberRegisterInfo { Name = "GetSiblingIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_GetSiblingIndex
#endif
                    }},
                    {"Find", new MemberRegisterInfo { Name = "Find", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_Find
#endif
                    }},
                    {"IsChildOf", new MemberRegisterInfo { Name = "IsChildOf", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_IsChildOf
#endif
                    }},
                    {"GetEnumerator", new MemberRegisterInfo { Name = "GetEnumerator", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_GetEnumerator
#endif
                    }},
                    {"GetChild", new MemberRegisterInfo { Name = "GetChild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Transform_Wrap.M_GetChild
#endif
                    }},
                    {"position", new MemberRegisterInfo { Name = "position", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_position, PropertySetter = UnityEngine_Transform_Wrap.S_position
#endif
                    }},
                    {"localPosition", new MemberRegisterInfo { Name = "localPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localPosition, PropertySetter = UnityEngine_Transform_Wrap.S_localPosition
#endif
                    }},
                    {"eulerAngles", new MemberRegisterInfo { Name = "eulerAngles", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_eulerAngles, PropertySetter = UnityEngine_Transform_Wrap.S_eulerAngles
#endif
                    }},
                    {"localEulerAngles", new MemberRegisterInfo { Name = "localEulerAngles", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localEulerAngles, PropertySetter = UnityEngine_Transform_Wrap.S_localEulerAngles
#endif
                    }},
                    {"right", new MemberRegisterInfo { Name = "right", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_right, PropertySetter = UnityEngine_Transform_Wrap.S_right
#endif
                    }},
                    {"up", new MemberRegisterInfo { Name = "up", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_up, PropertySetter = UnityEngine_Transform_Wrap.S_up
#endif
                    }},
                    {"forward", new MemberRegisterInfo { Name = "forward", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_forward, PropertySetter = UnityEngine_Transform_Wrap.S_forward
#endif
                    }},
                    {"rotation", new MemberRegisterInfo { Name = "rotation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_rotation, PropertySetter = UnityEngine_Transform_Wrap.S_rotation
#endif
                    }},
                    {"localRotation", new MemberRegisterInfo { Name = "localRotation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localRotation, PropertySetter = UnityEngine_Transform_Wrap.S_localRotation
#endif
                    }},
                    {"localScale", new MemberRegisterInfo { Name = "localScale", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localScale, PropertySetter = UnityEngine_Transform_Wrap.S_localScale
#endif
                    }},
                    {"parent", new MemberRegisterInfo { Name = "parent", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_parent, PropertySetter = UnityEngine_Transform_Wrap.S_parent
#endif
                    }},
                    {"worldToLocalMatrix", new MemberRegisterInfo { Name = "worldToLocalMatrix", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_worldToLocalMatrix
#endif
                    }},
                    {"localToWorldMatrix", new MemberRegisterInfo { Name = "localToWorldMatrix", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localToWorldMatrix
#endif
                    }},
                    {"root", new MemberRegisterInfo { Name = "root", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_root
#endif
                    }},
                    {"childCount", new MemberRegisterInfo { Name = "childCount", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_childCount
#endif
                    }},
                    {"lossyScale", new MemberRegisterInfo { Name = "lossyScale", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_lossyScale
#endif
                    }},
                    {"hasChanged", new MemberRegisterInfo { Name = "hasChanged", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_hasChanged, PropertySetter = UnityEngine_Transform_Wrap.S_hasChanged
#endif
                    }},
                    {"hierarchyCapacity", new MemberRegisterInfo { Name = "hierarchyCapacity", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_hierarchyCapacity, PropertySetter = UnityEngine_Transform_Wrap.S_hierarchyCapacity
#endif
                    }},
                    {"hierarchyCount", new MemberRegisterInfo { Name = "hierarchyCount", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_hierarchyCount
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Component_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Component_Wrap.Constructor
#endif
                    }},
                    {"GetComponent", new MemberRegisterInfo { Name = "GetComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponent
#endif
                    }},
                    {"TryGetComponent", new MemberRegisterInfo { Name = "TryGetComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_TryGetComponent
#endif
                    }},
                    {"GetComponentInChildren", new MemberRegisterInfo { Name = "GetComponentInChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponentInChildren
#endif
                    }},
                    {"GetComponentsInChildren", new MemberRegisterInfo { Name = "GetComponentsInChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponentsInChildren
#endif
                    }},
                    {"GetComponentInParent", new MemberRegisterInfo { Name = "GetComponentInParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponentInParent
#endif
                    }},
                    {"GetComponentsInParent", new MemberRegisterInfo { Name = "GetComponentsInParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponentsInParent
#endif
                    }},
                    {"GetComponents", new MemberRegisterInfo { Name = "GetComponents", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponents
#endif
                    }},
                    {"GetComponentIndex", new MemberRegisterInfo { Name = "GetComponentIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_GetComponentIndex
#endif
                    }},
                    {"CompareTag", new MemberRegisterInfo { Name = "CompareTag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_CompareTag
#endif
                    }},
                    {"SendMessageUpwards", new MemberRegisterInfo { Name = "SendMessageUpwards", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_SendMessageUpwards
#endif
                    }},
                    {"SendMessage", new MemberRegisterInfo { Name = "SendMessage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_SendMessage
#endif
                    }},
                    {"BroadcastMessage", new MemberRegisterInfo { Name = "BroadcastMessage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Component_Wrap.M_BroadcastMessage
#endif
                    }},
                    {"transform", new MemberRegisterInfo { Name = "transform", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Component_Wrap.G_transform
#endif
                    }},
                    {"gameObject", new MemberRegisterInfo { Name = "gameObject", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Component_Wrap.G_gameObject
#endif
                    }},
                    {"tag", new MemberRegisterInfo { Name = "tag", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Component_Wrap.G_tag, PropertySetter = UnityEngine_Component_Wrap.S_tag
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_GameObject_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_GameObject_Wrap.Constructor
#endif
                    }},
                    {"GetComponent", new MemberRegisterInfo { Name = "GetComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponent
#endif
                    }},
                    {"GetComponentInChildren", new MemberRegisterInfo { Name = "GetComponentInChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentInChildren
#endif
                    }},
                    {"GetComponentInParent", new MemberRegisterInfo { Name = "GetComponentInParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentInParent
#endif
                    }},
                    {"GetComponents", new MemberRegisterInfo { Name = "GetComponents", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponents
#endif
                    }},
                    {"GetComponentsInChildren", new MemberRegisterInfo { Name = "GetComponentsInChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentsInChildren
#endif
                    }},
                    {"GetComponentsInParent", new MemberRegisterInfo { Name = "GetComponentsInParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentsInParent
#endif
                    }},
                    {"TryGetComponent", new MemberRegisterInfo { Name = "TryGetComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_TryGetComponent
#endif
                    }},
                    {"SendMessageUpwards", new MemberRegisterInfo { Name = "SendMessageUpwards", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_SendMessageUpwards
#endif
                    }},
                    {"SendMessage", new MemberRegisterInfo { Name = "SendMessage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_SendMessage
#endif
                    }},
                    {"BroadcastMessage", new MemberRegisterInfo { Name = "BroadcastMessage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_BroadcastMessage
#endif
                    }},
                    {"AddComponent", new MemberRegisterInfo { Name = "AddComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_AddComponent
#endif
                    }},
                    {"GetComponentCount", new MemberRegisterInfo { Name = "GetComponentCount", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentCount
#endif
                    }},
                    {"GetComponentAtIndex", new MemberRegisterInfo { Name = "GetComponentAtIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentAtIndex
#endif
                    }},
                    {"GetComponentIndex", new MemberRegisterInfo { Name = "GetComponentIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentIndex
#endif
                    }},
                    {"SetActive", new MemberRegisterInfo { Name = "SetActive", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_SetActive
#endif
                    }},
                    {"CompareTag", new MemberRegisterInfo { Name = "CompareTag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.M_CompareTag
#endif
                    }},
                    {"transform", new MemberRegisterInfo { Name = "transform", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_transform
#endif
                    }},
                    {"layer", new MemberRegisterInfo { Name = "layer", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_layer, PropertySetter = UnityEngine_GameObject_Wrap.S_layer
#endif
                    }},
                    {"activeSelf", new MemberRegisterInfo { Name = "activeSelf", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_activeSelf
#endif
                    }},
                    {"activeInHierarchy", new MemberRegisterInfo { Name = "activeInHierarchy", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_activeInHierarchy
#endif
                    }},
                    {"isStatic", new MemberRegisterInfo { Name = "isStatic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_isStatic, PropertySetter = UnityEngine_GameObject_Wrap.S_isStatic
#endif
                    }},
                    {"tag", new MemberRegisterInfo { Name = "tag", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_tag, PropertySetter = UnityEngine_GameObject_Wrap.S_tag
#endif
                    }},
                    {"scene", new MemberRegisterInfo { Name = "scene", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_scene
#endif
                    }},
                    {"sceneCullingMask", new MemberRegisterInfo { Name = "sceneCullingMask", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_sceneCullingMask
#endif
                    }},
                    {"gameObject", new MemberRegisterInfo { Name = "gameObject", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_gameObject
#endif
                    }},
                    {"CreatePrimitive_static", new MemberRegisterInfo { Name = "CreatePrimitive", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_CreatePrimitive
#endif
                    }},
                    {"FindWithTag_static", new MemberRegisterInfo { Name = "FindWithTag", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_FindWithTag
#endif
                    }},
                    {"FindGameObjectWithTag_static", new MemberRegisterInfo { Name = "FindGameObjectWithTag", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_FindGameObjectWithTag
#endif
                    }},
                    {"FindGameObjectsWithTag_static", new MemberRegisterInfo { Name = "FindGameObjectsWithTag", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_FindGameObjectsWithTag
#endif
                    }},
                    {"Find_static", new MemberRegisterInfo { Name = "Find", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_Find
#endif
                    }},
                    {"SetGameObjectsActive_static", new MemberRegisterInfo { Name = "SetGameObjectsActive", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_SetGameObjectsActive
#endif
                    }},
                    {"InstantiateGameObjects_static", new MemberRegisterInfo { Name = "InstantiateGameObjects", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_InstantiateGameObjects
#endif
                    }},
                    {"GetScene_static", new MemberRegisterInfo { Name = "GetScene", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_GameObject_Wrap.F_GetScene
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Object_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Object_Wrap.Constructor
#endif
                    }},
                    {"GetInstanceID", new MemberRegisterInfo { Name = "GetInstanceID", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.M_GetInstanceID
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.M_GetHashCode
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.M_Equals
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.M_ToString
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.O_op_Inequality
#endif
                    }},
                    {"name", new MemberRegisterInfo { Name = "name", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Object_Wrap.G_name, PropertySetter = UnityEngine_Object_Wrap.S_name
#endif
                    }},
                    {"hideFlags", new MemberRegisterInfo { Name = "hideFlags", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Object_Wrap.G_hideFlags, PropertySetter = UnityEngine_Object_Wrap.S_hideFlags
#endif
                    }},
                    {"InstantiateAsync_static", new MemberRegisterInfo { Name = "InstantiateAsync", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_InstantiateAsync
#endif
                    }},
                    {"Instantiate_static", new MemberRegisterInfo { Name = "Instantiate", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_Instantiate
#endif
                    }},
                    {"Destroy_static", new MemberRegisterInfo { Name = "Destroy", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_Destroy
#endif
                    }},
                    {"DestroyImmediate_static", new MemberRegisterInfo { Name = "DestroyImmediate", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_DestroyImmediate
#endif
                    }},
                    {"FindObjectsOfType_static", new MemberRegisterInfo { Name = "FindObjectsOfType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_FindObjectsOfType
#endif
                    }},
                    {"FindObjectsByType_static", new MemberRegisterInfo { Name = "FindObjectsByType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_FindObjectsByType
#endif
                    }},
                    {"DontDestroyOnLoad_static", new MemberRegisterInfo { Name = "DontDestroyOnLoad", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_DontDestroyOnLoad
#endif
                    }},
                    {"FindObjectOfType_static", new MemberRegisterInfo { Name = "FindObjectOfType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_FindObjectOfType
#endif
                    }},
                    {"FindFirstObjectByType_static", new MemberRegisterInfo { Name = "FindFirstObjectByType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_FindFirstObjectByType
#endif
                    }},
                    {"FindAnyObjectByType_static", new MemberRegisterInfo { Name = "FindAnyObjectByType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Object_Wrap.F_FindAnyObjectByType
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_System_Delegate_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"DynamicInvoke", new MemberRegisterInfo { Name = "DynamicInvoke", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.M_DynamicInvoke
#endif
                    }},
                    {"Clone", new MemberRegisterInfo { Name = "Clone", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.M_Clone
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.M_Equals
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.M_GetHashCode
#endif
                    }},
                    {"GetObjectData", new MemberRegisterInfo { Name = "GetObjectData", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.M_GetObjectData
#endif
                    }},
                    {"GetInvocationList", new MemberRegisterInfo { Name = "GetInvocationList", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.M_GetInvocationList
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.O_op_Inequality
#endif
                    }},
                    {"Method", new MemberRegisterInfo { Name = "Method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Delegate_Wrap.G_Method
#endif
                    }},
                    {"Target", new MemberRegisterInfo { Name = "Target", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_Delegate_Wrap.G_Target
#endif
                    }},
                    {"CreateDelegate_static", new MemberRegisterInfo { Name = "CreateDelegate", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.F_CreateDelegate
#endif
                    }},
                    {"Combine_static", new MemberRegisterInfo { Name = "Combine", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.F_Combine
#endif
                    }},
                    {"Remove_static", new MemberRegisterInfo { Name = "Remove", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.F_Remove
#endif
                    }},
                    {"RemoveAll_static", new MemberRegisterInfo { Name = "RemoveAll", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Delegate_Wrap.F_RemoveAll
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_System_Object_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = System_Object_Wrap.Constructor
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Object_Wrap.M_Equals
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Object_Wrap.M_GetHashCode
#endif
                    }},
                    {"GetType", new MemberRegisterInfo { Name = "GetType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Object_Wrap.M_GetType
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Object_Wrap.M_ToString
#endif
                    }},
                    {"Equals_static", new MemberRegisterInfo { Name = "Equals", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Object_Wrap.F_Equals
#endif
                    }},
                    {"ReferenceEquals_static", new MemberRegisterInfo { Name = "ReferenceEquals", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_Object_Wrap.F_ReferenceEquals
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_ParticleSystem_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_ParticleSystem_Wrap.Constructor
#endif
                    }},
                    {"SetParticles", new MemberRegisterInfo { Name = "SetParticles", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_SetParticles
#endif
                    }},
                    {"GetParticles", new MemberRegisterInfo { Name = "GetParticles", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_GetParticles
#endif
                    }},
                    {"SetCustomParticleData", new MemberRegisterInfo { Name = "SetCustomParticleData", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_SetCustomParticleData
#endif
                    }},
                    {"GetCustomParticleData", new MemberRegisterInfo { Name = "GetCustomParticleData", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_GetCustomParticleData
#endif
                    }},
                    {"GetPlaybackState", new MemberRegisterInfo { Name = "GetPlaybackState", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_GetPlaybackState
#endif
                    }},
                    {"SetPlaybackState", new MemberRegisterInfo { Name = "SetPlaybackState", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_SetPlaybackState
#endif
                    }},
                    {"GetTrails", new MemberRegisterInfo { Name = "GetTrails", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_GetTrails
#endif
                    }},
                    {"SetTrails", new MemberRegisterInfo { Name = "SetTrails", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_SetTrails
#endif
                    }},
                    {"Simulate", new MemberRegisterInfo { Name = "Simulate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Simulate
#endif
                    }},
                    {"Play", new MemberRegisterInfo { Name = "Play", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Play
#endif
                    }},
                    {"Pause", new MemberRegisterInfo { Name = "Pause", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Pause
#endif
                    }},
                    {"Stop", new MemberRegisterInfo { Name = "Stop", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Stop
#endif
                    }},
                    {"Clear", new MemberRegisterInfo { Name = "Clear", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Clear
#endif
                    }},
                    {"IsAlive", new MemberRegisterInfo { Name = "IsAlive", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_IsAlive
#endif
                    }},
                    {"Emit", new MemberRegisterInfo { Name = "Emit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Emit
#endif
                    }},
                    {"TriggerSubEmitter", new MemberRegisterInfo { Name = "TriggerSubEmitter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_TriggerSubEmitter
#endif
                    }},
                    {"AllocateAxisOfRotationAttribute", new MemberRegisterInfo { Name = "AllocateAxisOfRotationAttribute", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_AllocateAxisOfRotationAttribute
#endif
                    }},
                    {"AllocateMeshIndexAttribute", new MemberRegisterInfo { Name = "AllocateMeshIndexAttribute", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_AllocateMeshIndexAttribute
#endif
                    }},
                    {"AllocateCustomDataAttribute", new MemberRegisterInfo { Name = "AllocateCustomDataAttribute", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.M_AllocateCustomDataAttribute
#endif
                    }},
                    {"isPlaying", new MemberRegisterInfo { Name = "isPlaying", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_isPlaying
#endif
                    }},
                    {"isEmitting", new MemberRegisterInfo { Name = "isEmitting", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_isEmitting
#endif
                    }},
                    {"isStopped", new MemberRegisterInfo { Name = "isStopped", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_isStopped
#endif
                    }},
                    {"isPaused", new MemberRegisterInfo { Name = "isPaused", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_isPaused
#endif
                    }},
                    {"particleCount", new MemberRegisterInfo { Name = "particleCount", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_particleCount
#endif
                    }},
                    {"time", new MemberRegisterInfo { Name = "time", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_time, PropertySetter = UnityEngine_ParticleSystem_Wrap.S_time
#endif
                    }},
                    {"totalTime", new MemberRegisterInfo { Name = "totalTime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_totalTime
#endif
                    }},
                    {"randomSeed", new MemberRegisterInfo { Name = "randomSeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_randomSeed, PropertySetter = UnityEngine_ParticleSystem_Wrap.S_randomSeed
#endif
                    }},
                    {"useAutoRandomSeed", new MemberRegisterInfo { Name = "useAutoRandomSeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_useAutoRandomSeed, PropertySetter = UnityEngine_ParticleSystem_Wrap.S_useAutoRandomSeed
#endif
                    }},
                    {"proceduralSimulationSupported", new MemberRegisterInfo { Name = "proceduralSimulationSupported", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_proceduralSimulationSupported
#endif
                    }},
                    {"has3DParticleRotations", new MemberRegisterInfo { Name = "has3DParticleRotations", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_has3DParticleRotations
#endif
                    }},
                    {"hasNonUniformParticleSizes", new MemberRegisterInfo { Name = "hasNonUniformParticleSizes", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_hasNonUniformParticleSizes
#endif
                    }},
                    {"main", new MemberRegisterInfo { Name = "main", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_main
#endif
                    }},
                    {"emission", new MemberRegisterInfo { Name = "emission", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_emission
#endif
                    }},
                    {"shape", new MemberRegisterInfo { Name = "shape", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_shape
#endif
                    }},
                    {"velocityOverLifetime", new MemberRegisterInfo { Name = "velocityOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_velocityOverLifetime
#endif
                    }},
                    {"limitVelocityOverLifetime", new MemberRegisterInfo { Name = "limitVelocityOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_limitVelocityOverLifetime
#endif
                    }},
                    {"inheritVelocity", new MemberRegisterInfo { Name = "inheritVelocity", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_inheritVelocity
#endif
                    }},
                    {"lifetimeByEmitterSpeed", new MemberRegisterInfo { Name = "lifetimeByEmitterSpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_lifetimeByEmitterSpeed
#endif
                    }},
                    {"forceOverLifetime", new MemberRegisterInfo { Name = "forceOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_forceOverLifetime
#endif
                    }},
                    {"colorOverLifetime", new MemberRegisterInfo { Name = "colorOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_colorOverLifetime
#endif
                    }},
                    {"colorBySpeed", new MemberRegisterInfo { Name = "colorBySpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_colorBySpeed
#endif
                    }},
                    {"sizeOverLifetime", new MemberRegisterInfo { Name = "sizeOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_sizeOverLifetime
#endif
                    }},
                    {"sizeBySpeed", new MemberRegisterInfo { Name = "sizeBySpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_sizeBySpeed
#endif
                    }},
                    {"rotationOverLifetime", new MemberRegisterInfo { Name = "rotationOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_rotationOverLifetime
#endif
                    }},
                    {"rotationBySpeed", new MemberRegisterInfo { Name = "rotationBySpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_rotationBySpeed
#endif
                    }},
                    {"externalForces", new MemberRegisterInfo { Name = "externalForces", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_externalForces
#endif
                    }},
                    {"noise", new MemberRegisterInfo { Name = "noise", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_noise
#endif
                    }},
                    {"collision", new MemberRegisterInfo { Name = "collision", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_collision
#endif
                    }},
                    {"trigger", new MemberRegisterInfo { Name = "trigger", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_trigger
#endif
                    }},
                    {"subEmitters", new MemberRegisterInfo { Name = "subEmitters", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_subEmitters
#endif
                    }},
                    {"textureSheetAnimation", new MemberRegisterInfo { Name = "textureSheetAnimation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_textureSheetAnimation
#endif
                    }},
                    {"lights", new MemberRegisterInfo { Name = "lights", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_lights
#endif
                    }},
                    {"trails", new MemberRegisterInfo { Name = "trails", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_trails
#endif
                    }},
                    {"customData", new MemberRegisterInfo { Name = "customData", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_customData
#endif
                    }},
                    {"ResetPreMappedBufferMemory_static", new MemberRegisterInfo { Name = "ResetPreMappedBufferMemory", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.F_ResetPreMappedBufferMemory
#endif
                    }},
                    {"SetMaximumPreMappedBufferCounts_static", new MemberRegisterInfo { Name = "SetMaximumPreMappedBufferCounts", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_ParticleSystem_Wrap.F_SetMaximumPreMappedBufferCounts
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Canvas_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Canvas_Wrap.Constructor
#endif
                    }},
                    {"add_preWillRenderCanvases_static", new MemberRegisterInfo { Name = "add_preWillRenderCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.A_preWillRenderCanvases
#endif
                    }},
                    {"remove_preWillRenderCanvases_static", new MemberRegisterInfo { Name = "remove_preWillRenderCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.R_preWillRenderCanvases
#endif
                    }},
                    {"add_willRenderCanvases_static", new MemberRegisterInfo { Name = "add_willRenderCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.A_willRenderCanvases
#endif
                    }},
                    {"remove_willRenderCanvases_static", new MemberRegisterInfo { Name = "remove_willRenderCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.R_willRenderCanvases
#endif
                    }},
                    {"renderMode", new MemberRegisterInfo { Name = "renderMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_renderMode, PropertySetter = UnityEngine_Canvas_Wrap.S_renderMode
#endif
                    }},
                    {"isRootCanvas", new MemberRegisterInfo { Name = "isRootCanvas", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_isRootCanvas
#endif
                    }},
                    {"pixelRect", new MemberRegisterInfo { Name = "pixelRect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_pixelRect
#endif
                    }},
                    {"scaleFactor", new MemberRegisterInfo { Name = "scaleFactor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_scaleFactor, PropertySetter = UnityEngine_Canvas_Wrap.S_scaleFactor
#endif
                    }},
                    {"referencePixelsPerUnit", new MemberRegisterInfo { Name = "referencePixelsPerUnit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_referencePixelsPerUnit, PropertySetter = UnityEngine_Canvas_Wrap.S_referencePixelsPerUnit
#endif
                    }},
                    {"overridePixelPerfect", new MemberRegisterInfo { Name = "overridePixelPerfect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_overridePixelPerfect, PropertySetter = UnityEngine_Canvas_Wrap.S_overridePixelPerfect
#endif
                    }},
                    {"vertexColorAlwaysGammaSpace", new MemberRegisterInfo { Name = "vertexColorAlwaysGammaSpace", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_vertexColorAlwaysGammaSpace, PropertySetter = UnityEngine_Canvas_Wrap.S_vertexColorAlwaysGammaSpace
#endif
                    }},
                    {"pixelPerfect", new MemberRegisterInfo { Name = "pixelPerfect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_pixelPerfect, PropertySetter = UnityEngine_Canvas_Wrap.S_pixelPerfect
#endif
                    }},
                    {"planeDistance", new MemberRegisterInfo { Name = "planeDistance", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_planeDistance, PropertySetter = UnityEngine_Canvas_Wrap.S_planeDistance
#endif
                    }},
                    {"renderOrder", new MemberRegisterInfo { Name = "renderOrder", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_renderOrder
#endif
                    }},
                    {"overrideSorting", new MemberRegisterInfo { Name = "overrideSorting", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_overrideSorting, PropertySetter = UnityEngine_Canvas_Wrap.S_overrideSorting
#endif
                    }},
                    {"sortingOrder", new MemberRegisterInfo { Name = "sortingOrder", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_sortingOrder, PropertySetter = UnityEngine_Canvas_Wrap.S_sortingOrder
#endif
                    }},
                    {"targetDisplay", new MemberRegisterInfo { Name = "targetDisplay", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_targetDisplay, PropertySetter = UnityEngine_Canvas_Wrap.S_targetDisplay
#endif
                    }},
                    {"sortingLayerID", new MemberRegisterInfo { Name = "sortingLayerID", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_sortingLayerID, PropertySetter = UnityEngine_Canvas_Wrap.S_sortingLayerID
#endif
                    }},
                    {"cachedSortingLayerValue", new MemberRegisterInfo { Name = "cachedSortingLayerValue", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_cachedSortingLayerValue
#endif
                    }},
                    {"additionalShaderChannels", new MemberRegisterInfo { Name = "additionalShaderChannels", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_additionalShaderChannels, PropertySetter = UnityEngine_Canvas_Wrap.S_additionalShaderChannels
#endif
                    }},
                    {"sortingLayerName", new MemberRegisterInfo { Name = "sortingLayerName", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_sortingLayerName, PropertySetter = UnityEngine_Canvas_Wrap.S_sortingLayerName
#endif
                    }},
                    {"rootCanvas", new MemberRegisterInfo { Name = "rootCanvas", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_rootCanvas
#endif
                    }},
                    {"renderingDisplaySize", new MemberRegisterInfo { Name = "renderingDisplaySize", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_renderingDisplaySize
#endif
                    }},
                    {"updateRectTransformForStandalone", new MemberRegisterInfo { Name = "updateRectTransformForStandalone", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_updateRectTransformForStandalone, PropertySetter = UnityEngine_Canvas_Wrap.S_updateRectTransformForStandalone
#endif
                    }},
                    {"distributedOffset", new MemberRegisterInfo { Name = "distributedOffset", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_distributedOffset, PropertySetter = UnityEngine_Canvas_Wrap.S_distributedOffset
#endif
                    }},
                    {"distributedScale", new MemberRegisterInfo { Name = "distributedScale", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_distributedScale, PropertySetter = UnityEngine_Canvas_Wrap.S_distributedScale
#endif
                    }},
                    {"worldCamera", new MemberRegisterInfo { Name = "worldCamera", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_worldCamera, PropertySetter = UnityEngine_Canvas_Wrap.S_worldCamera
#endif
                    }},
                    {"normalizedSortingGridSize", new MemberRegisterInfo { Name = "normalizedSortingGridSize", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_normalizedSortingGridSize, PropertySetter = UnityEngine_Canvas_Wrap.S_normalizedSortingGridSize
#endif
                    }},
                    {"GetDefaultCanvasMaterial_static", new MemberRegisterInfo { Name = "GetDefaultCanvasMaterial", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.F_GetDefaultCanvasMaterial
#endif
                    }},
                    {"GetETC1SupportedCanvasMaterial_static", new MemberRegisterInfo { Name = "GetETC1SupportedCanvasMaterial", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.F_GetETC1SupportedCanvasMaterial
#endif
                    }},
                    {"ForceUpdateCanvases_static", new MemberRegisterInfo { Name = "ForceUpdateCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Canvas_Wrap.F_ForceUpdateCanvases
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Renderer_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Renderer_Wrap.Constructor
#endif
                    }},
                    {"ResetBounds", new MemberRegisterInfo { Name = "ResetBounds", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Renderer_Wrap.M_ResetBounds
#endif
                    }},
                    {"ResetLocalBounds", new MemberRegisterInfo { Name = "ResetLocalBounds", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Renderer_Wrap.M_ResetLocalBounds
#endif
                    }},
                    {"HasPropertyBlock", new MemberRegisterInfo { Name = "HasPropertyBlock", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Renderer_Wrap.M_HasPropertyBlock
#endif
                    }},
                    {"SetPropertyBlock", new MemberRegisterInfo { Name = "SetPropertyBlock", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Renderer_Wrap.M_SetPropertyBlock
#endif
                    }},
                    {"GetPropertyBlock", new MemberRegisterInfo { Name = "GetPropertyBlock", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Renderer_Wrap.M_GetPropertyBlock
#endif
                    }},
                    {"GetMaterials", new MemberRegisterInfo { Name = "GetMaterials", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Renderer_Wrap.M_GetMaterials
#endif
                    }},
                    {"SetSharedMaterials", new MemberRegisterInfo { Name = "SetSharedMaterials", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Renderer_Wrap.M_SetSharedMaterials
#endif
                    }},
                    {"SetMaterials", new MemberRegisterInfo { Name = "SetMaterials", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Renderer_Wrap.M_SetMaterials
#endif
                    }},
                    {"GetSharedMaterials", new MemberRegisterInfo { Name = "GetSharedMaterials", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Renderer_Wrap.M_GetSharedMaterials
#endif
                    }},
                    {"GetClosestReflectionProbes", new MemberRegisterInfo { Name = "GetClosestReflectionProbes", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Renderer_Wrap.M_GetClosestReflectionProbes
#endif
                    }},
                    {"bounds", new MemberRegisterInfo { Name = "bounds", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_bounds, PropertySetter = UnityEngine_Renderer_Wrap.S_bounds
#endif
                    }},
                    {"localBounds", new MemberRegisterInfo { Name = "localBounds", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_localBounds, PropertySetter = UnityEngine_Renderer_Wrap.S_localBounds
#endif
                    }},
                    {"enabled", new MemberRegisterInfo { Name = "enabled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_enabled, PropertySetter = UnityEngine_Renderer_Wrap.S_enabled
#endif
                    }},
                    {"isVisible", new MemberRegisterInfo { Name = "isVisible", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_isVisible
#endif
                    }},
                    {"shadowCastingMode", new MemberRegisterInfo { Name = "shadowCastingMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_shadowCastingMode, PropertySetter = UnityEngine_Renderer_Wrap.S_shadowCastingMode
#endif
                    }},
                    {"receiveShadows", new MemberRegisterInfo { Name = "receiveShadows", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_receiveShadows, PropertySetter = UnityEngine_Renderer_Wrap.S_receiveShadows
#endif
                    }},
                    {"forceRenderingOff", new MemberRegisterInfo { Name = "forceRenderingOff", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_forceRenderingOff, PropertySetter = UnityEngine_Renderer_Wrap.S_forceRenderingOff
#endif
                    }},
                    {"staticShadowCaster", new MemberRegisterInfo { Name = "staticShadowCaster", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_staticShadowCaster, PropertySetter = UnityEngine_Renderer_Wrap.S_staticShadowCaster
#endif
                    }},
                    {"motionVectorGenerationMode", new MemberRegisterInfo { Name = "motionVectorGenerationMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_motionVectorGenerationMode, PropertySetter = UnityEngine_Renderer_Wrap.S_motionVectorGenerationMode
#endif
                    }},
                    {"lightProbeUsage", new MemberRegisterInfo { Name = "lightProbeUsage", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_lightProbeUsage, PropertySetter = UnityEngine_Renderer_Wrap.S_lightProbeUsage
#endif
                    }},
                    {"reflectionProbeUsage", new MemberRegisterInfo { Name = "reflectionProbeUsage", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_reflectionProbeUsage, PropertySetter = UnityEngine_Renderer_Wrap.S_reflectionProbeUsage
#endif
                    }},
                    {"renderingLayerMask", new MemberRegisterInfo { Name = "renderingLayerMask", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_renderingLayerMask, PropertySetter = UnityEngine_Renderer_Wrap.S_renderingLayerMask
#endif
                    }},
                    {"rendererPriority", new MemberRegisterInfo { Name = "rendererPriority", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_rendererPriority, PropertySetter = UnityEngine_Renderer_Wrap.S_rendererPriority
#endif
                    }},
                    {"rayTracingMode", new MemberRegisterInfo { Name = "rayTracingMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_rayTracingMode, PropertySetter = UnityEngine_Renderer_Wrap.S_rayTracingMode
#endif
                    }},
                    {"sortingLayerName", new MemberRegisterInfo { Name = "sortingLayerName", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_sortingLayerName, PropertySetter = UnityEngine_Renderer_Wrap.S_sortingLayerName
#endif
                    }},
                    {"sortingLayerID", new MemberRegisterInfo { Name = "sortingLayerID", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_sortingLayerID, PropertySetter = UnityEngine_Renderer_Wrap.S_sortingLayerID
#endif
                    }},
                    {"sortingOrder", new MemberRegisterInfo { Name = "sortingOrder", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_sortingOrder, PropertySetter = UnityEngine_Renderer_Wrap.S_sortingOrder
#endif
                    }},
                    {"allowOcclusionWhenDynamic", new MemberRegisterInfo { Name = "allowOcclusionWhenDynamic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_allowOcclusionWhenDynamic, PropertySetter = UnityEngine_Renderer_Wrap.S_allowOcclusionWhenDynamic
#endif
                    }},
                    {"isPartOfStaticBatch", new MemberRegisterInfo { Name = "isPartOfStaticBatch", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_isPartOfStaticBatch
#endif
                    }},
                    {"worldToLocalMatrix", new MemberRegisterInfo { Name = "worldToLocalMatrix", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_worldToLocalMatrix
#endif
                    }},
                    {"localToWorldMatrix", new MemberRegisterInfo { Name = "localToWorldMatrix", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_localToWorldMatrix
#endif
                    }},
                    {"lightProbeProxyVolumeOverride", new MemberRegisterInfo { Name = "lightProbeProxyVolumeOverride", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_lightProbeProxyVolumeOverride, PropertySetter = UnityEngine_Renderer_Wrap.S_lightProbeProxyVolumeOverride
#endif
                    }},
                    {"probeAnchor", new MemberRegisterInfo { Name = "probeAnchor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_probeAnchor, PropertySetter = UnityEngine_Renderer_Wrap.S_probeAnchor
#endif
                    }},
                    {"lightmapIndex", new MemberRegisterInfo { Name = "lightmapIndex", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_lightmapIndex, PropertySetter = UnityEngine_Renderer_Wrap.S_lightmapIndex
#endif
                    }},
                    {"realtimeLightmapIndex", new MemberRegisterInfo { Name = "realtimeLightmapIndex", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_realtimeLightmapIndex, PropertySetter = UnityEngine_Renderer_Wrap.S_realtimeLightmapIndex
#endif
                    }},
                    {"lightmapScaleOffset", new MemberRegisterInfo { Name = "lightmapScaleOffset", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_lightmapScaleOffset, PropertySetter = UnityEngine_Renderer_Wrap.S_lightmapScaleOffset
#endif
                    }},
                    {"realtimeLightmapScaleOffset", new MemberRegisterInfo { Name = "realtimeLightmapScaleOffset", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_realtimeLightmapScaleOffset, PropertySetter = UnityEngine_Renderer_Wrap.S_realtimeLightmapScaleOffset
#endif
                    }},
                    {"materials", new MemberRegisterInfo { Name = "materials", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_materials, PropertySetter = UnityEngine_Renderer_Wrap.S_materials
#endif
                    }},
                    {"material", new MemberRegisterInfo { Name = "material", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_material, PropertySetter = UnityEngine_Renderer_Wrap.S_material
#endif
                    }},
                    {"sharedMaterial", new MemberRegisterInfo { Name = "sharedMaterial", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_sharedMaterial, PropertySetter = UnityEngine_Renderer_Wrap.S_sharedMaterial
#endif
                    }},
                    {"sharedMaterials", new MemberRegisterInfo { Name = "sharedMaterials", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Renderer_Wrap.G_sharedMaterials, PropertySetter = UnityEngine_Renderer_Wrap.S_sharedMaterials
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_SkinnedMeshRenderer_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_SkinnedMeshRenderer_Wrap.Constructor
#endif
                    }},
                    {"GetBlendShapeWeight", new MemberRegisterInfo { Name = "GetBlendShapeWeight", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_SkinnedMeshRenderer_Wrap.M_GetBlendShapeWeight
#endif
                    }},
                    {"SetBlendShapeWeight", new MemberRegisterInfo { Name = "SetBlendShapeWeight", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_SkinnedMeshRenderer_Wrap.M_SetBlendShapeWeight
#endif
                    }},
                    {"BakeMesh", new MemberRegisterInfo { Name = "BakeMesh", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_SkinnedMeshRenderer_Wrap.M_BakeMesh
#endif
                    }},
                    {"GetVertexBuffer", new MemberRegisterInfo { Name = "GetVertexBuffer", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_SkinnedMeshRenderer_Wrap.M_GetVertexBuffer
#endif
                    }},
                    {"GetPreviousVertexBuffer", new MemberRegisterInfo { Name = "GetPreviousVertexBuffer", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_SkinnedMeshRenderer_Wrap.M_GetPreviousVertexBuffer
#endif
                    }},
                    {"quality", new MemberRegisterInfo { Name = "quality", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_SkinnedMeshRenderer_Wrap.G_quality, PropertySetter = UnityEngine_SkinnedMeshRenderer_Wrap.S_quality
#endif
                    }},
                    {"updateWhenOffscreen", new MemberRegisterInfo { Name = "updateWhenOffscreen", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_SkinnedMeshRenderer_Wrap.G_updateWhenOffscreen, PropertySetter = UnityEngine_SkinnedMeshRenderer_Wrap.S_updateWhenOffscreen
#endif
                    }},
                    {"forceMatrixRecalculationPerRender", new MemberRegisterInfo { Name = "forceMatrixRecalculationPerRender", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_SkinnedMeshRenderer_Wrap.G_forceMatrixRecalculationPerRender, PropertySetter = UnityEngine_SkinnedMeshRenderer_Wrap.S_forceMatrixRecalculationPerRender
#endif
                    }},
                    {"rootBone", new MemberRegisterInfo { Name = "rootBone", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_SkinnedMeshRenderer_Wrap.G_rootBone, PropertySetter = UnityEngine_SkinnedMeshRenderer_Wrap.S_rootBone
#endif
                    }},
                    {"bones", new MemberRegisterInfo { Name = "bones", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_SkinnedMeshRenderer_Wrap.G_bones, PropertySetter = UnityEngine_SkinnedMeshRenderer_Wrap.S_bones
#endif
                    }},
                    {"sharedMesh", new MemberRegisterInfo { Name = "sharedMesh", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_SkinnedMeshRenderer_Wrap.G_sharedMesh, PropertySetter = UnityEngine_SkinnedMeshRenderer_Wrap.S_sharedMesh
#endif
                    }},
                    {"skinnedMotionVectors", new MemberRegisterInfo { Name = "skinnedMotionVectors", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_SkinnedMeshRenderer_Wrap.G_skinnedMotionVectors, PropertySetter = UnityEngine_SkinnedMeshRenderer_Wrap.S_skinnedMotionVectors
#endif
                    }},
                    {"vertexBufferTarget", new MemberRegisterInfo { Name = "vertexBufferTarget", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_SkinnedMeshRenderer_Wrap.G_vertexBufferTarget, PropertySetter = UnityEngine_SkinnedMeshRenderer_Wrap.S_vertexBufferTarget
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Input_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Input_Wrap.Constructor
#endif
                    }},
                    {"GetAxis_static", new MemberRegisterInfo { Name = "GetAxis", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetAxis
#endif
                    }},
                    {"GetAxisRaw_static", new MemberRegisterInfo { Name = "GetAxisRaw", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetAxisRaw
#endif
                    }},
                    {"GetButton_static", new MemberRegisterInfo { Name = "GetButton", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetButton
#endif
                    }},
                    {"GetButtonDown_static", new MemberRegisterInfo { Name = "GetButtonDown", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetButtonDown
#endif
                    }},
                    {"GetButtonUp_static", new MemberRegisterInfo { Name = "GetButtonUp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetButtonUp
#endif
                    }},
                    {"GetMouseButton_static", new MemberRegisterInfo { Name = "GetMouseButton", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetMouseButton
#endif
                    }},
                    {"GetMouseButtonDown_static", new MemberRegisterInfo { Name = "GetMouseButtonDown", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetMouseButtonDown
#endif
                    }},
                    {"GetMouseButtonUp_static", new MemberRegisterInfo { Name = "GetMouseButtonUp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetMouseButtonUp
#endif
                    }},
                    {"ResetInputAxes_static", new MemberRegisterInfo { Name = "ResetInputAxes", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_ResetInputAxes
#endif
                    }},
                    {"IsJoystickPreconfigured_static", new MemberRegisterInfo { Name = "IsJoystickPreconfigured", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.SlowBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    
#endif
                    }},
                    {"GetJoystickNames_static", new MemberRegisterInfo { Name = "GetJoystickNames", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetJoystickNames
#endif
                    }},
                    {"GetTouch_static", new MemberRegisterInfo { Name = "GetTouch", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetTouch
#endif
                    }},
                    {"GetPenEvent_static", new MemberRegisterInfo { Name = "GetPenEvent", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetPenEvent
#endif
                    }},
                    {"GetLastPenContactEvent_static", new MemberRegisterInfo { Name = "GetLastPenContactEvent", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetLastPenContactEvent
#endif
                    }},
                    {"ResetPenEvents_static", new MemberRegisterInfo { Name = "ResetPenEvents", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_ResetPenEvents
#endif
                    }},
                    {"ClearLastPenContactEvent_static", new MemberRegisterInfo { Name = "ClearLastPenContactEvent", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_ClearLastPenContactEvent
#endif
                    }},
                    {"GetAccelerationEvent_static", new MemberRegisterInfo { Name = "GetAccelerationEvent", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetAccelerationEvent
#endif
                    }},
                    {"GetKey_static", new MemberRegisterInfo { Name = "GetKey", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetKey
#endif
                    }},
                    {"GetKeyUp_static", new MemberRegisterInfo { Name = "GetKeyUp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetKeyUp
#endif
                    }},
                    {"GetKeyDown_static", new MemberRegisterInfo { Name = "GetKeyDown", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Input_Wrap.F_GetKeyDown
#endif
                    }},
                    {"simulateMouseWithTouches_static", new MemberRegisterInfo { Name = "simulateMouseWithTouches", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_simulateMouseWithTouches, PropertySetter = UnityEngine_Input_Wrap.S_simulateMouseWithTouches
#endif
                    }},
                    {"anyKey_static", new MemberRegisterInfo { Name = "anyKey", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_anyKey
#endif
                    }},
                    {"anyKeyDown_static", new MemberRegisterInfo { Name = "anyKeyDown", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_anyKeyDown
#endif
                    }},
                    {"inputString_static", new MemberRegisterInfo { Name = "inputString", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_inputString
#endif
                    }},
                    {"mousePosition_static", new MemberRegisterInfo { Name = "mousePosition", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_mousePosition
#endif
                    }},
                    {"mouseScrollDelta_static", new MemberRegisterInfo { Name = "mouseScrollDelta", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_mouseScrollDelta
#endif
                    }},
                    {"imeCompositionMode_static", new MemberRegisterInfo { Name = "imeCompositionMode", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_imeCompositionMode, PropertySetter = UnityEngine_Input_Wrap.S_imeCompositionMode
#endif
                    }},
                    {"compositionString_static", new MemberRegisterInfo { Name = "compositionString", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_compositionString
#endif
                    }},
                    {"imeIsSelected_static", new MemberRegisterInfo { Name = "imeIsSelected", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_imeIsSelected
#endif
                    }},
                    {"compositionCursorPos_static", new MemberRegisterInfo { Name = "compositionCursorPos", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_compositionCursorPos, PropertySetter = UnityEngine_Input_Wrap.S_compositionCursorPos
#endif
                    }},
                    {"mousePresent_static", new MemberRegisterInfo { Name = "mousePresent", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_mousePresent
#endif
                    }},
                    {"penEventCount_static", new MemberRegisterInfo { Name = "penEventCount", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_penEventCount
#endif
                    }},
                    {"touchCount_static", new MemberRegisterInfo { Name = "touchCount", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_touchCount
#endif
                    }},
                    {"touchPressureSupported_static", new MemberRegisterInfo { Name = "touchPressureSupported", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_touchPressureSupported
#endif
                    }},
                    {"stylusTouchSupported_static", new MemberRegisterInfo { Name = "stylusTouchSupported", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_stylusTouchSupported
#endif
                    }},
                    {"touchSupported_static", new MemberRegisterInfo { Name = "touchSupported", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_touchSupported
#endif
                    }},
                    {"multiTouchEnabled_static", new MemberRegisterInfo { Name = "multiTouchEnabled", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_multiTouchEnabled, PropertySetter = UnityEngine_Input_Wrap.S_multiTouchEnabled
#endif
                    }},
                    {"deviceOrientation_static", new MemberRegisterInfo { Name = "deviceOrientation", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_deviceOrientation
#endif
                    }},
                    {"acceleration_static", new MemberRegisterInfo { Name = "acceleration", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_acceleration
#endif
                    }},
                    {"compensateSensors_static", new MemberRegisterInfo { Name = "compensateSensors", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_compensateSensors, PropertySetter = UnityEngine_Input_Wrap.S_compensateSensors
#endif
                    }},
                    {"accelerationEventCount_static", new MemberRegisterInfo { Name = "accelerationEventCount", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_accelerationEventCount
#endif
                    }},
                    {"backButtonLeavesApp_static", new MemberRegisterInfo { Name = "backButtonLeavesApp", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_backButtonLeavesApp, PropertySetter = UnityEngine_Input_Wrap.S_backButtonLeavesApp
#endif
                    }},
                    {"location_static", new MemberRegisterInfo { Name = "location", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_location
#endif
                    }},
                    {"compass_static", new MemberRegisterInfo { Name = "compass", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_compass
#endif
                    }},
                    {"gyro_static", new MemberRegisterInfo { Name = "gyro", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_gyro
#endif
                    }},
                    {"touches_static", new MemberRegisterInfo { Name = "touches", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_touches
#endif
                    }},
                    {"accelerationEvents_static", new MemberRegisterInfo { Name = "accelerationEvents", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Input_Wrap.G_accelerationEvents
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Random_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"InitState_static", new MemberRegisterInfo { Name = "InitState", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Random_Wrap.F_InitState
#endif
                    }},
                    {"Range_static", new MemberRegisterInfo { Name = "Range", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Random_Wrap.F_Range
#endif
                    }},
                    {"ColorHSV_static", new MemberRegisterInfo { Name = "ColorHSV", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Random_Wrap.F_ColorHSV
#endif
                    }},
                    {"state_static", new MemberRegisterInfo { Name = "state", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Random_Wrap.G_state, PropertySetter = UnityEngine_Random_Wrap.S_state
#endif
                    }},
                    {"value_static", new MemberRegisterInfo { Name = "value", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Random_Wrap.G_value
#endif
                    }},
                    {"insideUnitSphere_static", new MemberRegisterInfo { Name = "insideUnitSphere", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Random_Wrap.G_insideUnitSphere
#endif
                    }},
                    {"insideUnitCircle_static", new MemberRegisterInfo { Name = "insideUnitCircle", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Random_Wrap.G_insideUnitCircle
#endif
                    }},
                    {"onUnitSphere_static", new MemberRegisterInfo { Name = "onUnitSphere", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Random_Wrap.G_onUnitSphere
#endif
                    }},
                    {"rotation_static", new MemberRegisterInfo { Name = "rotation", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Random_Wrap.G_rotation
#endif
                    }},
                    {"rotationUniform_static", new MemberRegisterInfo { Name = "rotationUniform", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Random_Wrap.G_rotationUniform
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Behaviour_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Behaviour_Wrap.Constructor
#endif
                    }},
                    {"enabled", new MemberRegisterInfo { Name = "enabled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Behaviour_Wrap.G_enabled, PropertySetter = UnityEngine_Behaviour_Wrap.S_enabled
#endif
                    }},
                    {"isActiveAndEnabled", new MemberRegisterInfo { Name = "isActiveAndEnabled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Behaviour_Wrap.G_isActiveAndEnabled
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Networking_UnityWebRequest_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Networking_UnityWebRequest_Wrap.Constructor
#endif
                    }},
                    {"Dispose", new MemberRegisterInfo { Name = "Dispose", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_Dispose
#endif
                    }},
                    {"SendWebRequest", new MemberRegisterInfo { Name = "SendWebRequest", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_SendWebRequest
#endif
                    }},
                    {"Abort", new MemberRegisterInfo { Name = "Abort", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_Abort
#endif
                    }},
                    {"GetRequestHeader", new MemberRegisterInfo { Name = "GetRequestHeader", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_GetRequestHeader
#endif
                    }},
                    {"SetRequestHeader", new MemberRegisterInfo { Name = "SetRequestHeader", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_SetRequestHeader
#endif
                    }},
                    {"GetResponseHeader", new MemberRegisterInfo { Name = "GetResponseHeader", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_GetResponseHeader
#endif
                    }},
                    {"GetResponseHeaders", new MemberRegisterInfo { Name = "GetResponseHeaders", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.M_GetResponseHeaders
#endif
                    }},
                    {"disposeCertificateHandlerOnDispose", new MemberRegisterInfo { Name = "disposeCertificateHandlerOnDispose", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_disposeCertificateHandlerOnDispose, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_disposeCertificateHandlerOnDispose
#endif
                    }},
                    {"disposeDownloadHandlerOnDispose", new MemberRegisterInfo { Name = "disposeDownloadHandlerOnDispose", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_disposeDownloadHandlerOnDispose, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_disposeDownloadHandlerOnDispose
#endif
                    }},
                    {"disposeUploadHandlerOnDispose", new MemberRegisterInfo { Name = "disposeUploadHandlerOnDispose", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_disposeUploadHandlerOnDispose, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_disposeUploadHandlerOnDispose
#endif
                    }},
                    {"method", new MemberRegisterInfo { Name = "method", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_method, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_method
#endif
                    }},
                    {"error", new MemberRegisterInfo { Name = "error", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_error
#endif
                    }},
                    {"useHttpContinue", new MemberRegisterInfo { Name = "useHttpContinue", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_useHttpContinue, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_useHttpContinue
#endif
                    }},
                    {"url", new MemberRegisterInfo { Name = "url", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_url, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_url
#endif
                    }},
                    {"uri", new MemberRegisterInfo { Name = "uri", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_uri, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_uri
#endif
                    }},
                    {"responseCode", new MemberRegisterInfo { Name = "responseCode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_responseCode
#endif
                    }},
                    {"uploadProgress", new MemberRegisterInfo { Name = "uploadProgress", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_uploadProgress
#endif
                    }},
                    {"isModifiable", new MemberRegisterInfo { Name = "isModifiable", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_isModifiable
#endif
                    }},
                    {"isDone", new MemberRegisterInfo { Name = "isDone", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_isDone
#endif
                    }},
                    {"result", new MemberRegisterInfo { Name = "result", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_result
#endif
                    }},
                    {"downloadProgress", new MemberRegisterInfo { Name = "downloadProgress", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_downloadProgress
#endif
                    }},
                    {"uploadedBytes", new MemberRegisterInfo { Name = "uploadedBytes", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_uploadedBytes
#endif
                    }},
                    {"downloadedBytes", new MemberRegisterInfo { Name = "downloadedBytes", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_downloadedBytes
#endif
                    }},
                    {"redirectLimit", new MemberRegisterInfo { Name = "redirectLimit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_redirectLimit, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_redirectLimit
#endif
                    }},
                    {"uploadHandler", new MemberRegisterInfo { Name = "uploadHandler", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_uploadHandler, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_uploadHandler
#endif
                    }},
                    {"downloadHandler", new MemberRegisterInfo { Name = "downloadHandler", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_downloadHandler, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_downloadHandler
#endif
                    }},
                    {"certificateHandler", new MemberRegisterInfo { Name = "certificateHandler", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_certificateHandler, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_certificateHandler
#endif
                    }},
                    {"timeout", new MemberRegisterInfo { Name = "timeout", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_timeout, PropertySetter = UnityEngine_Networking_UnityWebRequest_Wrap.S_timeout
#endif
                    }},
                    {"ClearCookieCache_static", new MemberRegisterInfo { Name = "ClearCookieCache", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_ClearCookieCache
#endif
                    }},
                    {"Get_static", new MemberRegisterInfo { Name = "Get", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_Get
#endif
                    }},
                    {"Delete_static", new MemberRegisterInfo { Name = "Delete", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_Delete
#endif
                    }},
                    {"Head_static", new MemberRegisterInfo { Name = "Head", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_Head
#endif
                    }},
                    {"Put_static", new MemberRegisterInfo { Name = "Put", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_Put
#endif
                    }},
                    {"PostWwwForm_static", new MemberRegisterInfo { Name = "PostWwwForm", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_PostWwwForm
#endif
                    }},
                    {"Post_static", new MemberRegisterInfo { Name = "Post", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_Post
#endif
                    }},
                    {"EscapeURL_static", new MemberRegisterInfo { Name = "EscapeURL", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_EscapeURL
#endif
                    }},
                    {"UnEscapeURL_static", new MemberRegisterInfo { Name = "UnEscapeURL", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_UnEscapeURL
#endif
                    }},
                    {"SerializeFormSections_static", new MemberRegisterInfo { Name = "SerializeFormSections", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_SerializeFormSections
#endif
                    }},
                    {"GenerateBoundary_static", new MemberRegisterInfo { Name = "GenerateBoundary", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_GenerateBoundary
#endif
                    }},
                    {"SerializeSimpleForm_static", new MemberRegisterInfo { Name = "SerializeSimpleForm", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_UnityWebRequest_Wrap.F_SerializeSimpleForm
#endif
                    }},
                    {"kHttpVerbGET_static", new MemberRegisterInfo { Name = "kHttpVerbGET", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_kHttpVerbGET
#endif
                    }},
                    {"kHttpVerbHEAD_static", new MemberRegisterInfo { Name = "kHttpVerbHEAD", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_kHttpVerbHEAD
#endif
                    }},
                    {"kHttpVerbPOST_static", new MemberRegisterInfo { Name = "kHttpVerbPOST", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_kHttpVerbPOST
#endif
                    }},
                    {"kHttpVerbPUT_static", new MemberRegisterInfo { Name = "kHttpVerbPUT", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_kHttpVerbPUT
#endif
                    }},
                    {"kHttpVerbCREATE_static", new MemberRegisterInfo { Name = "kHttpVerbCREATE", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_kHttpVerbCREATE
#endif
                    }},
                    {"kHttpVerbDELETE_static", new MemberRegisterInfo { Name = "kHttpVerbDELETE", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_UnityWebRequest_Wrap.G_kHttpVerbDELETE
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Networking_DownloadHandler_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"Dispose", new MemberRegisterInfo { Name = "Dispose", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Networking_DownloadHandler_Wrap.M_Dispose
#endif
                    }},
                    {"isDone", new MemberRegisterInfo { Name = "isDone", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_DownloadHandler_Wrap.G_isDone
#endif
                    }},
                    {"error", new MemberRegisterInfo { Name = "error", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_DownloadHandler_Wrap.G_error
#endif
                    }},
                    {"nativeData", new MemberRegisterInfo { Name = "nativeData", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_DownloadHandler_Wrap.G_nativeData
#endif
                    }},
                    {"data", new MemberRegisterInfo { Name = "data", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_DownloadHandler_Wrap.G_data
#endif
                    }},
                    {"text", new MemberRegisterInfo { Name = "text", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_Networking_DownloadHandler_Wrap.G_text
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_EventSystems_UIBehaviour_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"IsActive", new MemberRegisterInfo { Name = "IsActive", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_EventSystems_UIBehaviour_Wrap.M_IsActive
#endif
                    }},
                    {"IsDestroyed", new MemberRegisterInfo { Name = "IsDestroyed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_EventSystems_UIBehaviour_Wrap.M_IsDestroyed
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Selectable_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"IsInteractable", new MemberRegisterInfo { Name = "IsInteractable", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_IsInteractable
#endif
                    }},
                    {"FindSelectable", new MemberRegisterInfo { Name = "FindSelectable", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectable
#endif
                    }},
                    {"FindSelectableOnLeft", new MemberRegisterInfo { Name = "FindSelectableOnLeft", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectableOnLeft
#endif
                    }},
                    {"FindSelectableOnRight", new MemberRegisterInfo { Name = "FindSelectableOnRight", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectableOnRight
#endif
                    }},
                    {"FindSelectableOnUp", new MemberRegisterInfo { Name = "FindSelectableOnUp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectableOnUp
#endif
                    }},
                    {"FindSelectableOnDown", new MemberRegisterInfo { Name = "FindSelectableOnDown", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectableOnDown
#endif
                    }},
                    {"OnMove", new MemberRegisterInfo { Name = "OnMove", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnMove
#endif
                    }},
                    {"OnPointerDown", new MemberRegisterInfo { Name = "OnPointerDown", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnPointerDown
#endif
                    }},
                    {"OnPointerUp", new MemberRegisterInfo { Name = "OnPointerUp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnPointerUp
#endif
                    }},
                    {"OnPointerEnter", new MemberRegisterInfo { Name = "OnPointerEnter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnPointerEnter
#endif
                    }},
                    {"OnPointerExit", new MemberRegisterInfo { Name = "OnPointerExit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnPointerExit
#endif
                    }},
                    {"OnSelect", new MemberRegisterInfo { Name = "OnSelect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnSelect
#endif
                    }},
                    {"OnDeselect", new MemberRegisterInfo { Name = "OnDeselect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnDeselect
#endif
                    }},
                    {"Select", new MemberRegisterInfo { Name = "Select", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.M_Select
#endif
                    }},
                    {"navigation", new MemberRegisterInfo { Name = "navigation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_navigation, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_navigation
#endif
                    }},
                    {"transition", new MemberRegisterInfo { Name = "transition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_transition, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_transition
#endif
                    }},
                    {"colors", new MemberRegisterInfo { Name = "colors", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_colors, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_colors
#endif
                    }},
                    {"spriteState", new MemberRegisterInfo { Name = "spriteState", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_spriteState, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_spriteState
#endif
                    }},
                    {"animationTriggers", new MemberRegisterInfo { Name = "animationTriggers", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_animationTriggers, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_animationTriggers
#endif
                    }},
                    {"targetGraphic", new MemberRegisterInfo { Name = "targetGraphic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_targetGraphic, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_targetGraphic
#endif
                    }},
                    {"interactable", new MemberRegisterInfo { Name = "interactable", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_interactable, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_interactable
#endif
                    }},
                    {"image", new MemberRegisterInfo { Name = "image", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_image, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_image
#endif
                    }},
                    {"animator", new MemberRegisterInfo { Name = "animator", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_animator
#endif
                    }},
                    {"AllSelectablesNoAlloc_static", new MemberRegisterInfo { Name = "AllSelectablesNoAlloc", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Selectable_Wrap.F_AllSelectablesNoAlloc
#endif
                    }},
                    {"allSelectablesArray_static", new MemberRegisterInfo { Name = "allSelectablesArray", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_allSelectablesArray
#endif
                    }},
                    {"allSelectableCount_static", new MemberRegisterInfo { Name = "allSelectableCount", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_allSelectableCount
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Button_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"OnPointerClick", new MemberRegisterInfo { Name = "OnPointerClick", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Button_Wrap.M_OnPointerClick
#endif
                    }},
                    {"OnSubmit", new MemberRegisterInfo { Name = "OnSubmit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Button_Wrap.M_OnSubmit
#endif
                    }},
                    {"onClick", new MemberRegisterInfo { Name = "onClick", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Button_Wrap.G_onClick, PropertySetter = UnityEngine_UI_Button_Wrap.S_onClick
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Button_ButtonClickedEvent_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_UI_Button_ButtonClickedEvent_Wrap.Constructor
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Events_UnityEvent_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Events_UnityEvent_Wrap.Constructor
#endif
                    }},
                    {"AddListener", new MemberRegisterInfo { Name = "AddListener", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Events_UnityEvent_Wrap.M_AddListener
#endif
                    }},
                    {"RemoveListener", new MemberRegisterInfo { Name = "RemoveListener", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Events_UnityEvent_Wrap.M_RemoveListener
#endif
                    }},
                    {"Invoke", new MemberRegisterInfo { Name = "Invoke", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Events_UnityEvent_Wrap.M_Invoke
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_InputField_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"SetTextWithoutNotify", new MemberRegisterInfo { Name = "SetTextWithoutNotify", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_SetTextWithoutNotify
#endif
                    }},
                    {"MoveTextEnd", new MemberRegisterInfo { Name = "MoveTextEnd", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_MoveTextEnd
#endif
                    }},
                    {"MoveTextStart", new MemberRegisterInfo { Name = "MoveTextStart", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_MoveTextStart
#endif
                    }},
                    {"OnBeginDrag", new MemberRegisterInfo { Name = "OnBeginDrag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnBeginDrag
#endif
                    }},
                    {"OnDrag", new MemberRegisterInfo { Name = "OnDrag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnDrag
#endif
                    }},
                    {"OnEndDrag", new MemberRegisterInfo { Name = "OnEndDrag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnEndDrag
#endif
                    }},
                    {"OnPointerDown", new MemberRegisterInfo { Name = "OnPointerDown", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnPointerDown
#endif
                    }},
                    {"ProcessEvent", new MemberRegisterInfo { Name = "ProcessEvent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_ProcessEvent
#endif
                    }},
                    {"OnUpdateSelected", new MemberRegisterInfo { Name = "OnUpdateSelected", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnUpdateSelected
#endif
                    }},
                    {"ForceLabelUpdate", new MemberRegisterInfo { Name = "ForceLabelUpdate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_ForceLabelUpdate
#endif
                    }},
                    {"Rebuild", new MemberRegisterInfo { Name = "Rebuild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_Rebuild
#endif
                    }},
                    {"LayoutComplete", new MemberRegisterInfo { Name = "LayoutComplete", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_LayoutComplete
#endif
                    }},
                    {"GraphicUpdateComplete", new MemberRegisterInfo { Name = "GraphicUpdateComplete", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_GraphicUpdateComplete
#endif
                    }},
                    {"ActivateInputField", new MemberRegisterInfo { Name = "ActivateInputField", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_ActivateInputField
#endif
                    }},
                    {"OnSelect", new MemberRegisterInfo { Name = "OnSelect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnSelect
#endif
                    }},
                    {"OnPointerClick", new MemberRegisterInfo { Name = "OnPointerClick", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnPointerClick
#endif
                    }},
                    {"DeactivateInputField", new MemberRegisterInfo { Name = "DeactivateInputField", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_DeactivateInputField
#endif
                    }},
                    {"OnDeselect", new MemberRegisterInfo { Name = "OnDeselect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnDeselect
#endif
                    }},
                    {"OnSubmit", new MemberRegisterInfo { Name = "OnSubmit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnSubmit
#endif
                    }},
                    {"CalculateLayoutInputHorizontal", new MemberRegisterInfo { Name = "CalculateLayoutInputHorizontal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_CalculateLayoutInputHorizontal
#endif
                    }},
                    {"CalculateLayoutInputVertical", new MemberRegisterInfo { Name = "CalculateLayoutInputVertical", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_InputField_Wrap.M_CalculateLayoutInputVertical
#endif
                    }},
                    {"shouldHideMobileInput", new MemberRegisterInfo { Name = "shouldHideMobileInput", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_shouldHideMobileInput, PropertySetter = UnityEngine_UI_InputField_Wrap.S_shouldHideMobileInput
#endif
                    }},
                    {"shouldActivateOnSelect", new MemberRegisterInfo { Name = "shouldActivateOnSelect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_shouldActivateOnSelect, PropertySetter = UnityEngine_UI_InputField_Wrap.S_shouldActivateOnSelect
#endif
                    }},
                    {"text", new MemberRegisterInfo { Name = "text", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_text, PropertySetter = UnityEngine_UI_InputField_Wrap.S_text
#endif
                    }},
                    {"isFocused", new MemberRegisterInfo { Name = "isFocused", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_isFocused
#endif
                    }},
                    {"caretBlinkRate", new MemberRegisterInfo { Name = "caretBlinkRate", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_caretBlinkRate, PropertySetter = UnityEngine_UI_InputField_Wrap.S_caretBlinkRate
#endif
                    }},
                    {"caretWidth", new MemberRegisterInfo { Name = "caretWidth", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_caretWidth, PropertySetter = UnityEngine_UI_InputField_Wrap.S_caretWidth
#endif
                    }},
                    {"textComponent", new MemberRegisterInfo { Name = "textComponent", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_textComponent, PropertySetter = UnityEngine_UI_InputField_Wrap.S_textComponent
#endif
                    }},
                    {"placeholder", new MemberRegisterInfo { Name = "placeholder", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_placeholder, PropertySetter = UnityEngine_UI_InputField_Wrap.S_placeholder
#endif
                    }},
                    {"caretColor", new MemberRegisterInfo { Name = "caretColor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_caretColor, PropertySetter = UnityEngine_UI_InputField_Wrap.S_caretColor
#endif
                    }},
                    {"customCaretColor", new MemberRegisterInfo { Name = "customCaretColor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_customCaretColor, PropertySetter = UnityEngine_UI_InputField_Wrap.S_customCaretColor
#endif
                    }},
                    {"selectionColor", new MemberRegisterInfo { Name = "selectionColor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_selectionColor, PropertySetter = UnityEngine_UI_InputField_Wrap.S_selectionColor
#endif
                    }},
                    {"onEndEdit", new MemberRegisterInfo { Name = "onEndEdit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_onEndEdit, PropertySetter = UnityEngine_UI_InputField_Wrap.S_onEndEdit
#endif
                    }},
                    {"onSubmit", new MemberRegisterInfo { Name = "onSubmit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_onSubmit, PropertySetter = UnityEngine_UI_InputField_Wrap.S_onSubmit
#endif
                    }},
                    {"onValueChanged", new MemberRegisterInfo { Name = "onValueChanged", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_onValueChanged, PropertySetter = UnityEngine_UI_InputField_Wrap.S_onValueChanged
#endif
                    }},
                    {"onValidateInput", new MemberRegisterInfo { Name = "onValidateInput", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_onValidateInput, PropertySetter = UnityEngine_UI_InputField_Wrap.S_onValidateInput
#endif
                    }},
                    {"characterLimit", new MemberRegisterInfo { Name = "characterLimit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_characterLimit, PropertySetter = UnityEngine_UI_InputField_Wrap.S_characterLimit
#endif
                    }},
                    {"contentType", new MemberRegisterInfo { Name = "contentType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_contentType, PropertySetter = UnityEngine_UI_InputField_Wrap.S_contentType
#endif
                    }},
                    {"lineType", new MemberRegisterInfo { Name = "lineType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_lineType, PropertySetter = UnityEngine_UI_InputField_Wrap.S_lineType
#endif
                    }},
                    {"inputType", new MemberRegisterInfo { Name = "inputType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_inputType, PropertySetter = UnityEngine_UI_InputField_Wrap.S_inputType
#endif
                    }},
                    {"touchScreenKeyboard", new MemberRegisterInfo { Name = "touchScreenKeyboard", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_touchScreenKeyboard
#endif
                    }},
                    {"keyboardType", new MemberRegisterInfo { Name = "keyboardType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_keyboardType, PropertySetter = UnityEngine_UI_InputField_Wrap.S_keyboardType
#endif
                    }},
                    {"characterValidation", new MemberRegisterInfo { Name = "characterValidation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_characterValidation, PropertySetter = UnityEngine_UI_InputField_Wrap.S_characterValidation
#endif
                    }},
                    {"readOnly", new MemberRegisterInfo { Name = "readOnly", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_readOnly, PropertySetter = UnityEngine_UI_InputField_Wrap.S_readOnly
#endif
                    }},
                    {"multiLine", new MemberRegisterInfo { Name = "multiLine", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_multiLine
#endif
                    }},
                    {"asteriskChar", new MemberRegisterInfo { Name = "asteriskChar", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_asteriskChar, PropertySetter = UnityEngine_UI_InputField_Wrap.S_asteriskChar
#endif
                    }},
                    {"wasCanceled", new MemberRegisterInfo { Name = "wasCanceled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_wasCanceled
#endif
                    }},
                    {"caretPosition", new MemberRegisterInfo { Name = "caretPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_caretPosition, PropertySetter = UnityEngine_UI_InputField_Wrap.S_caretPosition
#endif
                    }},
                    {"selectionAnchorPosition", new MemberRegisterInfo { Name = "selectionAnchorPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_selectionAnchorPosition, PropertySetter = UnityEngine_UI_InputField_Wrap.S_selectionAnchorPosition
#endif
                    }},
                    {"selectionFocusPosition", new MemberRegisterInfo { Name = "selectionFocusPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_selectionFocusPosition, PropertySetter = UnityEngine_UI_InputField_Wrap.S_selectionFocusPosition
#endif
                    }},
                    {"minWidth", new MemberRegisterInfo { Name = "minWidth", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_minWidth
#endif
                    }},
                    {"preferredWidth", new MemberRegisterInfo { Name = "preferredWidth", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_preferredWidth
#endif
                    }},
                    {"flexibleWidth", new MemberRegisterInfo { Name = "flexibleWidth", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_flexibleWidth
#endif
                    }},
                    {"minHeight", new MemberRegisterInfo { Name = "minHeight", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_minHeight
#endif
                    }},
                    {"preferredHeight", new MemberRegisterInfo { Name = "preferredHeight", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_preferredHeight
#endif
                    }},
                    {"flexibleHeight", new MemberRegisterInfo { Name = "flexibleHeight", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_flexibleHeight
#endif
                    }},
                    {"layoutPriority", new MemberRegisterInfo { Name = "layoutPriority", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_layoutPriority
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Toggle_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"Rebuild", new MemberRegisterInfo { Name = "Rebuild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Toggle_Wrap.M_Rebuild
#endif
                    }},
                    {"LayoutComplete", new MemberRegisterInfo { Name = "LayoutComplete", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Toggle_Wrap.M_LayoutComplete
#endif
                    }},
                    {"GraphicUpdateComplete", new MemberRegisterInfo { Name = "GraphicUpdateComplete", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Toggle_Wrap.M_GraphicUpdateComplete
#endif
                    }},
                    {"SetIsOnWithoutNotify", new MemberRegisterInfo { Name = "SetIsOnWithoutNotify", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Toggle_Wrap.M_SetIsOnWithoutNotify
#endif
                    }},
                    {"OnPointerClick", new MemberRegisterInfo { Name = "OnPointerClick", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Toggle_Wrap.M_OnPointerClick
#endif
                    }},
                    {"OnSubmit", new MemberRegisterInfo { Name = "OnSubmit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_UI_Toggle_Wrap.M_OnSubmit
#endif
                    }},
                    {"group", new MemberRegisterInfo { Name = "group", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_group, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_group
#endif
                    }},
                    {"isOn", new MemberRegisterInfo { Name = "isOn", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_isOn, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_isOn
#endif
                    }},
                    {"toggleTransition", new MemberRegisterInfo { Name = "toggleTransition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_toggleTransition, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_toggleTransition
#endif
                    }},
                    {"graphic", new MemberRegisterInfo { Name = "graphic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_graphic, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_graphic
#endif
                    }},
                    {"onValueChanged", new MemberRegisterInfo { Name = "onValueChanged", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_onValueChanged, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_onValueChanged
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Toggle_ToggleEvent_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_UI_Toggle_ToggleEvent_Wrap.Constructor
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap.Constructor
#endif
                    }},
                    {"AddListener", new MemberRegisterInfo { Name = "AddListener", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap.M_AddListener
#endif
                    }},
                    {"RemoveListener", new MemberRegisterInfo { Name = "RemoveListener", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap.M_RemoveListener
#endif
                    }},
                    {"Invoke", new MemberRegisterInfo { Name = "Invoke", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap.M_Invoke
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Calculator_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Calculator_Wrap.Constructor
#endif
                    }},
                    {"Id", new MemberRegisterInfo { Name = "Id", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_Id
#endif
                    }},
                    {"SetSimpleDelegate", new MemberRegisterInfo { Name = "SetSimpleDelegate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_SetSimpleDelegate
#endif
                    }},
                    {"MAdd", new MemberRegisterInfo { Name = "MAdd", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_MAdd
#endif
                    }},
                    {"SetSetSimpleDelegateToMAdd", new MemberRegisterInfo { Name = "SetSetSimpleDelegateToMAdd", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_SetSetSimpleDelegateToMAdd
#endif
                    }},
                    {"SetSetSimpleDelegateToAdd", new MemberRegisterInfo { Name = "SetSetSimpleDelegateToAdd", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_SetSetSimpleDelegateToAdd
#endif
                    }},
                    {"InterfaceArgumnent", new MemberRegisterInfo { Name = "InterfaceArgumnent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_InterfaceArgumnent
#endif
                    }},
                    {"CallInterfaceArgumnentByStruct", new MemberRegisterInfo { Name = "CallInterfaceArgumnentByStruct", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_CallInterfaceArgumnentByStruct
#endif
                    }},
                    {"CallSimpleDelegate", new MemberRegisterInfo { Name = "CallSimpleDelegate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_CallSimpleDelegate
#endif
                    }},
                    {"PrintState", new MemberRegisterInfo { Name = "PrintState", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_PrintState
#endif
                    }},
                    {"EnumRet", new MemberRegisterInfo { Name = "EnumRet", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_EnumRet
#endif
                    }},
                    {"Overload", new MemberRegisterInfo { Name = "Overload", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_Overload
#endif
                    }},
                    {"PassJsObject", new MemberRegisterInfo { Name = "PassJsObject", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_PassJsObject
#endif
                    }},
                    {"IntRef", new MemberRegisterInfo { Name = "IntRef", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_IntRef
#endif
                    }},
                    {"ObjRef", new MemberRegisterInfo { Name = "ObjRef", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_ObjRef
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_ToString
#endif
                    }},
                    {"TestEnumInt", new MemberRegisterInfo { Name = "TestEnumInt", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_TestEnumInt
#endif
                    }},
                    {"TestEnumShort", new MemberRegisterInfo { Name = "TestEnumShort", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_TestEnumShort
#endif
                    }},
                    {"CheckEnumGen", new MemberRegisterInfo { Name = "CheckEnumGen", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_CheckEnumGen
#endif
                    }},
                    {"TestDateTime1234", new MemberRegisterInfo { Name = "TestDateTime1234", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_TestDateTime1234
#endif
                    }},
                    {"GetDictionary", new MemberRegisterInfo { Name = "GetDictionary", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_GetDictionary
#endif
                    }},
                    {"TestParams1", new MemberRegisterInfo { Name = "TestParams1", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_TestParams1
#endif
                    }},
                    {"TestParams2", new MemberRegisterInfo { Name = "TestParams2", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_TestParams2
#endif
                    }},
                    {"TestParams3", new MemberRegisterInfo { Name = "TestParams3", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_TestParams3
#endif
                    }},
                    {"TestParams4", new MemberRegisterInfo { Name = "TestParams4", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_TestParams4
#endif
                    }},
                    {"TestObject", new MemberRegisterInfo { Name = "TestObject", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_TestObject
#endif
                    }},
                    {"DefaultTest", new MemberRegisterInfo { Name = "DefaultTest", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_DefaultTest
#endif
                    }},
                    {"TestDateTime", new MemberRegisterInfo { Name = "TestDateTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_TestDateTime
#endif
                    }},
                    {"OptionalTest1", new MemberRegisterInfo { Name = "OptionalTest1", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_OptionalTest1
#endif
                    }},
                    {"OptionalTest2", new MemberRegisterInfo { Name = "OptionalTest2", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_OptionalTest2
#endif
                    }},
                    {"OptionalTest3", new MemberRegisterInfo { Name = "OptionalTest3", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_OptionalTest3
#endif
                    }},
                    {"M4", new MemberRegisterInfo { Name = "M4", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.M_M4
#endif
                    }},
                    {"PP", new MemberRegisterInfo { Name = "PP", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Calculator_Wrap.G_PP, PropertySetter = Calculator_Wrap.S_PP
#endif
                    }},
                    {"x", new MemberRegisterInfo { Name = "x", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Calculator_Wrap.G_x, PropertySetter = Calculator_Wrap.S_x
#endif
                    }},
                    {"y", new MemberRegisterInfo { Name = "y", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Calculator_Wrap.G_y, PropertySetter = Calculator_Wrap.S_y
#endif
                    }},
                    {"v3", new MemberRegisterInfo { Name = "v3", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Calculator_Wrap.G_v3, PropertySetter = Calculator_Wrap.S_v3
#endif
                    }},
                    {"simpleDelegate", new MemberRegisterInfo { Name = "simpleDelegate", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Calculator_Wrap.G_simpleDelegate, PropertySetter = Calculator_Wrap.S_simpleDelegate
#endif
                    }},
                    {"FFAC", new MemberRegisterInfo { Name = "FFAC", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Calculator_Wrap.G_FFAC, PropertySetter = Calculator_Wrap.S_FFAC
#endif
                    }},
                    {"Add_static", new MemberRegisterInfo { Name = "Add", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.F_Add
#endif
                    }},
                    {"VecTest_static", new MemberRegisterInfo { Name = "VecTest", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.F_VecTest
#endif
                    }},
                    {"PrintVec_static", new MemberRegisterInfo { Name = "PrintVec", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.F_PrintVec
#endif
                    }},
                    {"TestLazyLoad_static", new MemberRegisterInfo { Name = "TestLazyLoad", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.F_TestLazyLoad
#endif
                    }},
                    {"ThrowTest_static", new MemberRegisterInfo { Name = "ThrowTest", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.F_ThrowTest
#endif
                    }},
                    {"ObjRet_static", new MemberRegisterInfo { Name = "ObjRet", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.F_ObjRet
#endif
                    }},
                    {"VecRet_static", new MemberRegisterInfo { Name = "VecRet", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.F_VecRet
#endif
                    }},
                    {"BoundsRet_static", new MemberRegisterInfo { Name = "BoundsRet", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.F_BoundsRet
#endif
                    }},
                    {"V4Ret_static", new MemberRegisterInfo { Name = "V4Ret", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Calculator_Wrap.F_V4Ret
#endif
                    }},
                    {"VV_static", new MemberRegisterInfo { Name = "VV", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Calculator_Wrap.G_VV, PropertySetter = Calculator_Wrap.S_VV
#endif
                    }},
                    {"FFV_static", new MemberRegisterInfo { Name = "FFV", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Calculator_Wrap.G_FFV, PropertySetter = Calculator_Wrap.S_FFV
#endif
                    }},
                    {"FFF_static", new MemberRegisterInfo { Name = "FFF", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Calculator_Wrap.G_FFF, PropertySetter = Calculator_Wrap.S_FFF
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_CalculatorExtension_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"M4_static", new MemberRegisterInfo { Name = "M4", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = CalculatorExtension_Wrap.F_M4
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_System_DateTime_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = System_DateTime_Wrap.Constructor
#endif
                    }},
                    {"Add", new MemberRegisterInfo { Name = "Add", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_Add
#endif
                    }},
                    {"AddDays", new MemberRegisterInfo { Name = "AddDays", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_AddDays
#endif
                    }},
                    {"AddHours", new MemberRegisterInfo { Name = "AddHours", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_AddHours
#endif
                    }},
                    {"AddMilliseconds", new MemberRegisterInfo { Name = "AddMilliseconds", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_AddMilliseconds
#endif
                    }},
                    {"AddMinutes", new MemberRegisterInfo { Name = "AddMinutes", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_AddMinutes
#endif
                    }},
                    {"AddMonths", new MemberRegisterInfo { Name = "AddMonths", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_AddMonths
#endif
                    }},
                    {"AddSeconds", new MemberRegisterInfo { Name = "AddSeconds", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_AddSeconds
#endif
                    }},
                    {"AddTicks", new MemberRegisterInfo { Name = "AddTicks", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_AddTicks
#endif
                    }},
                    {"AddYears", new MemberRegisterInfo { Name = "AddYears", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_AddYears
#endif
                    }},
                    {"CompareTo", new MemberRegisterInfo { Name = "CompareTo", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_CompareTo
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_Equals
#endif
                    }},
                    {"IsDaylightSavingTime", new MemberRegisterInfo { Name = "IsDaylightSavingTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_IsDaylightSavingTime
#endif
                    }},
                    {"ToBinary", new MemberRegisterInfo { Name = "ToBinary", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_ToBinary
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_GetHashCode
#endif
                    }},
                    {"Subtract", new MemberRegisterInfo { Name = "Subtract", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_Subtract
#endif
                    }},
                    {"ToOADate", new MemberRegisterInfo { Name = "ToOADate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_ToOADate
#endif
                    }},
                    {"ToFileTime", new MemberRegisterInfo { Name = "ToFileTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_ToFileTime
#endif
                    }},
                    {"ToFileTimeUtc", new MemberRegisterInfo { Name = "ToFileTimeUtc", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_ToFileTimeUtc
#endif
                    }},
                    {"ToLocalTime", new MemberRegisterInfo { Name = "ToLocalTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_ToLocalTime
#endif
                    }},
                    {"ToLongDateString", new MemberRegisterInfo { Name = "ToLongDateString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_ToLongDateString
#endif
                    }},
                    {"ToLongTimeString", new MemberRegisterInfo { Name = "ToLongTimeString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_ToLongTimeString
#endif
                    }},
                    {"ToShortDateString", new MemberRegisterInfo { Name = "ToShortDateString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_ToShortDateString
#endif
                    }},
                    {"ToShortTimeString", new MemberRegisterInfo { Name = "ToShortTimeString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_ToShortTimeString
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_ToString
#endif
                    }},
                    {"ToUniversalTime", new MemberRegisterInfo { Name = "ToUniversalTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_ToUniversalTime
#endif
                    }},
                    {"op_Addition_static", new MemberRegisterInfo { Name = "op_Addition", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.O_op_Addition
#endif
                    }},
                    {"op_Subtraction_static", new MemberRegisterInfo { Name = "op_Subtraction", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.O_op_Subtraction
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.O_op_Inequality
#endif
                    }},
                    {"op_LessThan_static", new MemberRegisterInfo { Name = "op_LessThan", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.O_op_LessThan
#endif
                    }},
                    {"op_LessThanOrEqual_static", new MemberRegisterInfo { Name = "op_LessThanOrEqual", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.O_op_LessThanOrEqual
#endif
                    }},
                    {"op_GreaterThan_static", new MemberRegisterInfo { Name = "op_GreaterThan", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.O_op_GreaterThan
#endif
                    }},
                    {"op_GreaterThanOrEqual_static", new MemberRegisterInfo { Name = "op_GreaterThanOrEqual", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.O_op_GreaterThanOrEqual
#endif
                    }},
                    {"GetDateTimeFormats", new MemberRegisterInfo { Name = "GetDateTimeFormats", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_GetDateTimeFormats
#endif
                    }},
                    {"GetTypeCode", new MemberRegisterInfo { Name = "GetTypeCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.M_GetTypeCode
#endif
                    }},
                    {"Date", new MemberRegisterInfo { Name = "Date", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_Date
#endif
                    }},
                    {"Day", new MemberRegisterInfo { Name = "Day", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_Day
#endif
                    }},
                    {"DayOfWeek", new MemberRegisterInfo { Name = "DayOfWeek", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_DayOfWeek
#endif
                    }},
                    {"DayOfYear", new MemberRegisterInfo { Name = "DayOfYear", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_DayOfYear
#endif
                    }},
                    {"Hour", new MemberRegisterInfo { Name = "Hour", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_Hour
#endif
                    }},
                    {"Kind", new MemberRegisterInfo { Name = "Kind", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_Kind
#endif
                    }},
                    {"Millisecond", new MemberRegisterInfo { Name = "Millisecond", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_Millisecond
#endif
                    }},
                    {"Minute", new MemberRegisterInfo { Name = "Minute", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_Minute
#endif
                    }},
                    {"Month", new MemberRegisterInfo { Name = "Month", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_Month
#endif
                    }},
                    {"Second", new MemberRegisterInfo { Name = "Second", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_Second
#endif
                    }},
                    {"Ticks", new MemberRegisterInfo { Name = "Ticks", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_Ticks
#endif
                    }},
                    {"TimeOfDay", new MemberRegisterInfo { Name = "TimeOfDay", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_TimeOfDay
#endif
                    }},
                    {"Year", new MemberRegisterInfo { Name = "Year", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_Year
#endif
                    }},
                    {"Compare_static", new MemberRegisterInfo { Name = "Compare", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_Compare
#endif
                    }},
                    {"DaysInMonth_static", new MemberRegisterInfo { Name = "DaysInMonth", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_DaysInMonth
#endif
                    }},
                    {"Equals_static", new MemberRegisterInfo { Name = "Equals", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_Equals
#endif
                    }},
                    {"FromBinary_static", new MemberRegisterInfo { Name = "FromBinary", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_FromBinary
#endif
                    }},
                    {"FromFileTime_static", new MemberRegisterInfo { Name = "FromFileTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_FromFileTime
#endif
                    }},
                    {"FromFileTimeUtc_static", new MemberRegisterInfo { Name = "FromFileTimeUtc", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_FromFileTimeUtc
#endif
                    }},
                    {"FromOADate_static", new MemberRegisterInfo { Name = "FromOADate", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_FromOADate
#endif
                    }},
                    {"SpecifyKind_static", new MemberRegisterInfo { Name = "SpecifyKind", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_SpecifyKind
#endif
                    }},
                    {"IsLeapYear_static", new MemberRegisterInfo { Name = "IsLeapYear", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_IsLeapYear
#endif
                    }},
                    {"Parse_static", new MemberRegisterInfo { Name = "Parse", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_Parse
#endif
                    }},
                    {"ParseExact_static", new MemberRegisterInfo { Name = "ParseExact", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_ParseExact
#endif
                    }},
                    {"TryParse_static", new MemberRegisterInfo { Name = "TryParse", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_TryParse
#endif
                    }},
                    {"TryParseExact_static", new MemberRegisterInfo { Name = "TryParseExact", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = System_DateTime_Wrap.F_TryParseExact
#endif
                    }},
                    {"Now_static", new MemberRegisterInfo { Name = "Now", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_Now
#endif
                    }},
                    {"Today_static", new MemberRegisterInfo { Name = "Today", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_Today
#endif
                    }},
                    {"UtcNow_static", new MemberRegisterInfo { Name = "UtcNow", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_UtcNow
#endif
                    }},
                    {"MinValue_static", new MemberRegisterInfo { Name = "MinValue", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_MinValue
#endif
                    }},
                    {"MaxValue_static", new MemberRegisterInfo { Name = "MaxValue", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_MaxValue
#endif
                    }},
                    {"UnixEpoch_static", new MemberRegisterInfo { Name = "UnixEpoch", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = System_DateTime_Wrap.G_UnixEpoch
#endif
                    }},
                }
            };
        }

        public static void AddRegisterInfoGetterIntoJsEnv(JsEnv jsEnv)
        {
            
                jsEnv.AddRegisterInfoGetter(typeof(Example01), GetRegisterInfo_Example01_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example02), GetRegisterInfo_Example02_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example10), GetRegisterInfo_Example10_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example11), GetRegisterInfo_Example11_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example12), GetRegisterInfo_Example12_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example13), GetRegisterInfo_Example13_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example20), GetRegisterInfo_Example20_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example21), GetRegisterInfo_Example21_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example22), GetRegisterInfo_Example22_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example23), GetRegisterInfo_Example23_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example30), GetRegisterInfo_Example30_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example31), GetRegisterInfo_Example31_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example32), GetRegisterInfo_Example32_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example33), GetRegisterInfo_Example33_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example34), GetRegisterInfo_Example34_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example35), GetRegisterInfo_Example35_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example91), GetRegisterInfo_Example91_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Example92), GetRegisterInfo_Example92_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Application), GetRegisterInfo_UnityEngine_Application_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Debug), GetRegisterInfo_UnityEngine_Debug_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Vector3), GetRegisterInfo_UnityEngine_Vector3_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Quaternion), GetRegisterInfo_UnityEngine_Quaternion_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Bounds), GetRegisterInfo_UnityEngine_Bounds_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Time), GetRegisterInfo_UnityEngine_Time_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Transform), GetRegisterInfo_UnityEngine_Transform_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Component), GetRegisterInfo_UnityEngine_Component_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.GameObject), GetRegisterInfo_UnityEngine_GameObject_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Object), GetRegisterInfo_UnityEngine_Object_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(System.Delegate), GetRegisterInfo_System_Delegate_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(System.Object), GetRegisterInfo_System_Object_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.ParticleSystem), GetRegisterInfo_UnityEngine_ParticleSystem_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Canvas), GetRegisterInfo_UnityEngine_Canvas_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Renderer), GetRegisterInfo_UnityEngine_Renderer_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.SkinnedMeshRenderer), GetRegisterInfo_UnityEngine_SkinnedMeshRenderer_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Input), GetRegisterInfo_UnityEngine_Input_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Random), GetRegisterInfo_UnityEngine_Random_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Behaviour), GetRegisterInfo_UnityEngine_Behaviour_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Networking.UnityWebRequest), GetRegisterInfo_UnityEngine_Networking_UnityWebRequest_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Networking.DownloadHandler), GetRegisterInfo_UnityEngine_Networking_DownloadHandler_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.EventSystems.UIBehaviour), GetRegisterInfo_UnityEngine_EventSystems_UIBehaviour_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Selectable), GetRegisterInfo_UnityEngine_UI_Selectable_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Button), GetRegisterInfo_UnityEngine_UI_Button_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Button.ButtonClickedEvent), GetRegisterInfo_UnityEngine_UI_Button_ButtonClickedEvent_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Events.UnityEvent), GetRegisterInfo_UnityEngine_Events_UnityEvent_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.InputField), GetRegisterInfo_UnityEngine_UI_InputField_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Toggle), GetRegisterInfo_UnityEngine_UI_Toggle_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Toggle.ToggleEvent), GetRegisterInfo_UnityEngine_UI_Toggle_ToggleEvent_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Events.UnityEvent<bool>), GetRegisterInfo_UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Calculator), GetRegisterInfo_Calculator_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(CalculatorExtension), GetRegisterInfo_CalculatorExtension_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(System.DateTime), GetRegisterInfo_System_DateTime_Wrap);
        }
    }
}