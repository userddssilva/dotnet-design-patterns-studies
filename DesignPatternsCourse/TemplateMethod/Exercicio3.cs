namespace DesignPatternsCourse.TemplateMethod.Execicio3
{
    public abstract class TemplateRelatorio
    {
        public void CriaRelatorio()
        {
            Console.WriteLine("Relatorio");
            Cabecalho();
            Corpo();
            Rodape();
        }
        
        public void Corpo()
        {
            Console.WriteLine("Corpo");
        }

        protected abstract void Cabecalho();

        protected abstract void Rodape();
    }

    public class RelatorioSimples : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Cabecalho simples");
        }

        protected override void Rodape()
        {
            Console.WriteLine("Rodape simples");
        }
    }


    public class RelatorioComplexo : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Cabecalho Complexo");
        }

        protected override void Rodape()
        {
            Console.WriteLine("Rodape Complexo");
        }
    }

    public class Program
    {
        static void Main1(String[] args)
        {
            RelatorioSimples relatorioSimples = new RelatorioSimples();
            RelatorioComplexo relatorioComplexo = new RelatorioComplexo();
            
            relatorioSimples.CriaRelatorio();
            relatorioComplexo.CriaRelatorio();
        }
    }
}