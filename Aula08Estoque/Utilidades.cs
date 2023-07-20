using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08Estoque
{
	internal class Utilidades
	{
		public void mostraMensagem() {

			MessageBox.Show("KKKKKKKKKKKKKKKKKKKKKKK");

		}

		public bool textBoxEstaVazio( TextBox txt)
		{
			if (txt.Text == "")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
