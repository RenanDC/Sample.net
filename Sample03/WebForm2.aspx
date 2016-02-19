<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Sample03.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="EntityDataSource1">
            <Columns>
                <asp:BoundField DataField="Descricao" HeaderText="Descricao" ReadOnly="True" SortExpression="Descricao" />
                <asp:BoundField DataField="Sigla" HeaderText="Sigla" ReadOnly="True" SortExpression="Sigla" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" ReadOnly="True" SortExpression="Nome" />
                <asp:BoundField DataField="Telefone" HeaderText="Telefone" ReadOnly="True" SortExpression="Telefone" />
                <asp:BoundField DataField="Obs" HeaderText="Obs" ReadOnly="True" SortExpression="Obs" />
            </Columns>
        </asp:GridView>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=SampleDBEntities2" DefaultContainerName="SampleDBEntities2" EnableFlattening="False" EntitySetName="View_1" EntityTypeFilter="View_1" Select="it.[Descricao], it.[Sigla], it.[Nome], it.[Telefone], it.[Obs]">
        </asp:EntityDataSource>
    
    </div>
    </form>
</body>
</html>
