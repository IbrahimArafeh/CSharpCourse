<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StackSystemExample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width:500px; border:1px solid black">
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMessage" runat="server" ForColor="Red">
                </asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width:100px">
                <table style="width:100px; border:1px solid black; font-family:Arial">
                    <tr>
                        <td>
                            Links
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="WebForm1.aspx">WebForm1</a>
                        </td>
                    <tr>
                        <td>
                            <a href="WebForm2.aspx">WebForm2</a>
                        </td>
                    <tr>
                        <td>
                            <a href="WebForm3.aspx">WebForm3</a>
                        </td>s
                    <tr>
                        <td>
                            <a href="WebForm4.aspx">WebForm4</a>
                        </td>
                    </tr>
                </table>
            </td>

            <td style="width:400px;">
                <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
                <asp:ContentPlaceHolder ID="ContentPlaceHolder1" runat="server">

                </asp:ContentPlaceHolder>
            </td>
        </tr>
    </table>

</asp:Content>
