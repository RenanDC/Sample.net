<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Sample03.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Incluindo o CSS do Bootstrap -->
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <!-- Incluindo o jQuery que é requisito do JavaScript do Bootstrap localmente-->
    <script src="Scripts/jquery-1.9.1.min.js"></script>     
    <!-- Incluindo o JavaScript do Bootstrap -->
    <script src="Scripts/bootstrap.min.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:GridView 
            ID="GridView1" 
            runat="server" 
            AutoGenerateColumns="False" 
            CellPadding="4" 
            DataKeyNames="CidadeId" 
            DataSourceID="EntityDataSource1" 
            ForeColor="#333333" 
            GridLines="None"
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
                <asp:BoundField DataField="Sigla" HeaderText="Sigla" SortExpression="Sigla" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button runat="server" ID="btnDeletar" CommandName="Delete" Text="Deletar"/>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button runat="server" ID="btnEdit" CommandName="Update" Text="Alterar"/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Button" SelectText="Edit" ShowSelectButton="true" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <br />
        <asp:FormView 
            ID="FormView1" 
            CssClass="form-group-lg" 
            runat="server" 
            DataSourceID="EntityDataSource2" 
            DataKeyNames="CidadeId" 
            DefaultMode="Insert" 
            OnItemUpdated="FormView1_ItemCommand">
            <EditItemTemplate>                
                <asp:Label text="Descricao:" CssClass="label-default" runat="server"></asp:Label>
                <asp:TextBox ID="DescricaoTextBox" CssClass="" runat="server" Text='<%# Bind("Descricao") %>' />
                <br />
                <asp:label text="Sigla:" runat="server" CssClass="label-danger"></asp:label>
                <asp:TextBox ID="SiglaTextBox" runat="server" Text='<%# Bind("Sigla") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Alterar" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </EditItemTemplate>
            <InsertItemTemplate>
                <asp:Label text="Descricao:" CssClass="control-label" runat="server"></asp:Label>
                <asp:TextBox ID="DescricaoTextBox" runat="server" Text='<%# Bind("Descricao") %>' />
                <br />
                <asp:label text="Sigla:" runat="server" CssClass="control-label"></asp:label>
                <asp:TextBox ID="SiglaTextBox" runat="server" Text='<%# Bind("Sigla") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Inserir" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
            <ItemTemplate>
                Descricao:
                <asp:Label ID="DescricaoLabel" runat="server" Text='<%# Bind("Descricao") %>' />
                <br />
                Sigla:
                <asp:Label ID="SiglaLabel" runat="server" Text='<%# Bind("Sigla") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Deletar" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="Novo" />
            </ItemTemplate>
        </asp:FormView>

        <asp:EntityDataSource 
            ID="EntityDataSource1" 
            runat="server" 
            ConnectionString="name=SampleDBEntities2" 
            DefaultContainerName="SampleDBEntities2" 
            EnableDelete="True" 
            EnableFlattening="False" 
            EnableInsert="True" 
            EnableUpdate="True"             
            EntitySetName="Cidades" 
            EntityTypeFilter="Cidades">        
        </asp:EntityDataSource>

        <asp:EntityDataSource 
            ID="EntityDataSource2" 
            runat="server" 
            ConnectionString="name=SampleDBEntities2" 
            DefaultContainerName="SampleDBEntities2" 
            EnableDelete="True" 
            EnableFlattening="False" 
            EnableInsert="True" 
            EnableUpdate="True"             
            EntitySetName="Cidades" 
            EntityTypeFilter="Cidades"
            Where="it.CidadeId = @cidadeId">
            <WhereParameters>
                <asp:ControlParameter ControlID="GridView1" name="CidadeId" PropertyName="SelectedValue" Type="Int32" />
            </WhereParameters>
        </asp:EntityDataSource>
    
    </div>
    </form>
</body>
</html>
