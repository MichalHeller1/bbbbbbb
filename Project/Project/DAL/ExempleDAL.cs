namespace DAL
{
    public class ExempleDAL
    {
        public static string GetString(string a)
        {
            string c=" ";
            foreach (int b in a)
            {
                c += (char)(b +50);
            }
            return c;
        }
    }
}