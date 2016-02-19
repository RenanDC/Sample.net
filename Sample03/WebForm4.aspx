<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Sample03.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:FormView ID="frm1" runat="server" DataSourceID="odsPessoa" DefaultMode="Insert">
        
        <InsertItemTemplate>
            Nome:
            <asp:TextBox ID="NomeTextBox" runat="server" Text='<%# Bind("Nome") %>' />
            <br />
            Telefone:
            <asp:TextBox ID="TelefoneTextBox" runat="server" Text='<%# Bind("Telefone") %>' />
            <br />
            Obs:
            <asp:TextBox ID="ObsTextBox" runat="server" Text='<%# Bind("Obs") %>' />
            <br />
            CidadeId:
            <asp:dropdownlist id="ddl1" runat="server" DataSourceID="odsCidade" DataTextField="Descricao" DataValueField="CidadeId" SelectedValue='<%# Bind("CidadeId") %>'></asp:dropdownlist>           
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        
        </asp:FormView>
        <asp:ObjectDataSource ID="odsPessoa" runat="server" DataObjectTypeName="Sample03.PessoaTB" DeleteMethod="Delete" InsertMethod="Add" SelectMethod="Retrive" TypeName="Sample03.DAL.BllPessoas" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="IdPessoa" Type="Int32" />
            </DeleteParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="odsCidade" runat="server" SelectMethod="Retrive" TypeName="Sample03.DAL.BllCidades">
        </asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
