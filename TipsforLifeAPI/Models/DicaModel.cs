using System.ComponentModel.DataAnnotations;

namespace TipsforLifeAPI.Entidades
{
    public class DicaModel
    {
        public int Id { get; set; }

        public Slip Slip { get; set; }
    }
}
