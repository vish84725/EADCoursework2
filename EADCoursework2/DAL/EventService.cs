﻿using EADCoursework2.Models;
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

        public async Task<Appointment> CreateAppointment(Appointment appointment)
        {
            try
            {
                var app = await MyWalletAPI<Appointment>.PostRequest($"{BASEURL}api/event/appointment", appointment);
                return app;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<TaskEvent> CreateTask(TaskEvent task)
        {
            try
            {
                var t = await MyWalletAPI<TaskEvent>.PostRequest($"{BASEURL}api/event/task", task);
                return t;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<Appointment>> GetAllAppointmentRange(List<Appointment> dto)
        {
            try
            {
                var t = await MyWalletAPI<List<Appointment>>.PostRequest($"{BASEURL}api/event/appointments/range", dto);
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
