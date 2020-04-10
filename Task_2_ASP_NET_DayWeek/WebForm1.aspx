<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Task_2_ASP_NET_DayWeek.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3> CheckBoxList Example DayWeek</h3>

      Select items from the CheckBoxList.

      <br /><br />
 
      <asp:CheckBoxList runat="server">

      </asp:CheckBoxList>

         <asp:CheckBoxList ID="ActorList" runat="server" 
                                          AutoPostBack="True" RepeatLayout="Flow"
                                          Width="194px"                                           
                                          
                                           RepeatDirection="Vertical"          
                                           TextAlign="Right">
                            <asp:ListItem Value="Monday" />
                            <asp:ListItem Value="Tuesday" />
                            <asp:ListItem Value="Wednesday" />
                            <asp:ListItem Value="Thursday" />
                            <asp:ListItem Value="Friday" />
                            <asp:ListItem Value="Saturday" Selected="True" />
                            <asp:ListItem Value="Sunday" Selected="True"/>
                            
                        </asp:CheckBoxList>
   </form>
</body>
</html>
