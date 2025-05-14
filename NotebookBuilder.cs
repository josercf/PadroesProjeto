namespace PadroesProjeto
{
    public class NotebookBuilder
    {
        private Notebook _notebook;

        public NotebookBuilder(Notebook notebook)
        {
            _notebook = notebook;
        }

        public void BuildModel(string model)
        {
            _notebook.Model = model;
        }

        public void BuildProcessor(IProcessor processor)
        {
            _notebook.Processor = processor;
        }

        public Notebook GetNotebook()
        {
            return _notebook;
        }
    }
}
