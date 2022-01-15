<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="satinAl.aspx.cs" Inherits="E_Ticaret_Proje_Web_Kismi.satinAl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: 37px; font-family: 'Rockwell Condensed';">
        <br />
        <asp:Label ID="Label3" runat="server" Text="MAIL :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" AutoCompleteType="Disabled" TextMode="Email"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="SIFRE : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox>
        </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
