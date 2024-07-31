namespace FormSample
{
  public partial class Form1 : Form
  {
    public Form1()
    {

      InitializeComponent();
      S�rali�slem();
    }

    // Senkron Kod de�il.
    public async Task S�rali�slem()
    {
      try
      {
        // bu bitene kadar sistemi uyut.
        var r1 = await GetResultAsync(200);
        var r2 = await GetResultAsync(100);
      }
      catch (Exception)
      {
        // hata yakalama.

        throw;
      }
     
    }


    private async void button1_Click(object sender, EventArgs e)
    {

      //txtResult.Text = GetResult();


      // Non-blocking �al��acak.


      //MessageBox.Show("1.��lem");
      //var t1 = GetResultAsync();
      //MessageBox.Show("2.��lem");
      ////var t2 = Task.Run(() => GetResultAsync2());

      //txtResult.Text = await t1;

      //// 1,3,2
      ////await t2;
      // Task k�t�phanesi �zerindeki methodlar

      var t1 = GetResultAsync(5000); // 3 sn
      var t2 = GetResultAsync(1000); // 10 sn => 10sn sonra ikisinide al�cam.

      // await t1.Result; �u yaz�m �eklinde direk bir task�n Resultan eri�ip kullan�rsak bu durunmda Blocking IO meydana gelir.
      // Bunun yerine
      await t1;
      var response1 = t1.Result;
      // Await ile Task uyutulduktan sonra result kullan�m� kodu Bloklamaz.

      //if(t1.IsCompletedSuccessfully || t1.)
      //{

      //}

      // When all ayn� anda ikiside ��z�mlenmeden sonu� vermez.
      // Promise.All �ok benzer.
      //var response = await Task.WhenAll(t1, t2);

      // hangisi daha �nce ��z�mlenir ise onu verir.
      // var response1 = await Task.WhenAny(t1, t2);

      // WhenAll veya WhenAny Non IO blocking �al���rlar sistemi kitlemezler rahat�a kullanabiliriz

      // Task.WaitAll() WaitAny() Bunlar Main Thread'i bloke eder. Bunlar�n kullam�ndan uzak duruyoruz.

      // Not Bazen senkron kod i�inde async method �a��r�l�m� ger�ekle�ebilir
      // GetResultAsync().GetAwaiter().GetResult(); // Main Thread Bloke eder.


    }

    public string GetResult()
    {
      Thread.Sleep(5000);
      return "Deneme";
    }

    // Not: E�er bir asenkron verinin sonucu Task method i�erisinde al�nacak ise await yazmak ve methoduda async olarak i�aretlemek zorunday�z.
    public async Task<string> GetResultAsync(int ms = 5000)
    {
      // Thread.Sleep(ms) den fakl� Non Blocking �al���r.
      await Task.Delay(ms);
      //MessageBox.Show("3.��lem");

      

      return "Deneme" + ms;
    }

    // awaitlik bir durum yoksa paralelde birbirinden ba��ms�z �al��an methodlar ise async await gerek yok
    public Task<string> GetResultAsync2()
    {
      Task.Delay(5000);
      return Task.FromResult("Deneme");
    }

    public Task<string> GetHtmlContent(string url)
    {
      return  new HttpClient().GetStringAsync(url);
    }

    private  async void button2_Click(object sender, EventArgs e)
    {
     GetHtmlContent("https://www.google.com").ContinueWith((data) =>
      {
        MessageBox.Show($"google.com: {data.Result.Length.ToString()}");

      });

    }

    private async void button3_Click(object sender, EventArgs e)
    {
      GetHtmlContent("https://www.n11.com").ContinueWith((data) =>
      {
        MessageBox.Show($"n11.com: ${data.Result.Length.ToString()} ");
      });

  
    }
  }
}