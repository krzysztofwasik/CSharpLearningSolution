namespace BuilderPattern.Core
{
    public abstract class ComputerBuilder
    {
        protected readonly Computer computer = new Computer();
        public abstract void SetCores();
        public abstract void SetCpuFrequency();
        public abstract void SetRam();
        public abstract void SetDriveType();

        public virtual Computer GetComputer()
        {
            return this.computer;
        }
    }
}