<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile Data Entry(GMI)</title>
    <style type="text/css">
        span.form-error {
            color: red;
        }
    </style>
</head>
<body>
    <form action="" runat="server" id="form">
        <table>

            <tr>
                <td>Name
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtName" data-validation="length alphanumeric"
                        data-validation-length="max25" data-validation-error-msg="Name is required."></asp:TextBox></td>
            </tr>
            <tr>
                <td>E-mail
    
                    
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtEmail" data-validation="required email"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Phone Number

                    
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPhoneNo" data-validation="required length numeric"
                        data-validation-length="10"
                        data-validation-error-msg="Phone no must be 10 digits"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Message 

                    
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtMessage" TextMode="MultiLine" data-validation="required length"
                        data-validation-length="10-250"
                        data-validation-error-msg="Message must be have 10 characters minimum to 250 as maximum."></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Save Profile Information" OnClick="btnSubmit_Click" />
                    <input type="reset" value="Reset" />
                </td>
                <td></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
    <script type="text/javascript" src="//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <script type="text/javascript" src="//cdnjs.cloudflare.com/ajax/libs/jquery-form-validator/2.2.43/jquery.form-validator.min.js"></script>
    <script type="text/javascript">
        $.validate();
    </script>
</body>
</html>

