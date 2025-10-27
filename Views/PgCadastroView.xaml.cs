using projetoHope.Models;
using AppValidationLogin;
namespace projetoHope.Views;

public partial class PgCadastroView : ContentPage
{
    private Validation validationUsuario;
    private Validation validationSenha;
    public PgCadastroView()
	{
		InitializeComponent();
        validationUsuario = new Validation(txtUsuario, valUsuario);
        validationSenha = new Validation(txtSenha, valSenha);
    }

    private void btnCadastrarClicked(object sender, EventArgs e)
    {
        // Valida��o simples de vazio + tremer (Animation.Tremer � chamado por SetValidation(..., true))
        bool invalido = false;
        if (validationUsuario.IsEmpty()) { validationUsuario.SetValidation("Obrigat�rio", true); invalido = true; }
        if (validationSenha.IsEmpty()) { validationSenha.SetValidation("Obrigat�rio", true); invalido = true; }
        if (invalido) return;
    }

    private void btnVoltarClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new PgLoginView());
    }
}