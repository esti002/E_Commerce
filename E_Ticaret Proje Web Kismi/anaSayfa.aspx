<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="anaSayfa.aspx.cs" Inherits="E_Ticaret_Proje_Web_Kismi.anaSayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <a href="urunDetay.aspx?productId=<%#Eval("Product_ID") %>">
            <div style="width:auto; height:100px; background-color:red;">
                &nbsp;URUN:
            <asp:Label ID="Label2" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                <br />
                <br />
                FIYATI:
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
            </div>
            </a>
        </ItemTemplate>
    </asp:DataList>

</asp:Content>
