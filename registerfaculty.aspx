<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="registerfaculty.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <asp:Label ID="Label1" runat="server" Text="Faculty ID"></asp:Label>
&nbsp;<asp:TextBox ID="facultyid" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="label2" runat="server" Text="Password"></asp:Label>
&nbsp;<asp:TextBox ID="Password" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="FacultyName" runat="server" Text="Faculty Name"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
        <asp:ListItem>Others</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Phone Number"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Address"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Department"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label9" runat="server" Text="Designation"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />

</asp:Content>

