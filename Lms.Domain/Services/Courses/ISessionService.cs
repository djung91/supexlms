﻿using Lms.Domain.Models.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Services.Courses
{
    public interface ISessionService
    {
        Session GetSessionById(string companyId, string sessionId);

        void CreateSession(string companyId, string courseId, string sessionName, string description, string cost,
            string sessionStartDate, string sessionEndDate, string enrollmentStartDate, string enrollmentEndDate);

        void DeleteSession(string companyId, string updaterId, string courseId, string sessionId);

        IEnumerable<Session> LoadNewSessions(string companyId, string userId);

        void EnrollUser(string userId, string sessionId);

        void WithdrawEnrollment(string enrollmentId, string userId);

        void ChargeSession(string userId, string sessionId, string cardNumber, string expireYear, string expireMonth, string cvv2);
    }
}