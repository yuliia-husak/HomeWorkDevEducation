<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="WebForm1.aspx.cs"
    Inherits="ClassWork10042020_WEB_Forms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%-- <form id="fomr1" runat="server">
        <div>
            <asp:Label id="Output" runat="server"></asp:Label>
        </div>
    </form>--%>
    <%--<form id="form2" runat="server">
        <div>
            <%
                for (int i = 1; i <= 10; i++)
                {
                    for(int j = 1; j <= 10; j++)
                    {
                         Response.Write(i*j+"<br />");
                    }
                   
                }
             %>
            Today
            <%Response.Write(DateTime.Now.ToLocalTime()); %>
            <br />
            Today
            <%DateTime.Now.ToLocalTime(); %>
        </div>
    </form>--%>

   <%-- <form id="form3" runat="server">
        <div>
            <asp:Label ID="CounterLabel" runat="server" Text="0"></asp:Label>
            <br />
            <asp:Button ID="AddOneBtn" runat="server" Text="+1" OnClick="AddOneBtn_Click" />
            <asp:Button ID="AddTwoBtn" runat="server" Text="+2" OnClick="AddTwoBtn_Click" />

        </div>
    </form>--%>
    <form id="form4" runat="server">
        <div>
            <table>
                <tr>
                    <td>Name</td>
                    <td><asp:TextBox runat="server" Width="200px" ID="Name" /></td>
                </tr>
                <tr>
                    <td>ID</td>
                    <td><asp:TextBox runat="server" Width="200px" ID="EmpID" /></td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td><asp:TextBox runat="server" Width="200px" ID="Ahe" /></td>
                </tr>
                <tr>
                    <td>E-mail</td>
                    <td><asp:TextBox runat="server" Width="200px" ID="Email" /></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td><asp:TextBox runat="server" Width="200px" ID="Password" /></td>
                </tr>
            </table>
            <br />
            <asp:Button runat="server" Text="Save" ID="cmdSave" OnClick="cmdSave_Click" />
            <asp:Button runat="server" Text="Restore" ID="cmdRestore" OnClick="cmdRestore_Click" />
        </div>
    </form>
</body>
</html>
