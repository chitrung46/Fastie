namespace DTO
{
    public class PositionInfo
    {
        private string idChucVu;
        private string tenChucVu;
        private string moTa;

        public PositionInfo(string idChucVu, string tenChucVu)
        {
            this.idChucVu = idChucVu;
            this.tenChucVu = tenChucVu;
        }

        public PositionInfo(string idChucVu, string tenChucVu, string moTa)
        {
            this.idChucVu = idChucVu;
            this.tenChucVu = tenChucVu;
            this.moTa = moTa;
        }

        public string IdChucVu { get => idChucVu; set => idChucVu = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
