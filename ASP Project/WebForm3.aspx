<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ASP_Project.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-image:url("images/mmmm.jpg");
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
        #TextBox1,
        #TextBox2,
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
        <div class="container">
            <div>
            <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter name"></asp:RequiredFieldValidator>
        </div>
                <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>

            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter password"></asp:RequiredFieldValidator>
      </div>
            <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
         </div>
      </div>
    </form>
</body>
</html>
