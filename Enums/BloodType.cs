using System.ComponentModel;

namespace CellBank.Enums
{
    enum BloodType
    {
        [Description("A+")]
        Apos,

        [Description("B+")]
        Bpos,

        [Description("AB+")]
        ABpos,

        [Description("O+")]
        Opos,

        [Description("A-")]
        Aneg,

        [Description("B-")]
        Bneg,

        [Description("AB-")]
        ABneg,

        [Description("O-")]
        Oneg,
    }
}
