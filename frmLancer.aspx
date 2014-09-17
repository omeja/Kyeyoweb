<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmLancer.aspx.cs" Inherits="frmLancer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Maincontent" Runat="Server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" 
            style="font-weight: bold; font-family: Arial" Text="First Name"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtfname" runat="server" Width="298px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" 
            style="font-weight: bold; font-family: Arial" Text="Last Name"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtlname" runat="server" Width="295px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" 
            style="font-weight: bold; font-family: Arial" Text="Email Address"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtemail" runat="server" Width="292px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" 
            style="font-weight: 700; font-family: Arial" Text="Password"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtpass" runat="server" TextMode="Password" Width="286px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" 
            style="font-weight: bold; font-family: Arial" Text="Telephone"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtphone" runat="server" Width="289px"></asp:TextBox>
    </p>
    <p>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            style="font-weight: bold; font-size: x-large" Text="Submit" />
    </p>
</asp:Content>

