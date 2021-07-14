<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication3.Cadastro2" %>

    <asp:Content ID="Content" ContentPlaceHolderId="Content" runat="server"> 
        <div>
            <asp:Panel ID="pnlLogin" runat="server">
                <table ID="tblLogin" runat="server">
                    <tr>
                        <td>
                            <asp:Label ID="LabelLogin" runat="server" Text="Login"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputLogin" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="senha" runat="server" Text="Senha"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputSenha" type="password" runat="server" style="margin-left: 0px" ></asp:TextBox>                            
                        </td>
                    </tr>
                </table>
                <asp:Button ID="btnConfirmaLogin" runat="server" OnClick="BtnConfirmarLogin_Click" Text="Confirmar" />
				<asp:Button ID="btnAdmin" runat="server" Text="criar usuário admin" OnClick="Button1_Click" style="margin-left: 87px; margin-bottom: 0px"/>
            </asp:Panel>
            
        </div>    

</asp:Content> 