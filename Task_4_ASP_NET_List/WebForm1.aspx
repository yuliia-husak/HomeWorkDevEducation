<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Task_4_ASP_NET_List.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:antiquewhite">
     <form id="form1" runat="server" method="post">
        <h1 style='color:rgba(25, 117, 106, 0.98); margin-left:290px'>
            Grocery list
        </h1>
        <h2 style='color:rgba(25, 117, 106, 0.98); margin-left:120px; text-align:center'>
            Select items in one list and forward to another using the buttons
        </h2>
        <table >
            <tr>
                <td>
                    <asp:Label runat="server" Text="Grocery list" Width="300px"></asp:Label>                    
                </td>
                <td></td>
                <td>
                     <asp:Label runat="server" Text="Basket (selected products)" Width="300px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td >                    
                    <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" Width="350px"></asp:ListBox>
                </td>
                <td style="width: 91px">
                    <p >
                        <asp:Button ID="Button1" runat="server" Font-Bold="True"
                                    Font-Size="Large" Text="->" Onclick="Button1_Click"/>
                        <br />
                        <asp:Button ID="Button2" runat="server" Font-Bold="True" 
                                    Font-Size="Large" Text="<-" Onclick="Button2_Click"/>
                    </p>
                </td>
                <td >
                   
                    <asp:ListBox ID="ListBox2" runat="server" SelectionMode="Multiple" Width="350px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" BackColor="LightBlue" OnClick="btnAllBasket_Click" ID="btnAllBasket" Text="Transfer everything to basket ->" Width="250px" Height="60px"/>
                </td>
                <td></td>
                <td>
                    <asp:Button runat="server" BackColor="LightBlue" OnClick="btnDelAllBasket_Click" ID="btnDelAllBasket" Text="Delete everything to basket <-" Width="250px" Height="60px"/>

                </td>
            </tr>
            
        </table>
    </form>
    <br />
    

</body>
</html>
