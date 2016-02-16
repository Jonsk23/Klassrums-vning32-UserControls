<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteContact.aspx.cs" Inherits="Klassrumsövning30_Master_Content.WebForm4" %>

<%@ Register Src="~/MyUserControl.ascx" TagPrefix="uc1" TagName="MyUserControl" %>


<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    DELETE CONTACT
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
                    <h4 class="modal-title">Delete Contact</h4>
                </div>
                <div class="modal-body">
                    <p>Contact ID</p>
                    <asp:TextBox ID="inputId" runat="server"></asp:TextBox>
                </div>
                <div class="modal-footer">
                    <button type="submit" class="btn btn-danger" data-submit="modal">Delete Contact</button>
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
