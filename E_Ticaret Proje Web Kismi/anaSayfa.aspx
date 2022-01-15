<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="anaSayfa.aspx.cs" Inherits="E_Ticaret_Proje_Web_Kismi.anaSayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    ARA:
    <asp:TextBox ID="TextBox3" runat="server" CssClass="search" Width="654px" AutoCompleteType="Disabled"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ARA" CssClass="button1" />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="FILTRELE" Font-Bold="True" Font-Size="Large"></asp:Label>
&nbsp;<br />
    <br />
    KATEGORI SEC :&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Category_ID">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShoppingConnectionString %>" SelectCommand="SELECT [Category ID] AS Category_ID, [Name] FROM [CategoriesTable]"></asp:SqlDataSource>
    <br />
    <br />
    FIYAT ARALIGI SEC:&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; -&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="FILTRELERI UYGULA" CssClass="button1" OnClick="Button1_Click" />
    <br />
&nbsp;<asp:DataList ID="DataList1" runat="server" RepeatColumns="5" Height="276px" Width="1238px" HorizontalAlign="Center" >
        <ItemStyle HorizontalAlign="Center" />
        <ItemTemplate >
            <a href="urunDetay.aspx?productId=<%#Eval("Product_ID") %>" style="text-decoration:none; ">
            <div style="border-style:dashed; border-width:2px; width:auto; height:auto; background-color:#CC99FF; text-decoration:none; font-family: Rockwell; font-size: medium; color: #000000; border-radius: 10px; ">
                <asp:Image ID="Image1" runat="server" Height="189px" ImageUrl='<%# Eval("Img") %>' Width="255px"/>
                <br />
                <br />
                URUN:
            <asp:Label ID="Label2" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                <br />
                <br />
                FIYATI:
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
                TL</div>
            </a>
        </ItemTemplate>
        <SeparatorStyle HorizontalAlign="Right" />
    </asp:DataList>

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>
