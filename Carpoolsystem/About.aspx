<%@ Page Title="C#" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Carpoolsystem.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        /* CSS for the search container */
.search-container {
    display: flex;
    align-items: center;
    justify-content: space-between;
    margin-top: 20px;
    padding: 20px;
    background-color: #f3f3f3;
    border-radius: 8px;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

/* CSS for the search textboxes */
.search-textbox {
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 4px;
    width: 150px;
    margin-right: 10px;
}

/* CSS for the search button */
.search-button {
    padding: 10px 20px;
    background-color: #007bff;
    border: none;
    color: #fff;
    border-radius: 4px;
    cursor: pointer;
    transition: background-color 0.3s ease-in-out;
}

.search-button:hover {
    background-color: #0056b3;
}

/* CSS for the search dropdown */
.search-dropdown {
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 4px;
    background-color: #fff;
    color: #333;
    width: 150px;
    cursor: pointer;
    display:none;
}

.search-dropdown option:first-child {
    color: #888;
}

    
        /* ... (your existing CSS styles) ... */
        
        /* CSS for the new box design */
        .search-result-box {
            margin-top: 20px;
            padding: 20px;
            background-color: inherit;
            border-radius: 8px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            display: absolute;
            width:180px;
            height:150px;
        }
.not{
   
    color:red;
}
    </style>
    <div class="search-container">
        <div class="search-inputs">
            <label for="origin">Location:</label>
            <asp:TextBox ID="txtOrigin" runat="server" CssClass="search-textbox" />
            <label for="destination">Destination:</label>
            <asp:TextBox ID="txtDestination" runat="server" CssClass="search-textbox" />
            <br /><label for="departureTime">Departure Time:</label>
            <asp:Calendar Text="Calendar" ID="calDepartureTime" runat="server" CssClass="search-calendar" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt"></DayHeaderStyle>

                <DayStyle Width="14%"></DayStyle>

                <NextPrevStyle Font-Size="8pt" ForeColor="White"></NextPrevStyle>

                <OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>

                <SelectedDayStyle BackColor="#CC3333" ForeColor="White"></SelectedDayStyle>

                <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%"></SelectorStyle>

                <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt"></TitleStyle>

                <TodayDayStyle BackColor="#CCCC99"></TodayDayStyle>
            </asp:Calendar>
        </div>
        <div class="search-buttons">
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" CssClass="search-button" />
            <div class="search-result-box" id="divSearchResultBox" runat="server">
             <asp:Button ID="btnCreateRide" runat="server" Text="Create My Ride" OnClick="btnCreateRide_Click" CssClass="search-button" />
             <asp:Label ID="lblNotAvailable" runat="server" Text="Not Available" Visible="True" class="not" ></asp:Label>
            </div>
        </div>
    </div>
      <script type="text/javascript">
        window.onload = function () {
            var divSearchResultBox = document.getElementById('<%= divSearchResultBox.ClientID %>');
            var lblNotAvailable = document.getElementById('<%= lblNotAvailable.ClientID %>');
            divSearchResultBox.style.display = 'relative';
            lblNotAvailable.style.display = 'block';
        };
      </script>

</asp:Content>
