<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="ASP_Project.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    body{
        background-image:url("images/mmmm.jpg");
        background-size:cover;
        background-repeat:no-repeat;
    }
        </style>
   <center>
   <form id="frm" runat="server">
 <%--write logic under form tag--%>
 <%--<asp:TextBox id="txt" runat="server" />
 <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>--%>
       <asp:Label runat="server" Text="UserName" ForeColor="YellowGreen"></asp:Label>
       <asp:TextBox runat="server" ID="txtuname"></asp:TextBox>
       <br />
       <br />
       <asp:Label runat="server" Text="Password" ForeColor="Cyan" ></asp:Label>
       <asp:TextBox runat="server" ID="txtpwd" ></asp:TextBox>
         <br />
  <br />

 <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" BackColor="pink" />
       <br />
       <br />
    <asp:Button ID="Button2" runat="server" Text=" New Registration" OnClick="Button2_Click" BackColor="blue" />
       </form>
       </center>
</asp:Content>
