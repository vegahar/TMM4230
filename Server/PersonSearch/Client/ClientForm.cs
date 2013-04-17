using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Client.PersonSearch;

namespace Client
{
	public partial class SearchForn : Form
	{
		private WebService1SoapClient soapClient = new WebService1SoapClient();
		public SearchForn()
		{
			InitializeComponent();
		}

		private void SearchForn_Load(object sender, EventArgs e)
		{

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			listPersons.Items.Clear();
			List<Person> result = soapClient.search(textSearch.Text).ToList<Person>();
			foreach (Person a in result)
			{
				listPersons.Items.Add(a.Name);
			}
		}

		private void btnGetAllPersons_Click(object sender, EventArgs e)
		{
			listPersons.Items.Clear();
			List<Person> result = soapClient.getAll().ToList<Person>();
			foreach (Person a in result)
			{
				listPersons.Items.Add(a.Name);
			}
		}



	}
}
