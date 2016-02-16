<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateContact.aspx.cs" Inherits="Klassrumsövning30_Master_Content.WebForm3" %>

<%@ Register Src="~/MyUserControl.ascx" TagPrefix="uc1" TagName="MyUserControl" %>


<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    UPDATE CONTACT
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
                    <h4 class="modal-title">Update Contact</h4>
                </div>
                <div class="modal-body">
                    <p>Choose Contact ID</p>
                    <asp:TextBox ID="contactId" runat="server"></asp:TextBox>
                    <p>Edit First Name</p>
                    <asp:TextBox ID="txtboxFirstName" runat="server"></asp:TextBox>
                    <p>Edit Last Name</p>
                    <asp:TextBox ID="txtboxLastName" runat="server"></asp:TextBox>
                </div>
                <div class="modal-footer">
                    <button type="submit" class="btn btn-warning" data-submit="modal">Update</button>
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
