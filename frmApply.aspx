<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmApply.aspx.cs" Inherits="frmApply" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Maincontent" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label2" runat="server" 
            style="font-weight: 700; font-family: Arial; font-size: large" 
            Text="Proposal Statement(Max 500 Words)"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtstmt" runat="server" Height="127px" MaxLength="500" 
            TextMode="MultiLine" Width="852px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" 
            style="font-size: large; font-weight: 700; font-family: Arial" 
            Text="Expected Amount(UGX)"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtbid" runat="server" style="font-weight: 700" 
            Width="179px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" 
            style="font-size: large; font-family: Arial; color: #000000" Text="Submit" 
            onclick="Button1_Click" />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

