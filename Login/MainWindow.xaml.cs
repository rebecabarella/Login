using System.Windows;

namespace Login;

public partial class MainWindow : Window
{
    
    // MAIN
    private const string USUARIO_PADRAO = "admin";
    private const string SENHA_PADRAO = "admin";

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BotaoLogin(object sender, RoutedEventArgs e)
    {
        
        //BOTAO LOGIN
        var usuarioDigitado = tbUsuario.Text;
        var senhaDigitada = tbSenha.Text;

        if (string.IsNullOrWhiteSpace(usuarioDigitado) || string.IsNullOrWhiteSpace(senhaDigitada))
        {
            MessageBox.Show("usuário e senha precisam ser informados", "informaçõe pendente");
            return;
        }
        
        if (usuarioDigitado != USUARIO_PADRAO || senhaDigitada != SENHA_PADRAO)
        {
            //TRUE
            MessageBox.Show("usuário e/ou senha estão errados", "Erro");
            return;
        }
        
        MessageBox.Show("boas vindas, admin");
        var novaJanela = new Painel();
        novaJanela.Show();
    } // FIM BOTAO LOGIN
    

    private void BotaoCadastro(object sender, RoutedEventArgs e)
    {
        
        var novaJanela = new Cadastro();
        novaJanela.Show();
    }
} // FIM MAIN