<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication4.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <style>
        .register-container {
            width: 400px;
            margin: 100px auto;
            padding: 30px;
            border: 1px solid #ccc;
            border-radius: 10px;
            box-shadow: 0px 0px 10px #ccc;
        }
        .register-container h2 {
            text-align: center;
        }
        .register-container div {
            margin-bottom: 15px;
        }
        .register-container label {
            display: block;
            margin-bottom: 5px;
        }
        .register-container input[type="text"], .register-container input[type="password"], .register-container input[type="email"] {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .register-container input[type="submit"] {
            width: 100%;
            padding: 8px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        .register-container input[type="submit"]:hover {
            background-color: #0056b3;
        }
        .register-container .error {
            color: red;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="register-container">
            <h2>Register</h2>
            <div>
                <label for="txtUsername">Username</label>
                <asp:TextBox ID="txtUsername" runat="server" Placeholder="Username" CssClass="form-control" />
            </div>
            <div>
                <label for="txtEmail">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Placeholder="Email" CssClass="form-control" />
            </div>
            <div>
                <label for="txtPassword">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Password" CssClass="form-control" />
            </div>
            <div>
                <label for="ddlRole">Role</label>
                <asp:DropDownList ID="ddlRole" runat="server" CssClass="form-control">
                    <asp:ListItem Value="Admin">Admin</asp:ListItem>
                    <asp:ListItem Value="Analyst">Analyst</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <asp:Button ID="btnSaveUser" runat="server" Text="Save" OnClick="btnRegister_Click" CssClass="btn btn-primary" />
            </div>
            <div>
                <asp:Label ID="lblMessage" runat="server" Text="" CssClass="error" />
            </div>
        </div>
    </form>
</body>
</html>
