<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q1a(i)_Semester2_2022.aspx.cs" Inherits="Spot_Question_DotNet.Q1a_i__Semester2_2022" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fibonacci Generator</title>
</head>
<body>
    <form runat="server">
        <div>
            <asp:Label ID="lblEnterElements" runat="server" Text="Enter number of elements:"></asp:Label>
            <asp:TextBox ID="txtNumberOfElements" runat="server"></asp:TextBox>
            <asp:Button ID="btnGenerate" runat="server" Text="Generate Fibonacci" OnClick="btnGenerate_Click" />
        </div>
        <div>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

