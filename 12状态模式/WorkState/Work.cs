namespace _12状态模式.WorkState
{
    public class Work
    {
        private State _state;
        public Work()
        {
            _state = new ForenoonState();
        }
        public double Hour { get; set; }
        public bool TaskFinished { get; set; }

        public void SetState(State s)
        {
            _state = s;
        }

        public void WriteProgram()
        {
            _state.WriteProgram(this);
        }
    }
}