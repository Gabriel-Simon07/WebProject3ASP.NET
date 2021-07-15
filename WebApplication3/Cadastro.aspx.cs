using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool logado = false;

            if (HttpContext.Current.Session["Login"] != null) {

                logado = Convert.ToBoolean(Session["Logado"].ToString());

            } 

            if (logado) { 
                pnlCadastro.Visible = false;
                pnlLista.Visible    = true;

                GridViewUsuarios.DataSource = Usuario.Lista;
                GridViewUsuarios.DataBind();

            } else
            {
                pnlCadastro.Visible = false;
                pnlLista.Visible = false;
                Response.Write("<script>alert('Usuário não autenticado! "+ logado + "')</script>");
            }

        }

        protected void BtnInserir_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = true;
            pnlLista.Visible = false;
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = false;
            pnlLista.Visible = true;

            var usuario = new Usuario();
			usuario.Nome = inputUsuarioNome.Text;
            usuario.Email = inputUsuarioEmail.Text;
            usuario.Login = inputCadastroLogin.Text;
            usuario.Senha = inputCadastroSenha.Text;
			usuario.isAdmin = false;
            usuario.Salvar();

            inputUsuarioNome.Text = string.Empty;
            inputUsuarioEmail.Text = string.Empty;
            inputCadastroLogin.Text = string.Empty;
            inputCadastroSenha.Text = string.Empty;

			GridViewUsuarios.DataSource = Usuario.Lista;
            GridViewUsuarios.DataBind();
        }
     
    }
}