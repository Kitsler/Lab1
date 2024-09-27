namespace Lab.Data
{
	public class Stipendia
	{
		public int Id { get; set; }
		public int StudentId {  get; set; }
		public double Sredbal { get; set; }
		public int Stipend
		{
			get
			{
                if (this.Sredbal < 4.0)
                {
                    return 0;
                }
                else if (this.Sredbal >= 4 && this.Sredbal < 4.5)
                {
                    return 2000;
                }
                else if (this.Sredbal >= 4.5 && this.Sredbal < 5.0)
                {
                    return 2500;
                }
                else
                {
                    return 3000;
                }
            }
            set { }
		}

	}
}
