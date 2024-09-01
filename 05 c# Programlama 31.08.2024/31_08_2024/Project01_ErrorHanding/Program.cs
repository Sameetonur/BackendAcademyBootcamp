using System.Linq.Expressions;

namespace Project01_ErrorHanding;

class Program
{
    static void Main(string[] args)
    {
        #region Try Catch Syntax

        try
        {

        }
        catch (System.Exception)
        {

            throw;
        }

        #endregion

        #region Try Catch

        int say1 = default;
        int say2 = default;
        string result = default;

        try
        {
            System.Console.Write("1.Sayıyı giriniz :");
            say1 = int.Parse(Console.ReadLine());

            System.Console.Write("1.Sayıyı giriniz :");
            say2 = int.Parse(Console.ReadLine());

            result = (say1 / say2).ToString();

            System.Console.WriteLine(result);

        }
        catch (System.FormatException)
        {
            result = "Lütfen bir sayı giriniz!";


        }
        catch (System.OverflowException)
        {
            result = $" litfen {int.MinValue} ile {int.MinValue} arasında bir değer giriniz!";


        }
        catch (System.DivideByZeroException)
        {
            result = $" 0 girdiğiniz için default olarak 1'e bölme işlemi yapıldı.\n {say1.ToString()}";

        }
        catch (Exception ex)
        {
            result = ex.Message;
        }
        finally
        {
            System.Console.WriteLine(result);
        }





        #endregion
    }


}
