﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.12.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TemplateLocation() As String
            Get
                Return CType(Me("TemplateLocation"),String)
            End Get
            Set
                Me("TemplateLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CLIInstallLocation() As String
            Get
                Return CType(Me("CLIInstallLocation"),String)
            End Get
            Set
                Me("CLIInstallLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("images-background2md.txt")>  _
        Public Property Setting_Background() As String
            Get
                Return CType(Me("Setting_Background"),String)
            End Get
            Set
                Me("Setting_Background") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("monster2md-yamlStatblock-body.txt")>  _
        Public Property Setting_Monster() As String
            Get
                Return CType(Me("Setting_Monster"),String)
            End Get
            Set
                Me("Setting_Monster") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("images-item2md.txt")>  _
        Public Property Setting_Item() As String
            Get
                Return CType(Me("Setting_Item"),String)
            End Get
            Set
                Me("Setting_Item") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("images-race2md.txt")>  _
        Public Property Setting_Race() As String
            Get
                Return CType(Me("Setting_Race"),String)
            End Get
            Set
                Me("Setting_Race") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("images-spell2md.txt")>  _
        Public Property Setting_Spell() As String
            Get
                Return CType(Me("Setting_Spell"),String)
            End Get
            Set
                Me("Setting_Spell") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("test")>  _
        Public Property Setting_Compendium() As String
            Get
                Return CType(Me("Setting_Compendium"),String)
            End Get
            Set
                Me("Setting_Compendium") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("test")>  _
        Public Property Setting_Rules() As String
            Get
                Return CType(Me("Setting_Rules"),String)
            End Get
            Set
                Me("Setting_Rules") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("MM")>  _
        Public Property Setting_From() As String
            Get
                Return CType(Me("Setting_From"),String)
            End Get
            Set
                Me("Setting_From") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("LMoP")>  _
        Public Property Setting_Adventure() As String
            Get
                Return CType(Me("Setting_Adventure"),String)
            End Get
            Set
                Me("Setting_Adventure") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("xPHB,"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"xDMG,"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"xMM,")>  _
        Public Property Setting_Book() As String
            Get
                Return CType(Me("Setting_Book"),String)
            End Get
            Set
                Me("Setting_Book") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("My.Config.File.json")>  _
        Public Property Setting_JSON() As String
            Get
                Return CType(Me("Setting_JSON"),String)
            End Get
            Set
                Me("Setting_JSON") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Setting_Config() As String
            Get
                Return CType(Me("Setting_Config"),String)
            End Get
            Set
                Me("Setting_Config") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Setting_DataFolder() As String
            Get
                Return CType(Me("Setting_DataFolder"),String)
            End Get
            Set
                Me("Setting_DataFolder") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Setting_RelativeTemplatePath() As String
            Get
                Return CType(Me("Setting_RelativeTemplatePath"),String)
            End Get
            Set
                Me("Setting_RelativeTemplatePath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Setting_ImageFolder() As String
            Get
                Return CType(Me("Setting_ImageFolder"),String)
            End Get
            Set
                Me("Setting_ImageFolder") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Setting_DataFolder_Full() As String
            Get
                Return CType(Me("Setting_DataFolder_Full"),String)
            End Get
            Set
                Me("Setting_DataFolder_Full") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Setting_Homebrew_Folder() As String
            Get
                Return CType(Me("Setting_Homebrew_Folder"),String)
            End Get
            Set
                Me("Setting_Homebrew_Folder") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Setting_Homebrew() As String
            Get
                Return CType(Me("Setting_Homebrew"),String)
            End Get
            Set
                Me("Setting_Homebrew") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Setting_InstallTemplateLocation() As String
            Get
                Return CType(Me("Setting_InstallTemplateLocation"),String)
            End Get
            Set
                Me("Setting_InstallTemplateLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Setting_Use_FantasyStat() As Boolean
            Get
                Return CType(Me("Setting_Use_FantasyStat"),Boolean)
            End Get
            Set
                Me("Setting_Use_FantasyStat") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Setting_Use_DiceRoller() As Boolean
            Get
                Return CType(Me("Setting_Use_DiceRoller"),Boolean)
            End Get
            Set
                Me("Setting_Use_DiceRoller") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Setting_Copy_ExternalImages() As Boolean
            Get
                Return CType(Me("Setting_Copy_ExternalImages"),Boolean)
            End Get
            Set
                Me("Setting_Copy_ExternalImages") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Setting_Copy_InternalImages() As Boolean
            Get
                Return CType(Me("Setting_Copy_InternalImages"),Boolean)
            End Get
            Set
                Me("Setting_Copy_InternalImages") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Setting_Reference() As String
            Get
                Return CType(Me("Setting_Reference"),String)
            End Get
            Set
                Me("Setting_Reference") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("newest")>  _
        Public Property Setting_ReprintBehaviour() As String
            Get
                Return CType(Me("Setting_ReprintBehaviour"),String)
            End Get
            Set
                Me("Setting_ReprintBehaviour") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.TTRPG_CLI_UI_Project.My.MySettings
            Get
                Return Global.TTRPG_CLI_UI_Project.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
