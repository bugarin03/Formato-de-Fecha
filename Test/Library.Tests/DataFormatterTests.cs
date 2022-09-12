using TestDateFormat;
namespace Library.Tests;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormat()
    {
        /*
        En este test se verifica que la fecha tenga el
        formato correcto
        */

        // Configuración:
        string actualDate = "10/11/1997";
        string expectedDate = "1997-11-10";
        //Ejecución:
        string convertedDate = DateFormatter.ChangeFormat(actualDate);
        //Comprobación:
        Assert.AreEqual(convertedDate, expectedDate);
    }

    [Test]
    public void WrongFormat()
    {
        /*
        En este test se verifica  en el caso de que la fecha 
        tenga un formato incorrecto.
        */

        // Configuración:
        string actualDate = "10/11/19971";
        string expectedDate = null;
        //Ejecución:
        string convertedDate = DateFormatter.ChangeFormat(actualDate);
        //Comprobación:
        Assert.IsNull(convertedDate, expectedDate);


    }
    [Test]
    public void EmptyFormat()
    {
        /*
        En este test se verifica  en el caso de que la fecha 
        tenga un formato vacio.
        */

        // Configuración:
        string actualDate = "";
        string expectedDate = null;
        //Ejecución:
        string convertedDate = DateFormatter.ChangeFormat(actualDate);
        //Comprobación:
        Assert.IsNull(convertedDate, expectedDate);
    }

}