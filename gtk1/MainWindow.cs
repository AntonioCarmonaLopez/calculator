using System;
using System.Collections.Generic;
using Gtk;
using gtk1.clases;

public partial class MainWindow : Gtk.Window
{
	List<Operacion> tNumerosOperaciones = new List<Operacion>();
	bool signo = false;


	public MainWindow() : base(Gtk.WindowType.Toplevel) => Build();

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void OnBtnPuntoClicked(object sender, EventArgs e)
	{
		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "0.";
		}
		else
		{
			if (txtPantalla.Text.Contains(".") == false)
			{
				txtPantalla.Text = txtPantalla.Text + ".";
			}
		}
	}

	protected void OnBtnCeroClicked(object sender, EventArgs e)
	{
		Operacion operacion = new Operacion();
		operacion.Num = 0;
		operacion.Op = "";
		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "0";
		}
		else
		{
			txtPantalla.Text = txtPantalla.Text + "0";
		}
		tNumerosOperaciones.Add(operacion);
	}

	protected void OnBtnIgualClicked(object sender, EventArgs e)
	{
		double num1 = 0, num2 = 0, resul = 0;
		int contOperacion = 1;
		for (int i = 0; i < tNumerosOperaciones.Count; i++)
		{

			if (tNumerosOperaciones[i].Op.Equals("+"))
			{
				if (resul == 0 && contOperacion == 1)
				{
					num1 = tNumerosOperaciones[i - 1].Num;
					num2 = tNumerosOperaciones[i + 1].Num;
					resul = num1 + num2;
					txtPantalla.Text = resul.ToString();
					contOperacion = contOperacion + 1;
				}
				else
				{
					num2 = tNumerosOperaciones[i + 1].Num;
					resul = resul + num2;
					txtPantalla.Text = resul.ToString();
				}
			}
			else if (tNumerosOperaciones[i].Op.Equals("-"))
			{
				if (resul == 0 && contOperacion == 1)
				{
					num1 = tNumerosOperaciones[i - 1].Num;
					num2 = tNumerosOperaciones[i + 1].Num;
					resul = num1 - num2;
					txtPantalla.Text = resul.ToString();
					contOperacion = contOperacion + 1;
				}
				else
				{
					num2 = tNumerosOperaciones[i + 1].Num;
					resul = resul - num2;
					txtPantalla.Text = resul.ToString();
				}
			}
			else if (tNumerosOperaciones[i].Op.Equals("*"))
			{
				if (resul == 0 && contOperacion == 1)
				{
					num1 = tNumerosOperaciones[i - 1].Num;
					num2 = tNumerosOperaciones[i + 1].Num;
					resul = num1 * num2;
					txtPantalla.Text = resul.ToString();
					contOperacion = contOperacion + 1;
				}
				else
				{
					num2 = tNumerosOperaciones[i + 1].Num;
					resul = resul * num2;
					txtPantalla.Text = resul.ToString();
				}
			}
			else if (tNumerosOperaciones[i].Op.Equals("/"))
			{
				if (resul == 0 && contOperacion == 1)
				{
					num1 = tNumerosOperaciones[i - 1].Num;
					num2 = tNumerosOperaciones[i + 1].Num;
					resul = num1 / num2;
					txtPantalla.Text = resul.ToString();
					contOperacion = contOperacion + 1;
				}
				else
				{
					num2 = tNumerosOperaciones[i + 1].Num;
					resul = resul / num2;
					txtPantalla.Text = resul.ToString();
				}
			}else if (tNumerosOperaciones[i].Op.Equals("^"))
            {
                if (resul == 0 && contOperacion == 1)
                {
                    num1 = tNumerosOperaciones[i - 1].Num;
                    num2 = tNumerosOperaciones[i + 1].Num;
					resul = Math.Pow(num1, num2);
                    txtPantalla.Text = resul.ToString();
                    contOperacion = contOperacion + 1;
                }
                else
                {
                    num2 = tNumerosOperaciones[i + 1].Num;
					resul = Math.Pow(resul,num2);
                    txtPantalla.Text = resul.ToString();
                }
            }
		}
		signo = false;
	}

	protected void OnBtnMasClicked(object sender, EventArgs e)
	{
		if (txtPantalla.Text.Equals(""))
		{
			txtPantalla.Text = "";
		}
		else
		{
			Operacion operacion = new Operacion();
			operacion.Num = 0;
			operacion.Op = "+";

			txtPantalla.Text = txtPantalla.Text + "+";

			tNumerosOperaciones.Add(operacion);
		}
	}

	protected void OnBtnRestaClicked(object sender, EventArgs e)
	{
		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "";
		}
		else
		{
			Operacion operacion = new Operacion();
			operacion.Num = 0;
			operacion.Op = "-";

			txtPantalla.Text = txtPantalla.Text + "-";

			tNumerosOperaciones.Add(operacion);
		}
	}

	protected void OnBtn3Clicked(object sender, EventArgs e)
	{
		Operacion operacion = new Operacion();
		operacion.Num = 3;
		operacion.Op = "";

		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "3";
		}
		else
		{
			txtPantalla.Text = txtPantalla.Text + "3";
		}
		tNumerosOperaciones.Add(operacion);
	}

	protected void OnBtn2Clicked(object sender, EventArgs e)
	{
		Operacion operacion = new Operacion();
		operacion.Num = 2;
		operacion.Op = "";

		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "2";
		}
		else
		{
			txtPantalla.Text = txtPantalla.Text + "2";
		}
		tNumerosOperaciones.Add(operacion);
	}

	protected void OnBtn1Clicked(object sender, EventArgs e)
	{
		Operacion operacion = new Operacion();
		operacion.Num = 1;
		operacion.Op = "";

		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "1";
		}
		else
		{
			txtPantalla.Text = txtPantalla.Text + "1";
		}
		tNumerosOperaciones.Add(operacion);
	}

	protected void OnBtnMultClicked(object sender, EventArgs e)
	{
		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "";
		}
		else
		{
			Operacion operacion = new Operacion();
			operacion.Num = 0;
			operacion.Op = "*";

			txtPantalla.Text = txtPantalla.Text + "*";

			tNumerosOperaciones.Add(operacion);
		}
	}

	protected void OnBtn6Clicked(object sender, EventArgs e)
	{
		Operacion operacion = new Operacion();
		operacion.Num = 6;
		operacion.Op = "";

		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "6";
		}
		else
		{
			txtPantalla.Text = txtPantalla.Text + "6";
		}
		tNumerosOperaciones.Add(operacion);
	}

	protected void OnBtn5Clicked(object sender, EventArgs e)
	{
		Operacion operacion = new Operacion();
		operacion.Num = 5;
		operacion.Op = "";

		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "5";
		}
		else
		{
			txtPantalla.Text = txtPantalla.Text + "5";
		}
		tNumerosOperaciones.Add(operacion);
	}

	protected void OnBtn4Clicked(object sender, EventArgs e)
	{
		Operacion operacion = new Operacion();
		operacion.Num = 4;
		operacion.Op = "";

		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "4";
		}
		else
		{
			txtPantalla.Text = txtPantalla.Text + "4";
		}
		tNumerosOperaciones.Add(operacion);
	}

	protected void OnBtnDivClicked(object sender, EventArgs e)
	{
		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "";
		}
		else
		{
			Operacion operacion = new Operacion();
			operacion.Num = 0;
			operacion.Op = "/";

			txtPantalla.Text = txtPantalla.Text + "/";

			tNumerosOperaciones.Add(operacion);
		}
	}

	protected void OnBtn9Clicked(object sender, EventArgs e)
	{
		Operacion operacion = new Operacion();
		operacion.Num = 9;
		operacion.Op = "";

		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "9";
		}
		else
		{
			txtPantalla.Text = txtPantalla.Text + "9";
		}
		tNumerosOperaciones.Add(operacion);
	}

	protected void OnBtn8Clicked(object sender, EventArgs e)
	{
		Operacion operacion = new Operacion();
		operacion.Num = 8;
		operacion.Op = "";

		if (txtPantalla.Text == "")
		{
			txtPantalla.Text = "8";
		}
		else
		{
			txtPantalla.Text = txtPantalla.Text + "8";
		}
		tNumerosOperaciones.Add(operacion);
	}

	protected void OnBtn7Clicked(object sender, EventArgs e)
	{
		Operacion operacion = new Operacion();
		operacion.Op = "";

		if (txtPantalla.Text == "")
		{
			if (signo == true)
			{
				txtPantalla.Text = "-7";
				operacion.Num = -7;
			}
			else
			{
				txtPantalla.Text = "7";
				operacion.Num = 7;
			}
		}
		else
		{
			if (signo == true)
			{
				txtPantalla.Text = txtPantalla.Text + "-7";
				operacion.Num = -7;
			}
			else
			{
				txtPantalla.Text = txtPantalla.Text + "7";
				operacion.Num = 7;
			}
		}
		tNumerosOperaciones.Add(operacion);
	}


	protected void OnBtnLimpiarClicked(object sender, EventArgs e)
	{
		txtPantalla.Text = "";
	}



	protected void OnBtnSignoClicked(object sender, EventArgs e)
	{
		double num;

		if (txtPantalla.Text.Length > 0)
		{
			if (!txtPantalla.Text.Equals("-1"))
			{
				num = Convert.ToDouble(txtPantalla.Text) * -1;
				txtPantalla.Text = num.ToString();
				signo = true;
			}
			else
			{
				num = Convert.ToDouble(txtPantalla.Text.Substring(1, 2)) * -1;
				txtPantalla.Text = num.ToString();
				signo = false;
			}
		}
	}

	protected void OnBtnRetrocederClicked(object sender, EventArgs e)
	{
		if(txtPantalla.Text.Length>0)
		{
			txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
		}
	}

	protected void OnBtnInversaClicked(object sender, EventArgs e)
	{
		double cal = 1/Convert.ToDouble(txtPantalla.Text);
		txtPantalla.Text = Convert.ToString(cal);
	}

	protected void OnBtnRaizClicked(object sender, EventArgs e)
	{
		double cal = Math.Sqrt(Convert.ToDouble(txtPantalla.Text));
		txtPantalla.Text = Convert.ToString(cal);
	}

	protected void OnBtnSenoClicked(object sender, EventArgs e)
	{
		double x = Convert.ToDouble(txtPantalla.Text);
		double z = x * Math.PI / 180.0;
		txtPantalla.Text = Convert.ToString(Math.Sin(z));
	}

	protected void OnBtnCosenoClicked(object sender, EventArgs e)
	{
		double x = Convert.ToDouble(txtPantalla.Text);
        double z = x * Math.PI / 180.0;
		txtPantalla.Text = Convert.ToString(Math.Cos(z));
	}

	protected void OnBtnTangenteClicked(object sender, EventArgs e)
	{
		double x = Convert.ToDouble(txtPantalla.Text);
        double z = x * Math.PI / 180.0;
		txtPantalla.Text = Convert.ToString(Math.Tan(z));
	}

	protected void OnBtnExponenteClicked(object sender, EventArgs e)
	{
        if (txtPantalla.Text == "")
        {
            txtPantalla.Text = "";
        }
        else
        {
            Operacion operacion = new Operacion();
            operacion.Num = 0;
            operacion.Op = "^";

			txtPantalla.Text = txtPantalla.Text + "^";

            tNumerosOperaciones.Add(operacion);
        }
    }

	protected void OnBtnPiClicked(object sender, EventArgs e)
	{
        Operacion operacion = new Operacion();
		operacion.Num = Math.PI;
        operacion.Op = "";

        if (txtPantalla.Text == "")
        {
			txtPantalla.Text = Convert.ToString(Math.PI);
        }
        else
        {
			txtPantalla.Text = txtPantalla.Text + Convert.ToString(Math.PI);
        }
        tNumerosOperaciones.Add(operacion);
    }

	protected void OnBtnEClicked(object sender, EventArgs e)
	{
		Operacion operacion = new Operacion();
		operacion.Num = Math.E;
        operacion.Op = "";

        if (txtPantalla.Text == "")
        {
            txtPantalla.Text = Convert.ToString(Math.E);
        }
        else
        {
            txtPantalla.Text = txtPantalla.Text + Convert.ToString(Math.E);
        }
        tNumerosOperaciones.Add(operacion);
	}

	protected void OnBtnLOGClicked(object sender, EventArgs e)
	{
        double x = Convert.ToDouble(txtPantalla.Text);
        txtPantalla.Text = Convert.ToString(Math.Log10(x));
    }
}

