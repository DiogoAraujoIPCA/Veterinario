using System.Reflection.Metadata;

public partial class Veterinario
{
    protected int ID_Veterinario;

    protected Pessoa _Pessoa;

    public Veterinario(int id, Pessoa _PessoaParam)
    {
        ID_Veterinario = id;
        _Pessoa = _PessoaParam;
    }

    public void RetornarTodosDados(bool estado)
    {
        if (estado)
        {
            Auxliar.IdentificacaoOperacao("Informações Veterinario");
        }

        Console.Write("ID Veterinario:" + ID_Veterinario + "");
        _Pessoa.RetornarTodasInformacoes(false);
    }
}
