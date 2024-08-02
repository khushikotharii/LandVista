<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication4.Login" %>



<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        .login-container {
            width: 300px;
            margin: 100px auto;
            padding: 30px;
            border: 1px solid #ccc;
            border-radius: 10px;
            box-shadow: 0px 0px 10px #ccc;
        }
        .login-container h2 {
            text-align: center;
        }
        .login-container div {
            margin-bottom: 15px;
        }
        .login-container label {
            display: block;
            margin-bottom: 5px;
        }
        .login-container input[type="text"], .login-container input[type="password"] {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .login-container input[type="submit"] {
            width: 100%;
            padding: 8px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        .login-container input[type="submit"]:hover {
            background-color: #0056b3;
        }
        .login-container .error {
            color: red;
            text-align: center;
        }
        .register-link {
            text-align: center;
            margin-top: 15px;
        }
        .register-link a {
            color: #007bff;
            text-decoration: none;
        }
        .register-link a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2>Login</h2>
            <div>
                <label for="txtUsername">Username</label>
                <asp:TextBox ID="txtUsername" runat="server" Placeholder="Username" CssClass="form-control" />
            </div>
            <div>
                <label for="txtPassword">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Password" CssClass="form-control" />
            </div>
            <div>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn btn-primary" />
            </div>
            <div>
                <asp:Label ID="lblMessage" runat="server" Text="" CssClass="error" />
            </div>
            <div class="register-link">
                <asp:HyperLink ID="lnkRegister" runat="server" NavigateUrl="~/Register.aspx">New user? Register here</asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>
