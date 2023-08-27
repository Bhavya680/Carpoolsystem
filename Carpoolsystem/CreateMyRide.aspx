<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateMyRide.aspx.cs" Inherits="Carpoolsystem.WebForm2" %>

<html>
<body>
    <form runat="server">

    <h1>Create My Ride</h1>
    <div>
        <label for="userName">User Name:</label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="email">Email:</label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="origin">Origin:</label>
        <asp:Label ID="lblOrigin" runat="server" CssClass="search-textbox"></asp:Label>
    </div>
    <div>
        <label for="destination">Destination:</label>
        <asp:Label ID="lblDestination" runat="server" CssClass="search-textbox"></asp:Label>
    </div>
    <div>
        <label for="departureDate">Departure Date:</label>
        <asp:Label ID="lblDepartureDate" runat="server" CssClass="search-textbox"></asp:Label>
    </div>
    <div>
        <asp:Button ID="btnAdminRide" runat="server" Text="Admin Ride" OnClick="btnAdminRide_Click" CssClass="search-button" />
        <asp:Literal ID="ltlResult" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>