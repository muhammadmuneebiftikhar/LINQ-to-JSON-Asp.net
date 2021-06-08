<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="LINQ_to_JSON.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <h1 class="auto-style4"><strong>Product</strong></h1>
    <form id="form1" runat="server">
        <div class="auto-style4">
        <div>
            <table style="width:100%;">
                
                <tr>
                    <td class="auto-style4">ID</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Title</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txTitle" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Unit Price</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtUnitPrice" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Expire</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtExpire" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Manufacture</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtManufacture" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Stock</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <asp:TextBox ID="txtMain" runat="server" CssClass="auto-style5" Height="128px" Width="800px"></asp:TextBox>
            </div>
            <asp:Button ID="btnSaveToFile" runat="server" Text="Save To File" OnClick="btnSaveToFile_Click" />
        </div>
        <div class="auto-style4">
            <asp:GridView ID="GridView1" runat="server" Width="811px">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
