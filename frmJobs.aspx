<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmJobs.aspx.cs" Inherits="frmJobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Maincontent" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" 
            style="font-weight: 700; font-size: large; font-family: Arial" 
            Text="Select Category"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource1" DataTextField="Categ_Name" 
            DataValueField="Categ_Id" Height="48px" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="276px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:kyeyoConnectionString %>" 
            SelectCommand="SELECT * FROM [Categories]"></asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" Height="44px" onclick="Button1_Click" 
            style="font-family: Arial; font-size: large" Text="All Jobs" Width="194px" />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" Height="37px" onclick="Button2_Click" 
            style="font-weight: 700; font-size: medium; font-family: Arial" Text="Post Job" 
            Width="198px" />
    </p>
    <p>
    </p>
    <asp:GridView ID="GridView2" runat="server" CellPadding="4" Font-Size="Medium" 
        ForeColor="#333333" GridLines="None" 
        Width="1032px" 
        onselectedindexchanged="GridView2_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:HyperLinkField HeaderText="ID" DataNavigateUrlFormatString="~/frmViewjob.aspx?id={0}" 
                DataNavigateUrlFields="Job_Id" Text="Details" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" 
            HorizontalAlign="Left" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" Height="80px" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <p>
        <asp:DetailsView ID="DetailsView1" runat="server" BackColor="#DEBA84" 
            BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            CellSpacing="2" Height="50px" style="position: relative; margin-top: 19px" 
            Width="1018px" onpageindexchanging="DetailsView1_PageIndexChanging">
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:ButtonField CommandName="New" Text="Apply" />
            </Fields>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        </asp:DetailsView>
    </p>
    <p>
    </p>
    <p>
        &nbsp;</p>
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

