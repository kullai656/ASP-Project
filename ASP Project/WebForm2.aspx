<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ASP_Project.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
         body{
     background-image:url("images/flower k.jpg");
     background-size:cover;
     background-repeat:no-repeat;
 }
 .container{
     margin:30px;
     width:100%;
     max-width:400px;
     margin-top:220px;
     margin-left:350px;
     background-color:aquamarine;
     padding:20px;
     align-content:center;
     border-radius:8px;
     
 }
   #Lable1,
   #Button1{
       width:300px;
       border-radius:8px;
       align-content:center;

   }
    #Button1:hover{
     background-color:blue;
     color:white;
 }
    </style>
</head>
<body style="width: 636px">
    <form id="form1" runat="server">
        <div style="border: thick double #000000; margin: inherit; ; font-size: x-large; font-style: italic; font-variant: small-caps; text-transform: uppercase; color: #800000; text-decoration: none; table-layout: auto; border-collapse: collapse; border-spacing: inherit; empty-cells: hide; caption-side: bottom;">
        &nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Registration sucesfull"></asp:Label>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
