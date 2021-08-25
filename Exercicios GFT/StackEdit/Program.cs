//http://www.macoratti.net/18/01/c_encaps1.htm

using System;

namespace C_
{
    class Retangulo
    {
        //variáveis membros 
        public double comprimento;
        public double largura;
        //Esses dois atributos/campos ser acessados diretamente a partir do método Main() usando uma instância r da classe Retangulo.
        public double GetArea()
        {
            return comprimento * largura;
        }

        public void Exibir()
        {
            Console.WriteLine("Área do Retângulo\n");
            Console.WriteLine($"Comprimento: {comprimento}");
            Console.WriteLine($"Largura: {largura}");
            Console.WriteLine($"Area: {GetArea()}");
        }
    }
    class Program
    /*
    Encapsulamento: processo de ocultar ou esconder os membros de uma classe do acesso exterior usando modificadores de acesso. 
    O encapsulamento também é chamado de ocultação de informação ou information hiding.
    Os modificadores de acesso são Public, Private, Protected, Internal, Protected Internal.
    */

    //Public: permite que uma classe exponha suas variáveis de membros e funções de membros a outras funções e objetos.
    {
        static void Main(string[] args)
        {
            var r = new Retangulo();
            r.comprimento = 2.5;
            r.largura = 1.5;
            r.Exibir();
            Console.ReadLine();
        
        /*Aqui o código não esta encapsulado e pode ser alterado por qualquer programa exterior.

        Mudando os atributos largura e comprimento para private, 
        vamos ver que r.comprimento  r.largura e r.Exibir não estão mais acessíveis, 
        Ou seja não podemos mais modificalos como podíamos no public

        Os campos agora somente podem ser acessados pelos métodos GetArea() e Exibir() da classe Retangulo. 
        Esses métodos são públicos e podem ser acessados no método Main().*/
        }
    }
}
