using EADCoursework2.Models;
using EADCoursework2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.DAL
{
    public class EventService : IEventService
    {
        private const String BASEURL = Constants.BASEURL;
        RemoteAccessService remoteAccessService = new RemoteAccessService();

        public async Task<Appointment> CreateAppointment(Appointment appointment)
        {
            try
            {
                remoteAccessService.WriteToXML<Appointment>(appointment);
                var app = await MyWalletAPI<Appointment>.PostRequest($"{BASEURL}api/event/appointment", appointment);
                if (app != null && app.Id != 0)
                    remoteAccessService.ClearCachedObject<Appointment>(appointment);
                return app;
            }
            catch (Exception e)
            {
                return new Appointment();
            }
        }

        public async Task<TaskEvent> CreateTask(TaskEvent task)
        {
            try
            {
                remoteAccessService.WriteToXML<TaskEvent>(task);
                var t = await MyWalletAPI<TaskEvent>.PostRequest($"{BASEURL}api/event/task", task);
                if (t != null && t.Id != 0)
                    remoteAccessService.ClearCachedObject<TaskEvent>(task);
                return t;
            }
            catch (Exception e)
            {
                return new TaskEvent();
            }
        }

        public async Task<List<Appointment>> GetAllAppointmentRange(List<Appointment> dto)
        {
            try
            {
                var t = await MyWalletAPI<List<Appointment>>.PostRequest($"{BASEURL}api/event/appointment/range", dto);
                return t;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<Appointment>> GetAllAppointments()
        {
            try
            {
                var appointments = await MyWalletAPI<List<Appointment>>.Get($"{BASEURL}api/event/appointment");
                return appointments;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<TaskEvent>> GetAllTasks()
        {
            try
            {
                var tasks = await MyWalletAPI<List<TaskEvent>>.Get($"{BASEURL}api/event/task");
                return tasks;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<TaskEvent>> GetAllTasksRange(List<TaskEvent> dto)
        {
            try
            {
                var t = await MyWalletAPI< List<TaskEvent>>.PostRequest($"{BASEURL}api/event/task/range", dto);
                return t;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
