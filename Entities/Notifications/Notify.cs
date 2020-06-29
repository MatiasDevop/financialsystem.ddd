using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notifications
{
    public class Notify
    {
        public Notify()
        {
            notifications = new List<Notify>();
        }

        [NotMapped]
        public string NameProperty { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notify> notifications;

        public bool ValidatePropertyString(string valor, string nameProperty)
        {

            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nameProperty))
            {
                notifications.Add(new Notify
                {
                    Message = "Field Obligatory",
                    NameProperty = nameProperty
                });

                return false;
            }

            return true;
        }

        public bool ValidatePropertyInt(int valor, string nameProperty)
        {

            if (valor < 1 || string.IsNullOrWhiteSpace(nameProperty))
            {
                notifications.Add(new Notify
                {
                    Message = "field obligatory",
                    NameProperty = "namProperty"
                });

                return false;
            }

            return true;

        }
    }
}
