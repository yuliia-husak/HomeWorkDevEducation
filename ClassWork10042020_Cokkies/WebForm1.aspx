<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ClassWork10042020_Cokkies.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Name</td>
                    <td><asp:TextBox runat="server" Width="200px" ID="Name" /></td>
                </tr>
                <tr>
                    <td>Year</td>
                    <td><asp:TextBox runat="server" Width="200px" ID="Year" /></td>
                </tr>               
            </table>
            <br />
            <asp:Button runat="server" Text="Save" ID="cmdSave" OnClick="cmdSave_Click" />
            <asp:Button runat="server" Text="Show" ID="cmdRestore" OnClick="cmdRestore_Click" />
            <br />
            <asp:Label runat="server" ID="lbShow" Width="500px"></asp:Label>
        </div>
    </form>
</body>
</html>
