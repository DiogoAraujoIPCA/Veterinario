public partial class Consulta
{

   protected int id_Marcacao;

   protected DateTime DataInicial;

   protected DateTime DataFinal;

   protected Pessoa PessoaResponsavel;

   protected Animal AnimalConsulta;

   protected Veterinario VeterinarioResponsavel;

   protected List<int> ListaMarcacoes;

   protected CondicoesMedicas condicaoanimal;

   public Consulta(DateTime _DataInicial, DateTime _DataFinal, Pessoa _PessoaResponsavel, Animal _animal , Veterinario _VeterinarioResponsavel)
   {

      DataInicial = _DataInicial;
      DataFinal = _DataFinal;
      PessoaResponsavel = _PessoaResponsavel;
      AnimalConsulta = _animal;
      ListaMarcacoes = new List<int>();
      VeterinarioResponsavel= _VeterinarioResponsavel;
   }

   public enum CondicoesMedicas
   {
      InfeccaoBacteriana_Leptospirose,
      InfeccaoBacteriana_Brucelose,
      InfeccaoViral_Raiva,
      InfeccaoViral_ParvoviroseCanina,
      InfeccaoViral_LeucemiaFelina,
      DoencaParasitica_Dirofilariose,
      DoencaParasitica_Giardiase,
      DoencaParasitica_Babesiose,
      DoencaFungica_Dermatofitose,
      DoencaFungica_Criptococose,
      DoencaRespiratoria_TraqueobronquiteInfecciosa,
      DoencaRespiratoria_AsmaFelina,
      DoencaCardiaca_CardiomiopatiaDilatada,
      DoencaCardiaca_InsuficienciaCardiacaCongestiva,
      DoencaRenal_InsuficienciaRenalCronica,
      DoencaRenal_Nefrite,
      DoencaHepatica_Hepatite,
      DoencaHepatica_LipidoseHepatica,
      DoencaEndocrina_DiabetesMellitus,
      DoencaEndocrina_Hipotireoidismo,
      DoencaEndocrina_DoencaDeCushing,
      DoencaOrtopedica_DisplasiaCoxofemoral,
      DoencaOrtopedica_Artrite,
      Neoplasia_Linfoma,
      Neoplasia_TumoresMamaros,
      DoencaDePele_Alergias,
      DoencaDePele_Dermatite,
      DoencaDePele_Sarna,
      DoencaAutoimune_LupusEritematosoSistemico,
      DoencaAutoimune_AnemiaHemoliticaAutoimune,
      DoencaGastrointestinal_Gastrite,
      DoencaGastrointestinal_Enterite,
      DisturbioNeurologico_Epilepsia,
      DisturbioNeurologico_Encefalite,
      Intoxicacao_Quimica,
      Intoxicacao_Plantas,
      ProblemaDentario_DoencaPeriodontal,
      ProblemaDentario_AbscessoDentario,
      DoencaOcular_Catarata,
      DoencaOcular_Glaucoma,
      DisturbioHormonal_Hiperadrenocorticismo,
      DisturbioHormonal_Hipotireoidismo,
      DoencaMetabolica_SindromeMetabolica,
      DoencaMetabolica_Hipoglicemia
   }


}