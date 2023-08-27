<%@ Page Title="Admin Ride" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminRide.aspx.cs" Inherits="Carpoolsystem.AdminRide" %>


<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Admin Ride</h1>
    <div class="card">
        <div class="card-body">
            <h5 class="card-title">Your Ride</h5>
            <div class="ride-details">
                <p class="card-text"><strong>Origin:</strong> <%= Session["RideOrigin"] %></p>
                <p class="card-text"><strong>Destination:</strong> <%= Session["RideDestination"] %></p>
                <p class="card-text"><strong>User Name:</strong> <%= Session["RideUserName"] %></p>
                <p class="card-text"><strong>Email:</strong> <%= Session["RideEmail"] %></p>
                <p class="card-text"><strong>Departure Time:</strong> <%= ((DateTime)Session["RideDepartureDate"]).ToString("yyyy-MM-dd HH:mm") %></p>
            </div>
        </div>
    </div>
</asp:Content>

