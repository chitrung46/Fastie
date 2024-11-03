namespace DTO
{
    public class Position
    {
        private string id;
        private string ten;
        private string moTa;

        public Position(string id, string ten, string moTa)
        {
            this.id = id;
            this.ten = ten;
            this.moTa = moTa;
        }
        public Position() { }
        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
