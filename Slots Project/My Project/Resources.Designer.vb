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

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Slots_Project.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property AppIcon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("AppIcon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Icon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Icon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property Montserrat_Regular() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Montserrat_Regular", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Would you like to view the Instructions before Starting?.
        '''</summary>
        Friend ReadOnly Property MSG_AskingInstructions() As String
            Get
                Return ResourceManager.GetString("MSG_AskingInstructions", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you Sure you want to quit the Game?.
        '''</summary>
        Friend ReadOnly Property MSG_IsQuitting() As String
            Get
                Return ResourceManager.GetString("MSG_IsQuitting", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You Win!
        '''Would you like to Play this Game Again with the Same Settings?.
        '''</summary>
        Friend ReadOnly Property MSG_IsRestarting() As String
            Get
                Return ResourceManager.GetString("MSG_IsRestarting", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You are Out Of Lives!
        '''Would you Like to Replay this Game?.
        '''</summary>
        Friend ReadOnly Property MSG_OutOfLives() As String
            Get
                Return ResourceManager.GetString("MSG_OutOfLives", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property msgBox_Critical() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("msgBox_Critical", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property msgBox_Info() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("msgBox_Info", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property msgBox_Warning() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("msgBox_Warning", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Based on the Settings you&apos;ve chosen,
        '''a number of Slots will appear with a random set of numbers.
        '''
        '''Your Goal is Simple:
        '''Land a Perfect Match on all slots to win!
        '''Though Be Sure not to Run out of Lives, Or You Lose!
        '''
        '''
        '''When you are Ready, Click OK to Start with Current Settings..
        '''</summary>
        Friend ReadOnly Property MSGInstructions() As String
            Get
                Return ResourceManager.GetString("MSGInstructions", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You have Won 0 Times Last Time You Played!
        '''Try and Beat That!.
        '''</summary>
        Friend ReadOnly Property MSGLastWins() As String
            Get
                Return ResourceManager.GetString("MSGLastWins", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Slots: Ready to Begin?.
        '''</summary>
        Friend ReadOnly Property Title_AskingInstructions() As String
            Get
                Return ResourceManager.GetString("Title_AskingInstructions", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Instructions: How to Play!.
        '''</summary>
        Friend ReadOnly Property Title_Instructions() As String
            Get
                Return ResourceManager.GetString("Title_Instructions", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Slots: Quit Game?.
        '''</summary>
        Friend ReadOnly Property Title_IsQuitting() As String
            Get
                Return ResourceManager.GetString("Title_IsQuitting", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Slots: Restart Game?.
        '''</summary>
        Friend ReadOnly Property Title_IsRestarting() As String
            Get
                Return ResourceManager.GetString("Title_IsRestarting", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Slots: Out Of Lives!.
        '''</summary>
        Friend ReadOnly Property Title_OutOfLives() As String
            Get
                Return ResourceManager.GetString("Title_OutOfLives", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
