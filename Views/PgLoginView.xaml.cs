using projetoHope.Models;

namespace projetoHope.Views;

public partial class PgLoginView : ContentPage
{
    private Validation validationUsuario;
    private Validation validationSenha;
    public PgLoginView()
	{
		InitializeComponent();
        validationUsuario = new Validation(txtUsuario, valUsuario);
        validationSenha = new Validation(txtSenha, valSenha);
    }

    private void btnCadastrarClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new PgCadastroView());
    }

    private void btnLoginClicked(object sender, EventArgs e)
    {

        // Validação simples de vazio + tremer (Animation.Tremer é chamado por SetValidation(..., true))
        bool invalido = false;
        if (validationUsuario.IsEmpty()) { validationUsuario.SetValidation("Obrigatório", true); invalido = true; }
        if (validationSenha.IsEmpty()) { validationSenha.SetValidation("Obrigatório", true); invalido = true; }
        if (invalido) return;

    }
}