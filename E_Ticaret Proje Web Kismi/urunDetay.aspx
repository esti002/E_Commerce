<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="urunDetay.aspx.cs" Inherits="E_Ticaret_Proje_Web_Kismi.urunDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Img") %>' Width="500px" />
    <div style="border-style: dashed; background-color: #CCFFFF; font-family: rockwell;">
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
            TL<br />
            <asp:Label ID="Label4" runat="server" Text='<%# Eval("Add_Date") %>' Font-Italic="True"></asp:Label>
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
        </div>
    <div style="background-color: #CCFFFF; border-style: dashed; font-family: Rockwell; font-size: medium">
    YORUMLAR:<br />
    <asp:DataList ID="DataList3" runat="server">
        <ItemTemplate>
            <br />
            <asp:Label ID="Label8" runat="server" Text='<%# Eval("Reviewer") %>' Font-Underline="True"></asp:Label>
            <br />
            <asp:Label ID="Label9" runat="server" Text='<%# Eval("Review") %>'></asp:Label>
            <br />
            <asp:Label ID="Label10" runat="server" Text='<%# Eval("Review_Date") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
