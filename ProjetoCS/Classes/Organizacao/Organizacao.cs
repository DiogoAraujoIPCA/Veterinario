public partial class Organizacao
{
    protected string NomeOrganizacao;
    protected string Morada;
    protected string Email;
    protected int NumeroTelemovel;
    protected List<Consulta> ListaConsultas;
    protected List<Veterinario> ListaVeterinarios;


    public Organizacao(string _NomeOrganizacao, string _Morada, string _Email, int _NumeroTelemovel)
    {
        NomeOrganizacao = _NomeOrganizacao;
        Morada = _Morada;
        Email = _Email;
        NumeroTelemovel = _NumeroTelemovel;

        
        ListaConsultas = new List<Consulta>();
        ListaVeterinarios = new List<Veterinario>();
    }
}