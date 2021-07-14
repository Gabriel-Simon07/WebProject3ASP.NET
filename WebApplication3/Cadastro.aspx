<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication3.WebForm1" %>

<asp:Content ID="Content" ContentPlaceHolderId="Content" runat="server">
        <div>
            <asp:Panel ID="pnlCadastro" runat="server">
                
                <table ID="tblCadastro" runat="server">
                    <tr>
                        <td>
                            <asp:Label ID="LabelNome" runat="server" Text="Nome"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputUsuarioNome" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputUsuarioEmail" runat="server" ></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelLogin" runat="server" Text="Login"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputCadastroLogin" runat="server" ></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelSenha" runat="server" Text="Senha"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputCadastroSenha" type="password" runat="server" ></asp:TextBox>                            
                        </td>
                    </tr>
                </table>
                 <hr />
                <asp:Button ID="BtnSalvar" runat="server" Text="Salvar" OnClick="BtnSalvar_Click" />
            </asp:Panel>
        </div>
        <hr />
        <div>
        <asp:Panel ID="pnlLista" runat="server">
            <asp:Button ID="BtnInserir" runat="server" OnClick="BtnInserir_Click" Text="Inserir" />
             <hr />
            <asp:GridView ID="GridViewUsuarios" runat="server">
            </asp:GridView>
        </asp:Panel>
        </div>
        <hr />
</asp:Content>
