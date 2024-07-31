namespace FormSample
{
  public partial class Form1 : Form
  {
    public Form1()
    {

      InitializeComponent();
      SýraliÝslem();
    }

    // Senkron Kod deðil.
    public async Task SýraliÝslem()
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


      // Non-blocking çalýþacak.


      //MessageBox.Show("1.Ýþlem");
      //var t1 = GetResultAsync();
      //MessageBox.Show("2.Ýþlem");
      ////var t2 = Task.Run(() => GetResultAsync2());

      //txtResult.Text = await t1;

      //// 1,3,2
      ////await t2;
      // Task kütüphanesi üzerindeki methodlar

      var t1 = GetResultAsync(5000); // 3 sn
      var t2 = GetResultAsync(1000); // 10 sn => 10sn sonra ikisinide alýcam.

      // await t1.Result; þu yazým þeklinde direk bir taskýn Resultan eriþip kullanýrsak bu durunmda Blocking IO meydana gelir.
      // Bunun yerine
      await t1;
      var response1 = t1.Result;
      // Await ile Task uyutulduktan sonra result kullanýmý kodu Bloklamaz.

      //if(t1.IsCompletedSuccessfully || t1.)
      //{

      //}

      // When all ayný anda ikiside çözümlenmeden sonuç vermez.
      // Promise.All çok benzer.
      //var response = await Task.WhenAll(t1, t2);

      // hangisi daha önce çözümlenir ise onu verir.
      // var response1 = await Task.WhenAny(t1, t2);

      // WhenAll veya WhenAny Non IO blocking çalýþýrlar sistemi kitlemezler rahatça kullanabiliriz

      // Task.WaitAll() WaitAny() Bunlar Main Thread'i bloke eder. Bunlarýn kullamýndan uzak duruyoruz.

      // Not Bazen senkron kod içinde async method çaðýrýlýmý gerçekleþebilir
      // GetResultAsync().GetAwaiter().GetResult(); // Main Thread Bloke eder.


    }

    public string GetResult()
    {
      Thread.Sleep(5000);
      return "Deneme";
    }

    // Not: Eðer bir asenkron verinin sonucu Task method içerisinde alýnacak ise await yazmak ve methoduda async olarak iþaretlemek zorundayýz.
    public async Task<string> GetResultAsync(int ms = 5000)
    {
      // Thread.Sleep(ms) den faklý Non Blocking çalýþýr.
      await Task.Delay(ms);
      //MessageBox.Show("3.Ýþlem");

      

      return "Deneme" + ms;
    }

    // awaitlik bir durum yoksa paralelde birbirinden baðýmsýz çalýþan methodlar ise async await gerek yok
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