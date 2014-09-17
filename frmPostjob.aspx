<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmPostjob.aspx.cs" Inherits="Postjob" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Maincontent" Runat="Server">
    <p>
    <br />
    <asp:Label ID="Label1" runat="server" 
        style="font-family: Arial; font-weight: bold" Text="Select Category"></asp:Label>
</p>
<p>
    <asp:DropDownList ID="cbocategory" runat="server" Height="21px" Width="269px" 
        DataSourceID="SqlDataSource3" DataTextField="Categ_Name" 
        DataValueField="Categ_Id" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
        ConnectionString="<%$ ConnectionStrings:kyeyoConnectionString %>" 
        SelectCommand="SELECT [Categ_Id], [Categ_Name] FROM [Categories]"></asp:SqlDataSource>
</p>
<p>
    <asp:Label ID="Label5" runat="server" 
        style="font-family: Arial; font-weight: bold" Text="Job Title"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txttitle" runat="server" Height="32px" MaxLength="100" 
        Width="825px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label6" runat="server" 
        style="font-family: Arial; font-weight: bold" Text="Job Details"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtdetails" runat="server" Height="46px" MaxLength="5000" 
        Width="830px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label7" runat="server" 
        style="font-family: Arial; font-weight: bold" Text="Budget(UGX)"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtbudget" runat="server" Width="264px"></asp:TextBox>
</p>
<p style="font-family: Arial; font-weight: 700">
    Deadline(Expected Starting Date)</p>
<p style="font-family: Arial; font-weight: 700">
    <asp:TextBox ID="txtdt" runat="server" Width="266px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Height="49px" 
        style="font-weight: 700; font-size: x-large" Text="Submit" Width="151px" 
        onclick="Button1_Click" />
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>

