﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SmartphoneManager
{
    public partial class App : global::Microsoft.UI.Xaml.Markup.IXamlMetadataProvider
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        private global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlMetaDataProvider __appProvider;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlMetaDataProvider _AppProvider
        {
            get
            {
                if (__appProvider == null)
                {
                    __appProvider = new global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlMetaDataProvider();
                }
                return __appProvider;
            }
        }

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            return _AppProvider.GetXamlType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            return _AppProvider.GetXamlType(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return _AppProvider.GetXmlnsDefinitions();
        }
    }
}

namespace SmartphoneManager.SmartphoneManager_XamlTypeInfo
{
    /// <summary>
    /// Main class for providing metadata for the app or library
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class XamlMetaDataProvider : global::Microsoft.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlTypeInfoProvider _provider = null;

        private global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlTypeInfoProvider Provider
        {
            get
            {
                if (_provider == null)
                {
                    _provider = new global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlTypeInfoProvider();
                }
                return _provider;
            }
        }

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        [global::Windows.Foundation.Metadata.DefaultOverload]
        public global::Microsoft.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            return Provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Microsoft.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            return Provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Microsoft.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Microsoft.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Microsoft.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Microsoft.UI.Xaml.Markup.IXamlType xamlType;
            lock (_xamlTypeCacheByType) 
            { 
                if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
                {
                    return xamlType;
                }
                int typeIndex = LookupTypeIndexByType(type);
                if(typeIndex != -1)
                {
                    xamlType = CreateXamlType(typeIndex);
                }
                var userXamlType = xamlType as global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlUserType;
                if(xamlType == null || (userXamlType != null && userXamlType.IsReturnTypeStub && !userXamlType.IsLocalType))
                {
                    global::Microsoft.UI.Xaml.Markup.IXamlType libXamlType = CheckOtherMetadataProvidersForType(type);
                    if (libXamlType != null)
                    {
                        if(libXamlType.IsConstructible || xamlType == null)
                        {
                            xamlType = libXamlType;
                        }
                    }
                }
                if (xamlType != null)
                {
                    _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                    _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
                }
            }
            return xamlType;
        }

        public global::Microsoft.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Microsoft.UI.Xaml.Markup.IXamlType xamlType;
            lock (_xamlTypeCacheByType)
            {
                if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
                {
                    return xamlType;
                }
                int typeIndex = LookupTypeIndexByName(typeName);
                if(typeIndex != -1)
                {
                    xamlType = CreateXamlType(typeIndex);
                }
                var userXamlType = xamlType as global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlUserType;
                if(xamlType == null || (userXamlType != null && userXamlType.IsReturnTypeStub && !userXamlType.IsLocalType))
                {
                    global::Microsoft.UI.Xaml.Markup.IXamlType libXamlType = CheckOtherMetadataProvidersForName(typeName);
                    if (libXamlType != null)
                    {
                        if(libXamlType.IsConstructible || xamlType == null)
                        {
                            xamlType = libXamlType;
                        }
                    }
                }
                if (xamlType != null)
                {
                    _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                    _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
                }
            }
            return xamlType;
        }

        public global::Microsoft.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Microsoft.UI.Xaml.Markup.IXamlMember xamlMember;
            lock (_xamlMembers)
            {
                if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
                {
                    return xamlMember;
                }
                xamlMember = CreateXamlMember(longMemberName);
                if (xamlMember != null)
                {
                    _xamlMembers.Add(longMemberName, xamlMember);
                }
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Microsoft.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Microsoft.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Microsoft.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Microsoft.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Microsoft.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Microsoft.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[9];
            _typeNameTable[0] = "Microsoft.UI.Xaml.Controls.XamlControlsResources";
            _typeNameTable[1] = "Microsoft.UI.Xaml.ResourceDictionary";
            _typeNameTable[2] = "Object";
            _typeNameTable[3] = "Boolean";
            _typeNameTable[4] = "SmartphoneManager.MainWindow";
            _typeNameTable[5] = "Microsoft.UI.Xaml.Window";
            _typeNameTable[6] = "SmartphoneManager.Pages.WelcomePage";
            _typeNameTable[7] = "Microsoft.UI.Xaml.Controls.Page";
            _typeNameTable[8] = "Microsoft.UI.Xaml.Controls.UserControl";

            _typeTable = new global::System.Type[9];
            _typeTable[0] = typeof(global::Microsoft.UI.Xaml.Controls.XamlControlsResources);
            _typeTable[1] = typeof(global::Microsoft.UI.Xaml.ResourceDictionary);
            _typeTable[2] = typeof(global::System.Object);
            _typeTable[3] = typeof(global::System.Boolean);
            _typeTable[4] = typeof(global::SmartphoneManager.MainWindow);
            _typeTable[5] = typeof(global::Microsoft.UI.Xaml.Window);
            _typeTable[6] = typeof(global::SmartphoneManager.Pages.WelcomePage);
            _typeTable[7] = typeof(global::Microsoft.UI.Xaml.Controls.Page);
            _typeTable[8] = typeof(global::Microsoft.UI.Xaml.Controls.UserControl);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_XamlControlsResources() { return new global::Microsoft.UI.Xaml.Controls.XamlControlsResources(); }
        private object Activate_4_MainWindow() { return new global::SmartphoneManager.MainWindow(); }
        private object Activate_6_WelcomePage() { return new global::SmartphoneManager.Pages.WelcomePage(); }
        private void MapAdd_0_XamlControlsResources(object instance, object key, object item)
        {
            var collection = (global::System.Collections.Generic.IDictionary<global::System.Object, global::System.Object>)instance;
            var newKey = (global::System.Object)key;
            var newItem = (global::System.Object)item;
            collection.Add(newKey, newItem);
        }

        private global::Microsoft.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  Microsoft.UI.Xaml.Controls.XamlControlsResources
                userType = new global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Microsoft.UI.Xaml.ResourceDictionary"));
                userType.Activator = Activate_0_XamlControlsResources;
                userType.DictionaryAdd = MapAdd_0_XamlControlsResources;
                userType.AddMemberName("UseCompactResources");
                xamlType = userType;
                break;

            case 1:   //  Microsoft.UI.Xaml.ResourceDictionary
                xamlType = new global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Object
                xamlType = new global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  Boolean
                xamlType = new global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 4:   //  SmartphoneManager.MainWindow
                userType = new global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Window"));
                userType.Activator = Activate_4_MainWindow;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  Microsoft.UI.Xaml.Window
                xamlType = new global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  SmartphoneManager.Pages.WelcomePage
                userType = new global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_6_WelcomePage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  Microsoft.UI.Xaml.Controls.Page
                xamlType = new global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  Microsoft.UI.Xaml.Controls.UserControl
                xamlType = new global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }

        private global::System.Collections.Generic.List<global::Microsoft.UI.Xaml.Markup.IXamlMetadataProvider> _otherProviders;
        private global::System.Collections.Generic.List<global::Microsoft.UI.Xaml.Markup.IXamlMetadataProvider> OtherProviders
        {
            get
            {
                if(_otherProviders == null)
                {
                    var otherProviders = new global::System.Collections.Generic.List<global::Microsoft.UI.Xaml.Markup.IXamlMetadataProvider>();
                    global::Microsoft.UI.Xaml.Markup.IXamlMetadataProvider provider;
                    provider = new global::Microsoft.UI.Xaml.XamlTypeInfo.XamlControlsXamlMetaDataProvider() as global::Microsoft.UI.Xaml.Markup.IXamlMetadataProvider;
                    otherProviders.Add(provider); 
                    _otherProviders = otherProviders;
                }
                return _otherProviders;
            }
        }

        private global::Microsoft.UI.Xaml.Markup.IXamlType CheckOtherMetadataProvidersForName(string typeName)
        {
            global::Microsoft.UI.Xaml.Markup.IXamlType xamlType = null;
            global::Microsoft.UI.Xaml.Markup.IXamlType foundXamlType = null;
            foreach(global::Microsoft.UI.Xaml.Markup.IXamlMetadataProvider xmp in OtherProviders)
            {
                xamlType = xmp.GetXamlType(typeName);
                if(xamlType != null)
                {
                    if(xamlType.IsConstructible)    // not Constructible means it might be a Return Type Stub
                    {
                        return xamlType;
                    }
                    foundXamlType = xamlType;
                }
            }
            return foundXamlType;
        }

        private global::Microsoft.UI.Xaml.Markup.IXamlType CheckOtherMetadataProvidersForType(global::System.Type type)
        {
            global::Microsoft.UI.Xaml.Markup.IXamlType xamlType = null;
            global::Microsoft.UI.Xaml.Markup.IXamlType foundXamlType = null;
            foreach(global::Microsoft.UI.Xaml.Markup.IXamlMetadataProvider xmp in OtherProviders)
            {
                xamlType = xmp.GetXamlType(type);
                if(xamlType != null)
                {
                    if(xamlType.IsConstructible)    // not Constructible means it might be a Return Type Stub
                    {
                        return xamlType;
                    }
                    foundXamlType = xamlType;
                }
            }
            return foundXamlType;
        }

        private object get_0_XamlControlsResources_UseCompactResources(object instance)
        {
            var that = (global::Microsoft.UI.Xaml.Controls.XamlControlsResources)instance;
            return that.UseCompactResources;
        }
        private void set_0_XamlControlsResources_UseCompactResources(object instance, object Value)
        {
            var that = (global::Microsoft.UI.Xaml.Controls.XamlControlsResources)instance;
            that.UseCompactResources = (global::System.Boolean)Value;
        }

        private global::Microsoft.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlMember xamlMember = null;
            global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Microsoft.UI.Xaml.Controls.XamlControlsResources.UseCompactResources":
                userType = (global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.XamlControlsResources");
                xamlMember = new global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlMember(this, "UseCompactResources", "Boolean");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_0_XamlControlsResources_UseCompactResources;
                xamlMember.Setter = set_0_XamlControlsResources_UseCompactResources;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Microsoft.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Microsoft.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Microsoft.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Microsoft.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Microsoft.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Microsoft.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Microsoft.UI.Xaml.Markup.IXamlType BoxedType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);
    internal delegate object CreateFromStringMethod(string args);
    internal delegate object BoxInstanceMethod(object instance);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlSystemBaseType
        , global::Microsoft.UI.Xaml.Markup.IXamlType
    {
        global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Microsoft.UI.Xaml.Markup.IXamlType _baseType;
        global::Microsoft.UI.Xaml.Markup.IXamlType _boxedType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Microsoft.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Microsoft.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }
        override public global::Microsoft.UI.Xaml.Markup.IXamlType BoxedType { get { return _boxedType; } }

        override public global::Microsoft.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Microsoft.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Microsoft.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Microsoft.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            global::System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (BoxedType != null)
            {
                return BoxInstance(BoxedType.CreateFromString(input));
            }

            if (CreateFromStringMethod != null)
            {
                return this.CreateFromStringMethod(input);
            }
            else if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }
        public CreateFromStringMethod CreateFromStringMethod {get; set; }
        public BoxInstanceMethod BoxInstance {get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void SetBoxedType(global::Microsoft.UI.Xaml.Markup.IXamlType boxedType)
        {
            _boxedType = boxedType;
        }

        public object BoxType<T>(object instance) where T: struct
        {
            T unwrapped = (T)instance;
            return new global::System.Nullable<T>(unwrapped);
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Microsoft.UI.Xaml.Markup.IXamlMember
    {
        global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::SmartphoneManager.SmartphoneManager_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Microsoft.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Microsoft.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

