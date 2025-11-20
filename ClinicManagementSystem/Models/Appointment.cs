
using ClinicManagementSystem.Models.Enums;

namespace ClinicManagementSystem.Models
{
    public class Appointment
    {
        public Guid Id { get; set; }

        public Patient Patient { get; set; }
        public Guid PatientId { get; set; }
        public Doctor Doctor { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Description { get; set; }
        public AppointmentStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
