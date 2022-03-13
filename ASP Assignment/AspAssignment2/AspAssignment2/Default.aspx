<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AspAssignment2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Select Any Name: <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="145px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br/>
         <asp:Image ID="Image2" runat="server" Height="314px" style="margin-left: 29px; margin-top: 37px" Width="480px" />
        <p>
            Check the price of this Car : <asp:Button ID="Price" runat="server" OnClick="Button1_Click1" style="margin-left: 43px" Text="Price" Width="119px" />
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged1" style="margin-top: 0px" Width="140px"></asp:TextBox> Note: gst not included
        </p>
    </form>
    </body>
</html>
