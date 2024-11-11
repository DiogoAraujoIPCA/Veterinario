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
        string regex ="^d{9}$";
        if (NumeroTelemovel > 0 && VerificarSyntax(regex,Convert.ToString(NumeroTelemovel)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    #endregion
    





}