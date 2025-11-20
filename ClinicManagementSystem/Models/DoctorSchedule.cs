namespace ClinicManagementSystem.Models
{
    public class DoctorSchedule
    {
        public Guid Id { get; set; }
        public Doctor Doctor { get; set; }
        public Guid DoctorId { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
