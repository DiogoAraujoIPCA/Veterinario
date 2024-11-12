using System.Reflection;

namespace Testes;

public class UnitTest1
{
    [Fact]
    [Trait("Categoria", "Atualização")]
    public void TestarNomeOrganizacao()
    {
        Organizacao org1 = new Organizacao("Arroz", "dadsadas", "dadsadas", 9122121);

        org1.RetornarEmail();

        Assert.Equal("dadsadas", org1.RetornarEmail());
    }

    [Fact]
    [Trait("Categoria", "Erro")]
    public void TelemovelOrganizacao()
    {
        Organizacao org1 = new Organizacao("Arroz", "dadsadas", "", 9122121);

        Assert.Equal(true, Validacoes.VerificarNumeroTelemovel(9122121));
    }

    [Fact]
    public void ErroTelemovelOrganizacao()
    {
        Organizacao org1 = new Organizacao("Arroz", "dadsadas", "", 9122121);

        Assert.Equal(false, Validacoes.VerificarNumeroTelemovel(-5));
    }

    [Fact]
    public void VerificarCampoSynatxInvalida()
    {
        Assert.Equal(false, Validacoes.VerificarCampo("###"));
    }

    [Fact]
    public void VerificarCampoVazio()
    {
        Assert.Equal(false, Validacoes.VerificarCampo(""));
    }

    
}
