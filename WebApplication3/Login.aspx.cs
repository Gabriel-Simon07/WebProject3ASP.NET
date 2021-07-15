using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication3
{
	public partial class Cadastro2 : System.Web.UI.Page
	{
		
		protected void Page_Load(object sender, EventArgs e)
		{
			foreach (Usuario usuario1 in Usuario.Lista)
			{
				if (usuario1.isAdmin == true)
				{
					btnAdmin.Visible = false;
					//btnAdmin.Enabled = false;
				}
			}
		}
		

		protected void BtnConfirmarLogin_Click(object sender, EventArgs e)
		{
			bool temError = false;
			string mensagemErro = string.Empty;

			string senha = inputSenha.Text;
			string login = inputLogin.Text;
			if (!temError)
			{

				if (login == string.Empty)
				{
					temError = true;
					mensagemErro = "Informe um login valido! (" + login + ")";
				}
			}

			if (!temError)
			{
				if (senha == string.Empty)
				{
					temError = true;
					mensagemErro = "Informe uma senha válida!";
				}
			}

			if (!temError)
			{
				if (ValidarLogin(login, senha))
				{
					Session["Login"] = login;
					Session["Logado"] = true;
					Response.Write("<script>alert('usuário autenticado como: (" + login + ")!')</script>");
					Response.Redirect("Cadastro.aspx");
				}
				else
				{
					temError = true;
					mensagemErro = "usuário ou senha incorreto!(" + login + ")(" + senha + ")";
				}
			}


			if (temError)
			{
				Response.Write("<script>alert('Erro: " + mensagemErro + " " + login + "')</script>");
			}

		}

		private Boolean ValidarLogin(String login, String senha)
		{
			bool retorno = false;
			foreach (Usuario usuario in Usuario.Lista)
			{
				if (usuario.Login == login)
				{
					if (usuario.Senha == senha)
					{
						retorno = true;
						break;
					}
				}
			}
			return retorno;
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			var usuario = new Usuario();

				usuario.Login = inputLogin.Text;
				usuario.Senha = inputSenha.Text;
				usuario.isAdmin = true;
				usuario.Salvar();

				inputLogin.Text = string.Empty;
				inputSenha.Text = string.Empty;

				Response.Write("<script>alert('Admin cadastrado com sucesso!')</script>");

			foreach (Usuario usuario1 in Usuario.Lista)
			{
				if (usuario1.isAdmin == true)
				{

					btnAdmin.Visible = false;
					//btnAdmin.Enabled = false;
				}
			}

		}
	}
}