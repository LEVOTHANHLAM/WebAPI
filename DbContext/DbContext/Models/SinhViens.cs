using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class SinhVien
    {

        public Guid Id { get; set; }

        public string Email { get; set; }

        public string? MaSv { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? Cccd { get; set; }

        public string? Sdt { get; set; }

        public bool? Gender { get; set; }

        public Guid? IdPhong { get; set; }

        public Guid? IdTruong { get; set; }

        public string? BirthDay { get; set; }

        public bool? Status { get; set; }

        public string? Code { get; set; }

        public DateTime? CreateAt { get; set; }
    }
}
