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
                case "ReplicantRepository.DataTransferObjects.CustomerDto":
                    dynamicObject = o as CustomerDto;
                    if (dynamicObject != null)
                        result = dynamicObject.Name;
                    else
                        result = "Customer is null";
                    break;

                case "ReplicantRepository.DataTransferObjects.CustomerContactDto":
                    dynamicObject = o as CustomerContactDto;
                    result = dynamicObject.Person.Name + " " + dynamicObject.Person.LastName;
                    break;

                case "ReplicantRepository.DataTransferObjects.EmployeeDto":
                    dynamicObject = o as EmployeeDto;
                    if (dynamicObject.Person != null)
                        result = dynamicObject.Person.ToString();
                    else
                        result = "Person is null";
                    break;

                case "ReplicantRepository.DataTransferObjects.MeasureDto":
                    dynamicObject = o as MeasureDto;
                    result = dynamicObject.Symbol;
                    break;

                case "ReplicantRepository.DataTransferObjects.PersonDto":
                    dynamicObject = o as PersonDto;
                    result = dynamicObject.Name + " " + dynamicObject.LastName;
                    break;

                case "ReplicantRepository.DataTransferObjects.PersonPhoneDto":
                    dynamicObject = o as PersonPhoneDto;
                    result = dynamicObject.Phone;
                    break;

                case "ReplicantRepository.DataTransferObjects.PhoneTypeDto":
                    dynamicObject = o as PhoneTypeDto;
                    result = dynamicObject.Name;
                    break;

                case "ReplicantRepository.DataTransferObjects.ProjectStateDto":
                    dynamicObject = o as ProjectStateDto;
                    if (dynamicObject != null)
                        result = dynamicObject.Name;
                    else
                        result = "Project State is null";
                    break;

                case "ReplicantRepository.DataTransferObjects.ResourceTypeDto":
                    dynamicObject = o as ResourceTypeDto;
                    if (dynamicObject != null)
                        result = dynamicObject.Name;
                    else
                        result = "Resource Type is null";
                    break;

                case "ReplicantRepository.DataTransferObjects.TaskDto":
                    dynamicObject = o as TaskDto;
                    if (dynamicObject != null)
                        result = dynamicObject.Name;
                    else
                        result = "Task is null";
                    break;
                
                default:
                    result = o.GetType().ToString();
                    break;
            }
            return result;
        }

    }
}
