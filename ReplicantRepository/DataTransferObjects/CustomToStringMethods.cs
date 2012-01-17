using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.DataTransferObjects
{
    internal static class CustomToStringMethods
    {
        internal static string ToString(object o)
        {
            string result;
            dynamic dynamicObject;
            switch (o.GetType().ToString())
            {
                case "ReplicantRepository.DataTransferObjects.PhoneTypeDto":
                    dynamicObject = o as PhoneTypeDto;
                    result = dynamicObject.Name;
                    break;
                case "ReplicantRepository.DataTransferObjects.CustomerContactDto":
                    dynamicObject = o as CustomerContactDto;
                    result = dynamicObject.Person.Name + " " + dynamicObject.Person.LastName;
                    break;
                case "ReplicantRepository.DataTransferObjects.PersonPhoneDto":
                    dynamicObject = o as PersonPhoneDto;
                    result = dynamicObject.Phone;
                    break;
                default:
                    result = o.GetType().ToString();
                    break;
            }
            return result;
        }

    }
}
