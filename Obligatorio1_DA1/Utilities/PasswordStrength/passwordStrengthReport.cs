using Obligatorio1_DA1.Domain;

namespace Obligatorio1_DA1.Utilities
{
    public struct PasswordReportByCategoryAndColor
    {
        public Category Category { get; set; }
        public int Quantity { get; set; }
        public PasswordStrengthColor Color { get; set; }

    }

    public struct PasswordReportByColor
    {
        public int Quantity { get; set; }
        public PasswordStrengthColor Color { get; set; }

    }
}
