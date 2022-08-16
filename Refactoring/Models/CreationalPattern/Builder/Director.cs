namespace Refactoring.Models.Builder
{
    public class Director
    {
        private IBuilder _builder;
        private Builder _builder1;

        public Builder Builder
        {
            get => _builder1;
            set => _builder1 = value;
        }

        public void Construct()
        {
            _builder.BuildA();
            _builder.BuildB();
            _builder.BuildC();
        }
    }
}
