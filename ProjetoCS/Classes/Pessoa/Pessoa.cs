
public partial  class Pessoa
{

    protected string Nome;
    protected string Morada;
    protected int NumeroTelemovel=0;

    protected bool Veterinario;

    protected List<Animal> Animais;

    public Pessoa(string _Nome, string _Morada, int _NumeroTelemovel)
    {
        Nome = _Nome;
        Morada = _Morada;
        NumeroTelemovel = _NumeroTelemovel;
        Animais = new List<Animal>();
    }

    


}

