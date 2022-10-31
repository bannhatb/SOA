namespace DatingApp.API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int GetAge(this DateTime? dateOfBirth)
        {
 
            var today = DateTime.Now;
            var age = today.Year - dateOfBirth.Value.Year;
            return age;
        }
    }
}
