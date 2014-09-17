<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmClient.aspx.cs" Inherits="frmClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Maincontent" Runat="Server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" 
            style="font-weight: bold; font-family: Arial" Text="First Name"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtfname" runat="server" Width="253px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" 
            style="font-weight: bold; font-family: Arial" Text="Last Name"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtlname" runat="server" Width="252px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" 
            style="font-weight: bold; font-family: Arial" Text="Email Address"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtemail" runat="server" Width="247px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" 
            style="font-weight: 700; font-family: Arial" Text="Password"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtpass" runat="server" MaxLength="8" TextMode="Password" 
            Width="244px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" 
            style="font-weight: bold; font-family: Arial" Text="Telephone Number"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtphone" runat="server" Width="247px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            style="font-size: x-large; font-weight: 700" Text="Submit" Width="116px" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

