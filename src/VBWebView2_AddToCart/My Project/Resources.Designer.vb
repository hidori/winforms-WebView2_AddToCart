﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはツールによって生成されました。
'     ランタイム バージョン:4.0.30319.42000
'
'     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
'     コードが再生成されるときに損失したりします。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'このクラスは StronglyTypedResourceBuilder クラスが ResGen
    'または Visual Studio のようなツールを使用して自動生成されました。
    'メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    'ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    '''<summary>
    '''  ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("VBWebView2_AddToCart.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        '''  現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        '''  var _timer = setInterval(function () {
        '''    var a = document.querySelector(&apos;span#buybox-see-all-buying-choices a&apos;);
        '''    console.log(`a=${a}`);
        '''
        '''    if (a != null) {
        '''        clearInterval(_timer);
        '''        a.click();
        '''
        '''        _timer = setInterval(function () {
        '''            var _spinner = document.querySelector(&apos;div#all-offers-display-spinner&apos;);
        '''            console.log(`_spinner=${_spinner}`);
        '''
        '''            if (_spinner.className.indexOf(&apos;aok-hidden&apos;) &gt;= 0) {
        '''                clearInterval(_timer);
        '''        ''' [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Friend ReadOnly Property AddToCart() As String
            Get
                Return ResourceManager.GetString("AddToCart", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  https://www.amazon.co.jp/asus-radeon-6800-トリプルファンモデル-tuf-rx6800-o16g-gaming/dp/b082l4dm3k/ref=sr_1_8?__mk_ja_jp=カタカナ&amp;dchild=1&amp;keywords=radeon&amp;qid=1619795500&amp;s=computers&amp;sr=1-8 に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Friend ReadOnly Property Url() As String
            Get
                Return ResourceManager.GetString("Url", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
