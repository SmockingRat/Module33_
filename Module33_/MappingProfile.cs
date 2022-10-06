using AutoMapper;
using System;

namespace Module33_
{
    public class MappingProfile: Profile
    {

        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
                .ConstructUsing(v => new UserViewModel(v));
        }

    }
}
