<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="anaSayfa.aspx.cs" Inherits="E_Ticaret_Proje_Web_Kismi.anaSayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="5" Height="276px" Width="1238px" HorizontalAlign="Center" >
        <ItemStyle HorizontalAlign="Center" />
        <ItemTemplate >
            <a href="urunDetay.aspx?productId=<%#Eval("Product_ID") %>" style="text-decoration:none; ">
            <div style="border-style:dashed; border-width:2px; width:auto; height:auto; background-color:#99FF99; text-decoration:none; font-family: Rockwell; font-size: medium; color: #000000; border-radius: 10px; ">
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
