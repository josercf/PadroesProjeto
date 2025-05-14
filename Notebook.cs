namespace PadroesProjeto
{
    public class Notebook
    {
        public string Model { get; set; }

        public IProcessor Processor { get; set; }


        public Notebook Clone()
        {
            return this.MemberwiseClone() as Notebook;
        }

        public Notebook DeepCopy()
        {
            var newNotebook = Clone();
            newNotebook.Processor = new IntelProcessor();
            return newNotebook;
        }
    }
}
