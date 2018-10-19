using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //https://medium.com/bynder-tech/c-why-you-should-use-configureawait-false-in-your-library-code-d7837dce3d7f
        private void DoCurlAsyncButton(object sender, EventArgs e)
        {
            var wirtekContents = DoCurlAsync();
            wirtekContents.Wait();
            Console.WriteLine(wirtekContents);
        }

        async Task<string> DoCurlAsync()
        {
            using (var httpClient = new HttpClient())
            using (var httpResponse = await httpClient.GetAsync("http://vikings.wirtek.ro/"))
            {
                return await httpResponse.Content.ReadAsStringAsync();
            }
        }
    }
}
