using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSample
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    CancellationTokenSource c = new CancellationTokenSource();

    private async void button2_Click(object sender, EventArgs e)
    {

      Console.WriteLine("Token" + c.Token);
      await DoAsync(c.Token);
    }

    async Task<int> DoAsync(CancellationToken token)
    {
      try
      {
        await Task.Delay(5000);

        if (token.IsCancellationRequested)
        {
          token.ThrowIfCancellationRequested();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

      return 5;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      c.Cancel();
    }
  }
}
