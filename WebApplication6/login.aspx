<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication6.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
    <link rel="stylesheet"  href="custom.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
    <div align="center" class="container jumbotron bg-light boxshadow" style="width:35%">
    <form>
        <div class="card-header-pills bg-dark text-white">
            <h2>Login Page</h2>
        </div>
        <div class="form-group" style=" width:80%">
            <label class="text-dark" for="emailLabel">Usuario</label>
            <div class="input-group mb-2">
                <div class="input-group-prepend">
                   
                </div>
                <asp:TextBox ID="txt_usuario" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="text-dark" for="passLabel">Password</label>
            <asp:TextBox ID="txt_password" runat="server" CssClass="form-control" TextMode="Password" Width="80%"></asp:TextBox>
        </div>
        
        <asp:Button ID="Button1" runat="server" Text="Submit"  CssClass="btn btn-primary" OnClick="Button1_Click"/>
        
    </form>
    </div>
    </form>
</body>
</html>

