<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoadContact.aspx.cs" Inherits="Klassrumsövning30_Master_Content.WebForm2" %>

<%@ Register Src="~/MyUserControl.ascx" TagPrefix="uc1" TagName="MyUserControl" %>


<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    ADD CONTACT
    <uc1:MyUserControl runat="server" ID="MyUserControl" />

    <asp:Literal ID="myLiteral" runat="server"></asp:Literal>

    <!-- Trigger the modal with a button, located in program string -->

    <!-- Modal -->
    <div id="myModal" class="modal fade" role="dialog">
        <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Add Contact</h4>
                </div>
                <div class="modal-body">
                    <p>First Name</p>
                    <asp:TextBox ID="txtboxFirstName" CssClass="form-control" runat="server"></asp:TextBox>
                    <p>Last Name</p>
                    <asp:TextBox ID="txtboxLastName" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="modal-footer">
                    <button type="submit" class="btn btn-success" data-submit="modal">Add Contact</button>
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
