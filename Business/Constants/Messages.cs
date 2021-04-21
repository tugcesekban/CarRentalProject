using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarAdded = "Car is added";
        public static string CarDescriptionInvalidandPrice = "Car description must be greater than 2 and daily price of the car must be greater than zero";
        public static string MaintenanceTime = "System is in Maintenance";
        public static string CarsListed = "Cars are listed";
        public static string BrandsListed = "Brands are listed";
        public static string ColorsListed = "Brands are listed";
        public static string CustomersListed = "Customers are listed";
        public static string UserListed = "Users are listed";
        public static string RentalListed = "Rentals are listed";
        public static string CarImagesListed = "Car Images are listed";
        public static string ImageCountExceeded = "Car Images are exceeded";
        public static string DeletedCarImage = "Car Images added";
        public static string UpdatedCarImage = "Car Images updated";
        public static string CarImageListed = "Car Images add";
        public static string AuthorizationDenied = "Authorization Denied";
        public static string UserAlreadyExists = "User Already Exists";
        public static string UserRegistered = "User Registered";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Successful Login";
        public static string AccessTokenCreated = "Access Token Created";
    }
}
