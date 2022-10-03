namespace MargheritaPub.Data
{
    public class Dish
    {
        public int Id { get; set; }
        public string NameEN { get; set; } = string.Empty;
        public string NamePL { get; set; } = string.Empty;
        public string DescriptionEN { get; set; } = string.Empty;
        public string DescriptionPL { get; set; } = string.Empty;
        public double PriceS { get; set; }
        public double PriceN { get; set; }
        public double PriceL { get; set; }
        public string Photo { get; set; } = string.Empty;
        public string CategoryEN { get; set; } = string.Empty;
        public string CategoryPL { get; set; } = string.Empty;

    }
}
