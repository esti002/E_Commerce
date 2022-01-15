<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="urunDetay.aspx.cs" Inherits="E_Ticaret_Proje_Web_Kismi.urunDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles.css" rel="stylesheet" />
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
            <br /><br />
            <br />
        </ItemTemplate>
    </asp:DataList>
        </div>
    <div style="background-color: #CCFFFF; border-style: dashed; font-family: Rockwell; font-size: medium">
        YORUMLAR<br />
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
        <br />
        <br />
        YORUM YAP<br />
        <asp:Label ID="Label11" runat="server" Text="MAIL: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Disabled" TextMode="Email"></asp:TextBox>
        <br />
        <asp:Label ID="Label12" runat="server" Text="SIFRE: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="Label13" runat="server" Text="YORUM: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Height="150px" Width="428px" EnableTheming="True" MaxLength="200" TextMode="MultiLine" AutoCompleteType="Disabled"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="YORUM YAP" CssClass="button1" OnClick="Button1_Click" />
        <asp:Label ID="Label14" runat="server" BackColor="Red" Text="MAIL YA DA SIFRENIZ HATALI" Visible="False"></asp:Label>
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
