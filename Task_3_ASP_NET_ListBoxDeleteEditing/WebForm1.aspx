<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="WebForm1.aspx.cs" 
    Inherits="Task_3_ASP_NET_ListBoxDeleteEditing.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
             <table border="1">
            <tr >
                <td colspan="3" style="text-align: center; color: red; width:100%; height: 50px; font-size:22px" >
                    <asp:Label ID="lblTitle" runat="server" Text="ListBox Example Add Editing Delete"></asp:Label>
                </td>                
            </tr>
            <tr>
                <td style="text-align: center;  width:100%; height: auto; font-size:22px; background-color:azure">
                     <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
                        <asp:ListItem Value="Hamburger"></asp:ListItem>
                        <asp:ListItem Value="Yoghurt"></asp:ListItem>
                        <asp:ListItem Value="Назарово2"></asp:ListItem>
                        <asp:ListItem Value="Казань2"></asp:ListItem>
                        <asp:ListItem Value="Красноярск2"></asp:ListItem>
                        <asp:ListItem Value="Петербург2"></asp:ListItem>
                        <asp:ListItem Value="Тула2"></asp:ListItem>
                        <asp:ListItem Value="Рязань2"></asp:ListItem>
                        <asp:ListItem Value="Воронеж2"></asp:ListItem>
                    </asp:ListBox>
                </td>
                
            </tr>
            <tr>
                <td></td>
                 <td></td>
                 <td></td>
                 <td></td>
            </tr>
            <tr>
                <td></td>
                 <td></td>
                 <td></td>
                 <td></td>
            </tr>  
        </table>
        </div>     
    </form>
</body>
</html>
