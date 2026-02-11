<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First Web Application</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Convert Celsius to Fahrenheit</strong>
            <p>
                <asp:Label ID="lblEnterC" runat="server" Text="Enter Celsius: "></asp:Label>
                <asp:TextBox ID="txtInputC" runat="server"></asp:TextBox> 
                <asp:Button ID="btnConvertC" runat="server" Text="Convert" OnClick="btnConvertC_Click" />
                <asp:Label ID="lblFahrenheit" runat="server" Text="Fahrenheit: "></asp:Label>
                <asp:Label ID="lblResultC" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div>
            <strong>Convert Fahrenheit to Celsius</strong>
            <p>
                <asp:Label ID="lblEnterF" runat="server" Text="Enter Fahrenheit: "></asp:Label>
                <asp:TextBox ID="txtInputF" runat="server"></asp:TextBox> 
                <asp:Button ID="btnConvertF" runat="server" Text="Convert" OnClick="btnConvertF_Click"/>
                <asp:Label ID="lblCelsius" runat="server" Text="Celsius: "></asp:Label>
                <asp:Label ID="lblResultF" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div>
            <strong>Sort Comma Separated Numbers</strong>
            <p>
                <asp:Label ID="lblEnterS" runat="server" Text="Enter Comma Separated Numbers: "></asp:Label>
                <asp:TextBox ID="txtInputS" runat="server"></asp:TextBox> 
                <asp:Button ID="btnSort" runat="server" Text="Sort" OnClick="btnSort_Click"/>
                <asp:Label ID="lblSorted" runat="server" Text="Sorted: "></asp:Label>
                <asp:Label ID="lblResultS" runat="server" Text=""></asp:Label>
            </p>
    </div>
    </form>
</body>
</html>
