<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Desafio2.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <script type="text/javascript">
         
        function OrdenaLista(GridPessoas) {
        var listaAux = OrdenaJson(lista, chave, ordem);
        listaItens(listaAux);
    }

</script>  
         <div>
          <hr style="color: #000000;" size="1px" />
           <center>
          <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" 
            ForeColor="Black" Text="ATIVIDADE  DESENVOLVIDA" Font-Names="Tahoma"></asp:Label></center>  
         </div>
        
        <div>
        <br />
        <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Tahoma" Font-Size="11pt" ForeColor="#284E98" OnMenuItemClick="Menu1_MenuItemClick" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#B5C7DE" />
            <DynamicSelectedStyle BackColor="#507CD1" />
            <Items>
                <asp:MenuItem Text="Pessoas por Situação" Value="Pessoas por Situação">
                    <asp:MenuItem Text="Andamento" Value="Andamento"></asp:MenuItem>
                    <asp:MenuItem Text="Atrasada" Value="Atrasada"></asp:MenuItem>
                </asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#507CD1" />
        </asp:Menu>
             <br />
            <div> <center><asp:Button OnClientClick="OrdenaLista" ID="Button1" runat="server" Text="Cadastrar" Font-Names="Tahoma" Font-Size="12pt"/></center></div>
           
        <br />
        

        <asp:GridView ID="GridPessoas" runat="server" BackColor="#9C9C9C" align="center" 
            BorderColor="#9C9C9C" BorderStyle="None" BorderWidth="1px" CellPadding="2" 
            Width="920px" Font-Names="Tahoma" Font-Size="12pt" AccessKey="e" PageSize="25" AllowSorting="True">
            <RowStyle BackColor="White" ForeColor="BLACK" HorizontalAlign="Center" />
            <FooterStyle BackColor="#9C9C9C" ForeColor="#9C9C9C" Font-Names="Verdana" 
                Font-Size="11px" />
            <PagerStyle BackColor="#9C9C9C" ForeColor="#185498" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#9C9C9C" Font-Bold="False" Font-Names="Verdana" 
                Font-Size="11px" ForeColor="White" />
        </asp:GridView>

    
    
    </div>
    </form>
</body>




</html>
