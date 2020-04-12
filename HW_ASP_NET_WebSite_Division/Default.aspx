<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HW_ASP_NET_WebSite_Division._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">Home task ASP.NET WebSite</p>
        <p><a href="https://classroom.google.com/a/not-turned-in/all" class="btn btn-primary btn-lg">See task &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Enter the number</h2>
            <p>
               <asp:TextBox runat="server" ID="txtNumber" CssClass="txtNumber"></asp:TextBox>

                <asp:RequiredFieldValidator ID="RegFielValidNumber" CssClass="NumberValidator"
                    runat="server" ErrorMessage="Need enter number"
                    ControlToValidate="txtNumber">*</asp:RequiredFieldValidator>

                <asp:CustomValidator ID="NumberValidator" runat="server" 
                    CssClass="CustomValidator"
                    EnableClientScript="true"
                    ControlToValidate="txtNumber"
                    ErrorMessage="Fill in the field"
                    ClientValidationFunction="TextBoxNumberClient"                    
                    OnServerValidate="TextBoxNumber_Validate" Display="Dynamic" >
                </asp:CustomValidator>

                <asp:RangeValidator ID="RangeValidNumber" CssClass="RangeValidNumber"
                    runat="server" ErrorMessage="Error number"
                    Type="Integer"
                    ControlToValidate="txtNumber"                     
                    MinimumValue="-2147483648" 
                    MaximumValue="2147483647"
                    Text="Value need in diapazon Int32"></asp:RangeValidator>

               

                <asp:Label runat="server" ID="lblNumber" CssClass="lblNumber" BackColor="LightCoral"></asp:Label>

                
            </p>            
        </div>
        <div class="col-md-4">
            <h2>Enter the number to be divided</h2>
            <p>
                <asp:TextBox runat="server" ID="txtDiv" CssClass="txtDiv"></asp:TextBox>

                <asp:RequiredFieldValidator ID="RequiredFieldValidDiv" CssClass="NumberValidator"
                    runat="server" ErrorMessage="Need enter number"
                    ControlToValidate="txtNumber">*</asp:RequiredFieldValidator>

                <asp:CustomValidator ID="CustomValidDiv" runat="server" 
                    CssClass="CustomValidator"
                    EnableClientScript="true"
                    ControlToValidate="txtDiv"
                    ErrorMessage="Fill in the field"
                    ClientValidationFunction="TextBoxNumberClient"                    
                    OnServerValidate="TextBoxNumber_Validate" Display="Dynamic" >
                </asp:CustomValidator>

                <asp:RangeValidator ID="RangeValidDiv" CssClass="RangeValidNumber"
                    runat="server" ErrorMessage="Error number"
                    Type="Integer"
                    ControlToValidate="txtDiv"                     
                    MinimumValue="-2147483648" 
                    MaximumValue="2147483647"
                    Text="Value need in diapazon Int32"></asp:RangeValidator>

                 <asp:CompareValidator ID="CompareValidatorZero"
                    CssClass="CompareZero"
                    runat="server" ErrorMessage="Error number zero"                    
                    ControlToValidate="txtDiv" 
                    Operator="NotEqual"
                    ValueToCompare="0"
                    ></asp:CompareValidator>

                <asp:Label runat="server" ID="lblDiv" CssClass="lblDiv" BackColor="LightCoral"></asp:Label>
            </p>            
        </div>
        <div class="col-md-4">
            <h2>Result: </h2>
            <p>
                <asp:Button runat="server" ID="btnResult" 
                    class="btn btn-primary btn-lg" 
                    Text="Receive &raquo;" 
                    OnClick="btnResult_Click"
                    CausesValidation = true></asp:Button>
                
            </p> 
            <p>
                <asp:Label runat="server" ID="lblRes" Width="150px" Height="70px" BackColor="LightCoral" Font-Size="Larger"></asp:Label>
            </p>
        </div>
        <div>
            <asp:ValidationSummary ID="ValidationSummary" runat="server" 
                    DisplayMode = "List" CssClass="VlidationSummary"
                    HeaderText="As a result of the check, the following errors:" />
        </div>
    </div>

</asp:Content>
