using EADCoursework2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.DAL
{
    interface IEventService
    {
        Task<Appointment> CreateAppointment(Appointment appointment);
        Task<TaskEvent> CreateTask(TaskEvent task);
        Task<List<TaskEvent>> GetAllTasks();
        Task<List<Appointment>> GetAllAppointments();
        Task<List<TaskEvent>> GetAllTasksRange(List<TaskEvent> dto);
        Task<List<Appointment>> GetAllAppointmentRange(List<Appointment> dto);
    }
}
