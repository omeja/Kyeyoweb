<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmRegister.aspx.cs" Inherits="frmRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Maincontent" Runat="Server">
    <p>
    <br />
</p>
<p>
    <asp:Label ID="Label2" runat="server" 
        style="font-weight: bold; font-family: Arial" Text="User Name"></asp:Label>
</p>
<p>
    <asp:TextBox ID="TextBox1" runat="server" MaxLength="10" Width="248px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: bold; font-family: Arial" Text="Password"></asp:Label>
</p>
<p>
    <asp:TextBox ID="TextBox2" runat="server" MaxLength="20" 
        ontextchanged="TextBox2_TextChanged" TextMode="Password" Width="251px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label4" runat="server" 
        style="font-weight: bold; font-family: Arial" Text="Email Address"></asp:Label>
</p>
<p>
    <asp:TextBox ID="TextBox3" runat="server" MaxLength="30" Width="249px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label5" runat="server" 
        style="font-weight: bold; font-family: Arial" Text="Phone Contact"></asp:Label>
</p>
<p>
    <asp:TextBox ID="TextBox4" runat="server" MaxLength="10" Width="251px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Height="40px" onclick="Button1_Click" 
        style="font-family: Arial; font-weight: 700; font-size: medium" Text="Save" 
        Width="160px" />
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>

