﻿using BlazorToDoApp.Dto;
using BlazorToDoApp.Models;

namespace BlazorToDoApp.Shared
{
    public static class Mappers 
    {
        public static UserDto mapToDto(this UserModel userModel)
        {
            return new UserDto()
            {
                Username = userModel.Username,
                Password = userModel.Password,
            };
        }
    }
}
