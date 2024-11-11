/*Ficheiro onde estão agrupados todos os metodos que irão atualizar os  
dados do objeto */
public partial class Pessoa{
    
     #region Metodos Atualizar Dados da Pessoa

    public void AtualizarNumeroTelemovel(int _NumeroTelemovel)
    {
        Auxliar.IdentificacaoOperacao("Atualizar Numero do telefone de "+Nome+" ");
        if (Validacoes.VerificarNumeroTelemovel(_NumeroTelemovel))
        {
            NumeroTelemovel = _NumeroTelemovel;
            Console.WriteLine("Numero Temovel Atualizado com sucesso");
        }
        else
        {
            Console.WriteLine("Não Foi possivel realizar Atualização Nº Telemovel");
        }
    }
    public void AtualizarNome(string _Nome)
    {
        Auxliar.IdentificacaoOperacao("Atualizar Nome do "+Nome+" ");
        if (Validacoes.VerificarCampo(_Nome))
        {

            Nome = _Nome;
            Console.WriteLine("Nome Atualizado com sucesso");
        }
        else
        {
            Console.WriteLine("Não Foi possivel realizar Atualização Nome");
        }
    }
    public void AtualizarMorada(string _Morada)
    {
        Auxliar.IdentificacaoOperacao("Atualizar Morada do "+Nome+" ");
        if (Validacoes.VerificarCampo(_Morada))
        {

            Morada = _Morada;
            Console.WriteLine("Morada Atualizada com sucesso");
        }
        else
        {
            Console.WriteLine("Não Foi possivel realizar atualização Morada");
        }
    }
    #endregion
}