<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QueueSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <table style="font-family:Arial;border:1px solid black;text-align:center">
      <tr>
          <td>Counter 1</td>
          <td></td>
          <td>Counter 2</td>
          <td></td>
          <td>Counter 3</td>
          <td></td>
      </tr>

      <tr>
          <td>
              <asp:TextBox ID="textCounter1" runat="server" BackColor="#3399ff" BorderColor="#99ccff"></asp:TextBox>
          </td>
          <td></td>
          <td>
              <asp:TextBox ID="textCounter2" runat="server" BackColor="#3399ff" BorderColor="#99ccff"></asp:TextBox>
          </td>
          <td></td>
          <td>
              <asp:TextBox ID="textCounter3" runat="server" BackColor="#3399ff" BorderColor="#99ccff"></asp:TextBox>
          </td>
          <td></td>
      </tr>

      <tr>
          <td>
              <asp:Button ID="btnCounter1" runat="server" Text="Next" Width="150px" OnClick="btnCounter1_Click"/>
          </td>
          <td></td>
          <td>
              <asp:Button ID="btnCounter2" runat="server" Text="Next" Width="150px" OnClick="btnCounter2_Click"/>
          </td>
          <td></td>
          <td>
              <asp:Button ID="btnCounter3" runat="server" Text="Next" Width="150px" OnClick="btnCounter3_Click"/>
          </td>
          <td></td>
      </tr>

      <tr>
          <td colspan ="5">
              <asp:TextBox ID="txtDispaly" runat="server" BackColor="#33CC33" BorderColor="#99CCFF"></asp:TextBox>
          </td>
      </tr>
      <tr>
          <td colspan="5">
              <asp:ListBox Font-Size="Large" ID="listTokens" runat="server" width="100px"></asp:ListBox>
          </td>
      </tr>
      <tr>
          <td colspan="5">
              <asp:Button ID="btnPrintToken" runat="server" Text="Print Token" OnClick="btnPrintToken_Click"/>
          </td>
      </tr>
      <tr>
          <td colspan="5">
              <asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label>
          </td>
      </tr>
  </table>
</asp:Content>
