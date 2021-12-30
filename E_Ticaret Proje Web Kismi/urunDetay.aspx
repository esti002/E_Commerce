<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="urunDetay.aspx.cs" Inherits="E_Ticaret_Proje_Web_Kismi.urunDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            URUN:<br />
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
            <br />
            <br />
            <br />
            OZELLIKLERI:<br />
            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Properties") %>'></asp:Label>
            <br />
            <br />
            FIYATI:&nbsp;
            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
            <br />
            URUNUN EKLENME TARIHI:&nbsp;
            <asp:Label ID="Label4" runat="server" Text='<%# Eval("Add_Date") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
