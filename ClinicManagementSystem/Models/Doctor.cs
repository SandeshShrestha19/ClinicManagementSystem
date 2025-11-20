
namespace ClinicManagementSystem.Models
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Appointment> Appointments { get; set; } = new();
        public List<DoctorSchedule> Schedules { get; set; } = new();
    }
}
