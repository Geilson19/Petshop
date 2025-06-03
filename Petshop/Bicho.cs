namespace Petshop
{

    public abstract class Bicho
    {
        public int id { get; set; }
        public string nome { get; set; } = string.Empty;
        public int idade { get; set; }
        public abstract string EmitirBarulho();
    }
}
