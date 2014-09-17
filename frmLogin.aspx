<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="frmLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Maincontent" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" 
            style="font-weight: bold; font-family: Arial" Text="User"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" MaxLength="20" Width="158px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" 
            style="font-weight: bold; font-family: Arial" Text="Password"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server" MaxLength="10" Width="160px" 
            TextMode="Password"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="font-weight: 700; color: #FF3300"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Height="30px" 
            style="font-weight: 700; font-family: Arial; font-size: medium" Text="Login" 
            Width="96px" onclick="Button1_Click" />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

