<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="WebForm1.aspx.cs"    
    Inherits="Task_01_ASP_LoginPassword.WebForm1" 
    %>

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
                    <td>Login</td>
                    <td><asp:TextBox runat="server"
                                    BackColor="#FFC080"
                                    BorderColor="Black"
                                    BorderStyle="Solid"
                                    BorderWidth="1px"
                                    Font-Names="Tahoma, Verdana, Arial"
                                    Font-Size="Smaller" /></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td><asp:TextBox runat="server" 
                                    BackColor="#FFC080"
                                    BorderColor="Black"
                                    BorderStyle="Solid"
                                    BorderWidth="1px"
                                    Font-Names="Tahoma, Verdana, Arial"
                                    Font-Size="Smaller" /></td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td><asp:RadioButton runat="server"  Width="200px" ID="Gen1" Text="Man"  GroupName="gender"/></td> 
                    <td><asp:RadioButton runat="server" Width="200px" ID="Gen2" Text="Woman" GroupName="gender"/></td>
                </tr>
                <tr>
                    <td>How did you hear about us: </td>
                </tr>
                <tr translate="yes">
                    <td> <asp:Label runat="server" Text="YouTube"></asp:Label>
                        <asp:Checkbox runat="server" Width="200px" ID="cbYouTube" />                       
                    </td>                     
                </tr>
                <tr>
                    <td><asp:Label runat="server" Text="FaceBook" TextAlign="Right"></asp:Label>
                        <asp:Checkbox runat="server" Width="200px" ID="cbFaceBook"  TextAlign="Right"/></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server" Text="Instagram"></asp:Label>
                        <asp:Checkbox runat="server" Width="200px" ID="cbInsta" /></td>
                </tr>
                <tr>
                     <td><asp:Label runat="server" Text="Twitter"></asp:Label>
                         <asp:Checkbox runat="server" Width="200px" ID="cbTwitter" /></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server" Text="Other"></asp:Label>
                        <asp:Checkbox runat="server" Width="200px" ID="cbOther" /></td>
                </tr>   
                <tr>
                    <td>About Me</td>
                    <td><asp:TextBox runat="server" Width="200px" BorderColor="YellowGreen" Height="50px" ID="AboutMe" /></td>
                </tr>
            </table>
            <br />  
            <tr>
                <td>
                    <asp:Button runat="server" 
                                BackColor="#C04000"
                                BorderColor="Maroon"
                                BorderStyle="Solid"
                                BorderWidth="2px"
                                Font-Names="Tahoma,Verdana,Arial"
                                Font-Size="Smaller"
                                ForeColor="#FFFFC0"
                                Width="200px"
                                Text="Sent" />
                </td>
            </tr>
        </div>
    </form>
</body>
</html>
