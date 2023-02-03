using DAL;

namespace BL
{
    public class ExempleBL
    {
        public static string GetT()
        {
            return ExempleDAL.GetString("ABCDEF");
        }
    }
}