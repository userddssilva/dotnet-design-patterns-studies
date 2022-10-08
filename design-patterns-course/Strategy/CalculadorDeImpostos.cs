namespace Course.Strategy
{
  public class CalculadorDeImpostos
  {
      public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
      {
          var internalImposto = imposto.Calcula(orcamento);
          Console.WriteLine(internalImposto);
      }
  }  
}

