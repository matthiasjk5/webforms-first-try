<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webforms_first_try.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 91px;
            width: 340px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Web Architect<br />
        <br />
        Please add the room details<br />
        <br />
        Room Name:
        <asp:TextBox ID="TextBox1" runat="server" Width="334px"></asp:TextBox>
        <p>
            Room Size:
            <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="true" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;ft. (width)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" AutoPostBack="true" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
&nbsp;ft,(length)</p>
        <p>
            Room Area:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            Room Cost:
            <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
&nbsp; CAD / sq.ft</p>
        <p>
            Room Details:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <textarea id="TextArea1" name="S1" runat="server"></textarea></p>
        <p>
            <asp:Button ID="Button1" runat="server" AutoPostBack="true" Text="Add Room" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
