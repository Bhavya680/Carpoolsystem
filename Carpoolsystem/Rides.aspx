<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rides.aspx.cs" Inherits="Carpoolsystem.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h1>Add New Ride</h1>
    <div>
        <label for="origin">Origin:</label>
        <asp:TextBox ID="Origin" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="destination">Destination:</label>
        <asp:TextBox ID="Destination" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="departureTime">Departure Time:</label>
        <asp:TextBox ID="DepartureTime" runat="server"></asp:TextBox>
        <asp:Calendar ID="calDepartureTime" runat="server" OnSelectionChanged="calDepartureTime_SelectionChanged" Visible="false"></asp:Calendar>
    </div>
    <asp:Button ID="btnAddRide" runat="server" Text="Add Ride" OnClick="btnAddRide_Click" />
    <asp:Literal ID="ltlResult" runat="server"></asp:Literal>

    </form>
</body>
</html>
