namespace DatingApp.API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int GetAge(this DateTime? dateOfBirth)
        {
            if (!dateOfBirth.HasValue) return 0;
 
            var today = DateTime.Now;
            var age = today.Year - dateOfBirth.Value.Year;
            if (dateOfBirth.Value.Date > today.AddYears(-age)) age--;
            return age;
        }

    }
}
