<%@ Page Title="KAYIT OL" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="kayitOl.aspx.cs" Inherits="E_Ticaret_Proje_Web_Kismi.kayitOl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="styles.css" rel="stylesheet" />
    <p>
        &nbsp;</p>
    <div style="font-family: 'Rockwell Condensed'; text-decoration: underline; font-size: 37px; text-align:center;">
        KAYIT OL<br />
        <asp:Label ID="Label1" runat="server" Text="ISIM : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="SOYISIM :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="MAIL :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" AutoCompleteType="Disabled" TextMode="Email"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="SIFRE : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="KAYIT OL" CssClass="button1" />
    <asp:Label ID="Label5" runat="server" Text="BU MAIL ZATEN KAYITLI" Visible="False" BackColor="Red" Font-Bold="False" Font-Names="Arial" Font-Size="Small"></asp:Label>
    </div>
    <br />
    <br />
</asp:Content>
