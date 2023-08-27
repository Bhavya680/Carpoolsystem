<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Carpoolsystem.WebForm1" %>


  
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">



   
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="username" runat="server" required="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Email ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="EmailID" runat="server" TextMode="Email"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
               
                <tr> 
                    <td></td>
                    <td>
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="message" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
        </div>
 
 

   
</asp:Content>






