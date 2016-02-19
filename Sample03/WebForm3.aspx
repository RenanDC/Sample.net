<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Sample03.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="CidadeId" HeaderText="CidadeId" SortExpression="CidadeId" />
                <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
                <asp:BoundField DataField="Sigla" HeaderText="Sigla" SortExpression="Sigla" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Sample03.Cidades" DeleteMethod="Delete" InsertMethod="Add" SelectMethod="Retrieve" TypeName="Sample03.DAL.BllCidades" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="IdCidade" Type="Int32" />
            </DeleteParameters>
        </asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
