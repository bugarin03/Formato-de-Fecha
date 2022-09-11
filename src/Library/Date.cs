namespace TestDateFormat;

public class Date
{
    public string time;
    public int day;
    public int month;
    public int year;
    public Date(string TestDate)
    {
        this.time = TestDate;
        if (time.Length==10 )
        {
            this.year = int.Parse(TestDate.Substring(6));
            this.month = int.Parse(TestDate.Substring(3, 2));
            this.day = int.Parse(TestDate.Substring(0, 2));
        }
    }

    public bool Verification()
    {
        if (time.Length==10 )
        {
            if (1<=this.day && this.day<=31 && 1<=this.month && this.month<=12 )
            {
            return true;
            }
            else 
            {
            return false;
            }
        }
        else
        {
            return false;
        }
    }
}

/*
    Se agrega esta clase con dos propositos, en primer lugar se crea con el proposito
    de seguir los principios que aprendimos en clase y así en caso de que se quiera
    utilizar este codigo en el futuro se lo pueda reciclar sin tener problemas, 
    por esta misma razón pensamos en hacer una verificacion de que la fecha también sea correcta.
*/