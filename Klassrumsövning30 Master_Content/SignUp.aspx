<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Klassrumsövning30_Master_Content.WebForm5" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">

    <form class="form-inline" role="form">
        <div class="form-group">
            <label for="email">Email address:</label>
            <input type="email" class="form-control" id="email" />
        </div>
        <div class="form-group">
            <label for="pwd">Password:</label>
            <input type="password" class="form-control" id="pwd" />
        </div>
        <div class="checkbox">
            <label>
                <input type="checkbox" />
                Remember me</label>
        </div>
        <button type="submit" class="btn btn-primary">Submit</button>
    </form>

</asp:Content>
