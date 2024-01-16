<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q4_Semester2_2022.aspx.cs" Inherits="Spot_Question_DotNet.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Question 4</title>
    <!-- Add your meta tags, stylesheets, and other head elements here -->
</head>
<body>
    <form runat="server">

        <table border="1">

            <tr>
                <td>Feedback ID:</td>
                <td>
                    <asp:TextBox ID="txtFeedbackID" runat="server" Required="True" ValidationGroup="Feedback"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFeedbackID" runat="server" ControlToValidate="txtFeedbackID" ErrorMessage="Must enter feedback ID" ValidationGroup="Feedback"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revFeedbackID" runat="server" ControlToValidate="txtFeedbackID" 
                        ErrorMessage="Invalid feedback ID format" ValidationExpression="^[a-zA-Z]{2}\d{4}$"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td>Room Type:</td>
                <td>
                    <asp:DropDownList ID="ddlRoomType" runat="server">
                        <asp:ListItem>Regular</asp:ListItem>
                        <asp:ListItem>Family</asp:ListItem>
                        <asp:ListItem>Luxury</asp:ListItem>
                        <asp:ListItem>Suite</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>E-mail:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Required="True" ValidationGroup="Feedback" 
                        ValidationExpression="\w+([-.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Must enter e-mail" ValidationGroup="Feedback"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" 
                        ErrorMessage="Invalid e-mail format" ValidationExpression="\w+([-.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td>Phone Number:</td>
                <td>
                    <asp:TextBox ID="txtPhone" runat="server" Required="True" ValidationGroup="Feedback" 
                        ValidationExpression="(\(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="Must enter phone number" ValidationGroup="Feedback"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone" 
                        ErrorMessage="Invalid phone number" ValidationExpression="(\(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td>Customer Satisfaction:</td>
                <td>
                    <asp:RadioButtonList ID="rblSatisfaction" runat="server">
                        <asp:ListItem>Excellent</asp:ListItem>
                        <asp:ListItem>Good</asp:ListItem>
                        <asp:ListItem>Bad</asp:ListItem>
                        <asp:ListItem>Horrible</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>

            <tr>
                <td>Comments:</td>
                <td><asp:TextBox ID="txtComments" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            </tr>

            <tr>
                <td></td>
                <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" /></td>
            </tr>

        </table>

    </form>
</body>
</html>
