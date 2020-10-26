<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Router.aspx.cs" Inherits="map_router.src.Router" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Router" runat="server">
        <div>
            <asp:TextBox ID="x_coordinate" runat="server" placeholder="X co-ordinate"></asp:TextBox>
            <asp:TextBox ID="y_coordinate" runat="server" placeholder="Y co-ordinate"></asp:TextBox>
        </div>
        <div>
            <asp:Button type="button" ID="add_coordinates_btn" Text="Add point" runat="server" OnClick="add_coordinates" />
        </div>
        <div>
             <asp:GridView ID="points_grid" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Button type="button" ID="clear_coordinates_btn" Text="Clear points" runat="server" OnClick="clear_coordinates" />
        </div>
        <div>
            <asp:DropDownList ID="algorithm_dropdown_list" AutoPostBack="True" runat="server">
                <asp:ListItem Selected="True" Value="Alg1"> Alg1 </asp:ListItem>
                <asp:ListItem Value="Alg2"> Alg2 </asp:ListItem>
                <asp:ListItem Value="Alg3"> Alg3 </asp:ListItem>
                <asp:ListItem Value="Alg4"> Alg4 </asp:ListItem>
                <asp:ListItem Value="Alg5"> Alg5 </asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Button type="button" ID="route_btn" Text="Route" runat="server" OnClick="generate_route" />
        </div>
    </form>
</body>
</html>
