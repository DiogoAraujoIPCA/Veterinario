using System.Text.RegularExpressions;

public class Validacoes
{

    #region Validações Campos 
    public static bool VerificarSyntax(string regex, string Campo)
    {
        if(Campo==null){
            return true;
        }
        if (Regex.IsMatch(Campo, regex))
        {

            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool VerificarCampoNull(string Campo)
    {
        if (!string.IsNullOrWhiteSpace(Campo))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool VerificarCampo(string Campo)
    {
        if (VerificarSyntax("[a-zA-Z0-9]+$", Campo) == true && VerificarCampoNull(Campo) == true)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public static bool VerificarNumeroTelemovel(int NumeroTelemovel)
    {
        if (NumeroTelemovel > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    


    public  static void  IdentificacaoOperacao(string NomeOperacao  ){
          Console.WriteLine("------------------------------------------------------------");
          Console.WriteLine(NomeOperacao);
           Console.WriteLine("------------------------------------------------------------");
          
    }

    public static void EspacoEntreOperacoes(int NumerosLinhas){
        for (int i = 0 ; i<NumerosLinhas;i++){
            Console.WriteLine("");
        }
    }
    #endregion


}