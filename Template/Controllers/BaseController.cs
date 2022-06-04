
using ApplicationCore.Interface.Base;
using ApplicationCore.Spesification;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Template.Domain.Entity;
using Template.Helper;
using Template.Interface;
using Template.ViewModels;

namespace Template.Controllers
{
    public class BaseController : Controller
    {
        public void Warning(string message)
        {
            if (!TempData.ContainsKey(Alerts.WARNING))
            {
                TempData.Add(Alerts.WARNING, message);
            }
            else
            {
                TempData[Alerts.WARNING] = message;
            }
        }
        public void Success(string message)
        {
            if (!TempData.ContainsKey(Alerts.SUCCESS))
            {
                TempData.Add(Alerts.SUCCESS, message);
            }
            else
            {
                TempData[Alerts.SUCCESS] = message;
            }
        }
        public void Information(string message)
        {
            if (!TempData.ContainsKey(Alerts.INFORMATION))
            {
                TempData.Add(Alerts.INFORMATION, message);
            }
            else
            {
                TempData[Alerts.INFORMATION] = message;
            }
        }
        public void Error(string message)
        {
            if (!TempData.ContainsKey(Alerts.ERROR))
            {
                TempData.Add(Alerts.ERROR, message);
            }
            else
            {
                TempData[Alerts.ERROR] = message;
            }
        }
    }
}
