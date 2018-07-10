using System;
namespace gtk1.clases
{
    public class Operacion
    {
		private double num;
		private String op;
        
        public Operacion()
		{
			Num = 0;
			Op = "";
		}

		public double Num { get { return num; } set { num = value; } }
		public string Op { get { return op; } set { op = value; } }
	}
}
